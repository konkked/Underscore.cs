
namespace Underscore
{
    // TODO: Create an interface for wrapping into object, exposing a new set of functions and 

    public class _
    {
        private readonly Module.Action _action;
        private readonly Module.Collection _collection;
        private readonly Module.Function _function;
        private readonly Module.List _list;
        private readonly Module.Object _object;
        private readonly Module.Utility _utility;

        private static readonly _ s_instance;


        static _()
        {
            s_instance = new _();
        }

        //don't want to expose public empty ctor, 
        // so will hookup dependencies manually in this case
        //(Normally do not do this)
        private _()
        {
            var kernel = Bootstrapper.Kernel;

            _action = kernel.Resolve<Module.Action>();
            _collection = kernel.Resolve<Module.Collection>();
            _function = kernel.Resolve<Module.Function>();
            _list = kernel.Resolve<Module.List>();
            _object = kernel.Resolve<Module.Object>();
            _utility = kernel.Resolve<Module.Utility>();

        }

        public static Module.Action Action
        {
            get
            {
                return s_instance._action;
            }
        }

        public static Module.Collection Collection
        {
            get
            {
                return s_instance._collection;
            }
        }

        public static Module.Function Function
        {
            get
            {
                return s_instance._function;
            }
        }

        public static Module.List List
        {
            get
            {
                return s_instance._list;
            }
        }

        public static Module.Object Object
        {
            get
            {
                return s_instance._object;
            }
        }

        public static Module.Utility Utility
        {
            get
            {
                return s_instance._utility;
            }
        }

    }
}
