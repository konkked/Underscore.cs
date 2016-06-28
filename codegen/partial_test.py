# script to generate the tests for Action.Partial
# and Function.Partial, since there's 120 tests for each

import sys
import os

def expected(var_names):
    retval = ''
    for c in var_names:
        retval += c + ' '
    return retval.strip()

def lowercase_letters():
    return list(map(chr, range(97, 123)))

def generate_variable_declarations():
    retval = ''
    # for each character in range [a..p]
    for c in lowercase_letters()[:16]:
        # adds line like 'private const string Arg1 = "a";'
        retval += '\t\tprivate const string Arg' + str((ord(c) - 96)) + ' = "' + c + '";\n'
    return retval

def generate_var_names():
    retval = []
    for i in range(1, 17):
        retval.append('Arg' + str(i))
    return retval

def generate_all_test_cases(type_name):
    retval = ''

    for i in range(2, 17):
        retval += generate_test_cases_for_count(i, type_name)

    return retval

def generate_test_cases_for_count(param_count, type_name):
    retval = ''

    # get however many var names we need from the list
    var_names = lowercase_letters()[:param_count]
    for i in range(1, param_count):
        retval += generate_test_case_function(var_names, i) if type_name == 'Function' else generate_test_case_action(var_names, i)

    return retval

def generate_test_case_function(var_names, num_params_to_bind):
    lambda_vars = lowercase_letters()[:len(var_names)]

    retval = '\t\t[TestMethod]\n'
    retval += '\t\tpublic void Function_Partial_' + str(len(var_names)) + 'Arguments' + str(num_params_to_bind) + 'Bound()\n'
    retval += '\t\t{\n'
    retval += '\t\t\tconst string expected = "' + expected(lambda_vars) + '";\n'
    retval += '\n'
    retval += '\t\t\tFunc<'

    # add a string to the func type signature for each var we're using
    for s in var_names:
        retval += 'string, '
    # add a final string type param for return type
    retval += 'string> toBind = ('
    # put all the var names into arg declaration except the last one so we can have proper syntax
    for i in range(0, len(var_names) - 1):
        retval += var_names[i] + ', '

    # add the last element to arg declaration
    retval += var_names[-1] + ') => Join('

    # put all the var names into the logic except the last one so we can have proper syntax
    for i in range(0, len(var_names) - 1):
        retval += var_names[i] + ', '

    # add the last element to logic
    retval += var_names[-1] + ');\n'
    retval += '\n'

    retval += '\t\t\tvar binding = component.Partial(toBind, '

    args = generate_var_names()

    args_to_bind = args[:num_params_to_bind]
    args_to_pass = args[num_params_to_bind:len(var_names)]

    # bind however many args we're testing about to toBind
    for i in range(0, len(args_to_bind) - 1):
        retval += args_to_bind[i] + ', '
    # add last arg to partial binding and close line
    retval += args_to_bind[-1] + ');\n'

    # call binding with remaining args
    retval += '\t\t\tvar result = binding('
    for i in range(0, len(args_to_pass) - 1):
        retval += args_to_pass[i] + ', '
    retval += args_to_pass[-1] + ');\n'
    retval += '\n'

    retval += '\t\t\tAssert.AreEqual(expected, result);\n'
    # close function block
    retval += '\t\t}\n'
    retval += '\n'

    return retval

