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
    return generate_test_case(True, num_params, False) + generate_test_case(False, num_params, False) + generate_test_case(True, num_params, True)

def generate_test_case(input_bool, num_params, mixed):
    lambda_vars = lowercase_letters()[:num_params]
    cap_bool_name = 'True' if input_bool else 'False'
    lower_bool_name = 'true' if input_bool else 'false'
    opposite_bool = 'false' if input_bool else 'true'

    num_param_str = str(num_params) if num_params > 0 else 'No'
    argument_count_str = 'Arguments_' if num_params != 1 else 'Argument_'
    mixed_str = 'Mixed' if mixed else ''

    object_declaration = '\t\t\t// this is just used to fill params\n\t\t\tvar obj = new object();\n' if num_params > 0 else ''

    retval = '\t\t[TestMethod]\n'
    retval += '\t\tpublic void Function_Boolean_And_' + num_param_str + argument_count_str + cap_bool_name + 'Input' + mixed_str + '()\n'
    retval += '\t\t{\n'
    retval += object_declaration
    retval += '\t\t\tvar funcsToCombine = new List<Func<'

    # add an object to the func type signature for each param we're using
    for i in range(0, num_params):
        retval += 'object, '
    # add a bool for the return type
    retval += 'bool>>\n'
    retval += '\t\t\t{\n'
    # enter multiple lambdas
    for i in range(0, 4):
        retval += '\t\t\t\t('
        # put all the var names into arg declaration except the last one so we can have proper syntax
        for j in range(0, len(lambda_vars) - 1):
            retval += lambda_vars[j] + ', '

        lastArg = lambda_vars[-1] if num_params > 0 else ''

        bool_val = lower_bool_name if not (mixed and i == 2) else opposite_bool
        retval += lastArg + ') => (wasCalled[' + str(i) + '] = true) && ' + bool_val + ',\n'
    retval += '\t\t\t};\n'
    retval += '\n'

    retval += '\t\t\tvar combined = component.And(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);\n'
    retval += '\n'

    assert_val = cap_bool_name if not mixed else 'False'
    retval += '\t\t\tAssert.Is' + assert_val + '(combined('

    for i in range(0, num_params - 1):
        retval += 'obj, '

    lastArg = 'obj' if num_params > 0 else ''

    retval += lastArg + '));\n'

    # the first function always gets called
    retval += '\t\t\tAssert.IsTrue(wasCalled[0]);\n'

    if input_bool:
        for i in range(1, 3):
            retval += '\t\t\tAssert.IsTrue(wasCalled[' + str(i) + ']);\n'
    else:
        for i in range(1, 3):
            retval += '\t\t\tAssert.IsFalse(wasCalled[' + str(i) + ']);\n'

    last_was_called = 'True' if not mixed and input_bool else 'False'
    retval += '\t\t\tAssert.Is' + last_was_called + '(wasCalled[' + str(3) + ']);\n'

    # close function block
    retval += '\t\t}\n'
    retval += '\n'

    return retval

def test_file():
    return os.path.join(os.path.dirname(__file__), '..', 'Underscore.Test', 'Function', 'Boolean', 'AndTest.cs')

def write_to_file(output):
    with open(test_file(), 'w') as f:
        f.write(output)

# so we avoid global scope
def main():
    output = '';

    # includes
    output += 'using System;\n'
    output += 'using Microsoft.VisualStudio.TestTools.UnitTesting;\n'
    output += 'using System.Collections.Generic;\n'
    output += 'using Underscore.Function;\n'
    output += '\n'
    output += 'namespace Underscore.Test.Boolean\n'

    # declare our class and our helper function
    output += '{\n'
    output += '\t// Generated using /codegen/boolean_and_test.py\n'
    output += '\t[TestClass]\n'
    output += '\tpublic class AndTest\n'
    output += '\t{\n'

    # declare the initialization variables
    output += '\t\tprivate AndComponent component;\n'
    output += '\t\tprivate bool[] wasCalled;\n'
    output += '\n'
    output += '\t\t[TestInitialize]\n'
    output += '\t\tpublic void Initialize()\n'
    output += '\t\t{\n'
    output += '\t\t\tcomponent = new AndComponent();\n'
    output += '\t\t\twasCalled = new[] {false, false, false, false};\n'
    output += '\t\t}\n'
    output += '\n'

    # generate the actual test cases
    output += generate_all_test_cases()

    # end class block
    output += '\t}\n'
    # end namespace block
    output += '}'

    write_to_file(output)

main()
