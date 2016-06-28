# script to generate the tests for Function.Boolean.Negate(),
# because there are ~40 of them

import sys
import os

def lowercase_letters():
    return list(map(chr, range(97, 123)))

def generate_all_test_cases():
    retval = ''

    for i in range(0, 17):
        retval += generate_test_case_pair(i)

    return retval

def generate_test_case_pair(num_params):
    return generate_test_case(True, num_params) + generate_test_case(False, num_params)

def generate_test_case(input_bool, num_params):
    lambda_vars = lowercase_letters()[:num_params]
    cap_bool_name = 'True' if input_bool else 'False'
    lower_bool_name = 'true' if input_bool else 'false'

    num_param_str = str(num_params) if num_params > 0 else 'No'
    argument_count_str = 'Arguments_' if num_params != 1 else 'Argument_'

    object_declaration = '\t\t\t// this is just used to fill params\n\t\t\tvar obj = new object();\n' if num_params > 0 else ''

    retval = '\t\t[TestMethod]\n'
    retval += '\t\tpublic void Function_Boolean_Negate_' + num_param_str + argument_count_str + cap_bool_name +'Input()\n'
    retval += '\t\t{\n'
    retval += object_declaration
    retval += '\t\t\tFunc<'

    # add an object to the func type signature for each param we're using
    for i in range(0, num_params):
        retval += 'object, '
    # add a bool for the return type
    retval += 'bool> toNegate = ('
    # put all the var names into arg declaration except the last one so we can have proper syntax
    for i in range(0, len(lambda_vars) - 1):
        retval += lambda_vars[i] + ', '

    lastArg = lambda_vars[-1] if num_params > 0 else ''

    retval += lastArg + ') => ' + lower_bool_name + ';\n'
    retval += '\n'

    retval += '\t\t\tvar negated = component.Negate(toNegate);\n'
    retval += '\n'

    assert_val = 'False' if input_bool else 'True'
    retval += '\t\t\tAssert.Is' + assert_val + '(negated('

    for i in range(0, num_params - 1):
        retval += 'obj, '

    lastArg = 'obj' if num_params > 0 else ''

    retval += lastArg + '));\n'
    # close function block
    retval += '\t\t}\n'
    retval += '\n'

    return retval

def test_file():
    return os.path.join(os.path.dirname(__file__), '..', 'Underscore.Test', 'Function', 'Boolean', 'NegateTest.cs')

def write_to_file(output):
    with open(test_file(), 'w') as f:
        f.write(output)

# so we avoid global scope
def main():
    output = '';

    # includes
    output += 'using System;\n'
    output += 'using Microsoft.VisualStudio.TestTools.UnitTesting;\n'
    # make sure we include the right component
    output += 'using Underscore.Function;\n'

    # make sure it's in the right namespace
    output += 'namespace Underscore.Test.Boolean\n'

    # declare our class and our helper function
    output += '{\n'
    output += '\t// Generated using /codegen/boolean_negate_test.py\n'
    output += '\t[TestClass]\n'
    output += '\tpublic class NegateTest\n'
    output += '\t{\n'

    # declare the initialization variables
    output += '\t\tprivate BooleanComponent component;\n\n'
    output += '\t\t[TestInitialize]\n'
    output += '\t\tpublic void Initialize()\n'
    output += '\t\t{\n'
    output += '\t\t\tcomponent = new BooleanComponent();\n'
    output += '\t\t}\n\n'

    # generate the actual test cases
    output += generate_all_test_cases()

    # end class block
    output += '\t}\n'
    # end namespace block
    output += '}'

    write_to_file(output)

main()
