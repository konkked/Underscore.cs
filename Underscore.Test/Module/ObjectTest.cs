using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Function;
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
                var cacher = new CacheComponent(new Underscore.Function.CompactComponent(), new Underscore.Utility.CompactComponent());

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
