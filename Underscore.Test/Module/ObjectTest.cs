using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Object;
using Underscore.Object.Reflection;

namespace Underscore.Test.Module
{
    [ TestClass ]
    public class ObjectTest
    {

        [ TestMethod ]
        public async Task ObjectCreate()
        {
            await Util.Tasks.Start(() =>
            {
                var cacher = new global::Underscore.Function.CacheComponent();
                var util = new global::Underscore.Utility.FunctionComponent();

                var property = new PropertyComponent( cacher );
                var methods = new MethodComponent( cacher, property);
                var field = new FieldComponent( cacher );
                var ctor = new ConstructorComponent(cacher, property);
                var transformation = new TransposeComponent(property);

                var example = new Underscore.Module.Object (
                    property,
                    methods,
                    field,
                    ctor,
                    transformation
                ) ;

                Assert.IsNotNull(example);
            });
        }







    }
}
