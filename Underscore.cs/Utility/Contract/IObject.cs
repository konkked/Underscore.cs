namespace Underscore.Utility
{
    public interface IObjectComponent
    {
        /// <summary>
        /// Returns true if an object is truthy,
        /// basically if the value is not the default
        /// value of the that type then returns true
        /// one exception are strings 
        /// which return false if empty or null
        /// </summary>
        bool IsTruthy(object target);
    }
}
