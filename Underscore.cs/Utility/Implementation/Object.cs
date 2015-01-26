using System;

namespace Underscore.Utility
{
    public class ObjectComponent : IObjectComponent
    {
        /// <summary>
        /// Returns true if an object is truthy,
        /// basically if the value is not the default
        /// value of the that type then returns true
        /// one exception are strings 
        /// which return false if empty or null
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool IsTruthy( object target )
        {
            if ( target is string )
            {
                return !string.IsNullOrWhiteSpace( ( string ) target );
            }
            else if (
                ( target is int ) ||
                ( target is uint ) ||
                ( target is decimal ) ||
                ( target is double ) ||
                ( target is long ) ||
                ( target is ulong ) )
            {
                // TODO:
                // Test to see if this is 
                // the fastest way to determine 
                // if is zero
                //
                // this is probably faster 
                // than using reflection
                // to instantiate, but haven't tested
                // 
                var result = Convert.ToDecimal( target );
                result = Decimal.Ceiling( result );
                var intResult = Decimal.ToInt32( result );

                return intResult != 0;
            }
            else if ( target is bool ) 
            {
                return ( bool ) target;
            }
            else
            {
                //if the type is a reference type then the default is null
                //if is value type will pass with stmt
                return target != null && 
                    //otherwise is a value type or is a class type with a value
                    (
                        //if it is a class type, then done
                        !target.GetType( ).IsValueType ||
                        //otherwise check and see if the default for the value type is
                        //the value of the passed object
                        target != Activator.CreateInstance( target.GetType( ) )
                    );
            }
        }
    }
}