def generate_test_case_action(var_names, num_params_to_bind):
    lambda_vars = lowercase_letters()[:len(var_names)]

    retval = '\t\t[TestMethod]\n'
    retval += '\t\tpublic void Action_Partial_' + str(len(var_names)) + 'Arguments' + str(num_params_to_bind) + 'Bound()\n'
    retval += '\t\t{\n'
    retval += '\t\t\tconst string expected = "' + expected(lambda_vars) + '";\n'
    retval += '\n'
    retval += '\t\t\tAction<'

    # add a string to the func type signature for each var we're using
    for i in range(0, len(var_names) - 1):
        retval += 'string, '
    # add a final string type param for return type
    retval += 'string> toBind = ('
    # put all the var names into arg declaration except the last one so we can have proper syntax
    for i in range(0, len(var_names) - 1):
        retval += var_names[i] + ', '

    # add the last element to arg declaration
    retval += var_names[-1] + ') => output[0] = Join('

    # put all the var names into the logic except the last one so we can have proper syntax
    for i in range(0, len(var_names) - 1):
        retval += var_names[i] + ', '

    # add the last element to logic
    retval += var_names[-1] + ');\n'
    retval += '\n'

    retval += '\t\t\tvar binding = component.Partial(toBind, '

    args = generate_var_names()

    args_to_bind = args[:num_params_to_bind]
    args_to_pass = args[num_params_to_bind:len(var_names)]

    # bind however many args we're testing about to toBind
    for i in range(0, len(args_to_bind) - 1):
        retval += args_to_bind[i] + ', '
    # add last arg to partial binding and close line
    retval += args_to_bind[-1] + ');\n'

    # call binding with remaining args
    retval += '\t\t\tbinding('
    for i in range(0, len(args_to_pass) - 1):
        retval += args_to_pass[i] + ', '
    retval += args_to_pass[-1] + ');\n'
    retval += '\n'

    retval += '\t\t\tAssert.AreEqual(expected, output[0]);\n'
    # close function block
    retval += '\t\t}\n'
    retval += '\n'

    return retval

def action_test_file():
    return os.path.join(os.path.dirname(__file__), '..', 'Underscore.Test', 'Action', 'PartialTest.cs')

def function_test_file():
    return os.path.join(os.path.dirname(__file__), '..', 'Underscore.Test', 'Function', 'PartialTest.cs')

def write_to_file(output, type_name):
    # get the filename for the given type
    file_path = function_test_file() if type_name == 'Function' else action_test_file()

    with open(file_path, 'w') as f:
        f.write(output)

# so we avoid global scope
def main():
    # make sure we got a type argument
    if not (len(sys.argv) == 2 and (sys.argv[1] == '-f' or sys.argv[1] == '-a')):
        print 'must provide either -f or -a flag, representing Function and Action PartialTest files, given ' + str(sys.argv)
        sys.exit()

    # get the file type based on the arg
    type_name = 'Function' if sys.argv[1] == '-f' else 'Action'

    output = '';

    # includes
    output += 'using System;\n'
    output += 'using Microsoft.VisualStudio.TestTools.UnitTesting;\n'
    # make sure we include the right component
    output += 'using Underscore.' + type_name + ';\n'
    output += 'using System.Linq;\n\n'

    # make sure it's in the right namespace
    output += 'namespace Underscore.Test.' + type_name

    # declare our class and our helper function
    output += '{\n'
    output += '\t// Generated using /codegen/partial_test.py\n'
    output += '\t[TestClass]\n'
    output += '\tpublic class PartialTest\n'
    output += '\t{\n'
    output += '\t\tprivate static string Join(params string[] args)\n'
    output += '\t\t{\n'
    output += '\t\t\treturn string.Join(" ", args.Where(s => !string.IsNullOrEmpty(s)));\n'
    output += '\t\t}\n\n'

    # add const variable declarations
    output += generate_variable_declarations()
    output += '\n'

    # declare the initialization variables
    output += '\t\tprivate PartialComponent component;\n\n'
    # only the action implementation needs to use this
    if type_name == 'Action':
        output += '\t\tprivate string[] output;\n\n'
    output += '\t\t[TestInitialize]\n'
    output += '\t\tpublic void Initialize()\n'
    output += '\t\t{\n'
    output += '\t\t\tcomponent = new PartialComponent();\n'
    if type_name == 'Action':
        output += '\t\t\toutput = new string[1];\n'
    output += '\t\t}\n\n'

    # generate the actual test cases
    output += generate_all_test_cases(type_name)

    # end class block
    output += '\t}\n'
    # end namespace block
    output += '}'

    write_to_file(output, type_name)

main()
