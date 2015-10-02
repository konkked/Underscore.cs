namespace Underscore.Object
{
    public interface ITransposeComponent 
    {
        /// <summary>
        /// Takes all of the properties 
        /// from the source object and 
        /// puts them to the destination
        /// </summary>
        /// <param name="destination">The object to take the properties from</param>
        /// <param name="source">The object to put the properties into</param>
        void Transpose( object source , object destination );


        /// <summary>
        /// Takes all of the properties 
        /// from the source object and 
        /// puts them to the destination
        /// </summary>
        /// <param name="destination">The object to take the properties from</param>
        /// <param name="source">The object to put the properties into</param>
        TFirst Coalesce<TFirst>( TFirst first , object second );


        /// <summary>
        /// Takes all of the properties 
        /// from the source object and 
        /// puts them to the destination
        /// </summary>
        /// <param name="destination">The object to take the properties from</param>
        /// <param name="source">The object to put the properties into</param>
        TFirst Coalesce<TFirst>( TFirst first , object second , bool newObject) where TFirst : new();
    }

}
