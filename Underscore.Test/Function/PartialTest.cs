using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Function;
using System.Linq;

namespace Underscore.Test.Function
{
    [TestClass]
    public class PartialTest
    {
        private static string Join( params string[ ] args )
        {
            return string.Join( " ", values: ( args ).Where( trg => trg != null ) );
        }




        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o, string p)
        {
            return Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }



        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o)
        {
            return Join(a, b, c, d, e, f, g, h, i, j, k, l, m,n,o);
        }


        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n)
        {
            return Join(a, b, c, d, e, f, g, h, i, j, k, l, m,n);
        }

        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m)
        {
            return Join(a, b, c, d, e, f, g, h, i, j, k, l,m);
        }
        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l)
        {
            return Join(a, b, c, d, e, f, g, h, i, j, k,l);
        }
        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {
            return Join(a, b, c, d, e, f, g, h, i, j,k);
        }

        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            return Join(a, b, c, d, e, f, g, h, i, j);
        }

        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            return Join(a, b, c, d, e, f, g, h, i);
        }

        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            return Join(a, b, c, d, e, f, g,h);
        }

        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f,string g)
        {
            return Join(a, b, c, d, e, f,g);
        }


        private static string BindPartialFunctionTarget(string a, string b, string c, string d, string e, string f)
        {
            return Join(a, b, c, d, e, f);
        }

        private static string BindPartialFunctionTarget( string a, string b, string c, string d, string e )
        {
            return Join( a, b, c, d, e );
        }

        private static string BindPartialFunctionTarget( string a, string b, string c, string d )
        {
            return Join( a, b, c, d );
        }

        private static string BindPartialFunctionTarget( string a, string b, string c )
        {
            return Join( a, b, c );
        }

        private static string BindPartialFunctionTarget( string a, string b )
        {
            return Join( a, b );
        }

        private const string testsSet = "abcdefghijklmnop";

        [TestMethod]
        public async Task BindPartial_Function( )
        {
            const string a = "a", b = "b", c = "c", d = "d", e = "e", 
                f = "f", g = "g",h="h",i="i",j="j",k="k",
                l="l",m="m",n="n",o="o",p="p";

            
            var partialBinder = new PartialComponent( );

            var expected =
                Enumerable.Range(2, testsSet.Length-1 )
                    .Select(
                        aa => string.Join(" ", Enumerable.Range(0, aa).Select(bb => testsSet[bb].ToString()).ToArray()))
                    .Reverse().ToArray();

            var target16 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string, string, string,
                        string, string, string, string, string>(BindPartialFunctionTarget);


            var target15 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string, string, string,
                        string, string, string, string>(BindPartialFunctionTarget);



            var target14 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string, string, string,
                        string, string, string>(BindPartialFunctionTarget);



            var target13 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string, string, string,
                        string, string>(BindPartialFunctionTarget);



            var target12 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string, string, string,
                        string>(BindPartialFunctionTarget);

            var target11 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string, string, string>(BindPartialFunctionTarget);

            var target10 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string, string>(BindPartialFunctionTarget);

            var target9 =
                new Func
                    <string, string, string, string, string, string, string, string, string, string>(BindPartialFunctionTarget);


            var target8 =
                new Func
                    <string, string, string, string, string, string, string, string, string>(BindPartialFunctionTarget);


            var target7 =
                new Func
                    <string, string, string, string, string, string, string, string>(BindPartialFunctionTarget);

            var target6 =
                new Func
                    <string, string, string, string, string, string, string>(BindPartialFunctionTarget);

            var target5 =
                new Func
                    <string, string, string, string, string, string>(BindPartialFunctionTarget);

            var target4 =
                new Func
                    <string, string, string, string, string>(BindPartialFunctionTarget);

            var target3 =
                new Func
                    <string, string, string, string>(BindPartialFunctionTarget);

            var target2 =
                new Func
                    <string, string, string>(BindPartialFunctionTarget);


            var bound = new
            {
                Partial16 = new
                {
                    Expected = expected[0],
                    Bound1 = partialBinder.Partial(target16, a),
                    Bound2 = partialBinder.Partial(target16, a, b),
                    Bound3 = partialBinder.Partial(target16, a, b, c),
                    Bound4 = partialBinder.Partial(target16, a, b, c, d),
                    Bound5 = partialBinder.Partial(target16, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target16, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target16, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h),
                    Bound9 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h, i),
                    Bound10 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h, i, j),
                    Bound11 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h, i, j, k),
                    Bound12 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h, i, j, k, l),
                    Bound13 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h, i, j, k, l, m),
                    Bound14 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h, i, j, k, l, m, n),
                    Bound15 = partialBinder.Partial(target16, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o),
                },


                Partial15 = new
                {
                    Expected = expected[1],
                    Bound1 = partialBinder.Partial(target15, a),
                    Bound2 = partialBinder.Partial(target15, a, b),
                    Bound3 = partialBinder.Partial(target15, a, b, c),
                    Bound4 = partialBinder.Partial(target15, a, b, c, d),
                    Bound5 = partialBinder.Partial(target15, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target15, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target15, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target15, a, b, c, d, e, f, g, h),
                    Bound9 = partialBinder.Partial(target15, a, b, c, d, e, f, g, h, i),
                    Bound10 = partialBinder.Partial(target15, a, b, c, d, e, f, g, h, i, j),
                    Bound11 = partialBinder.Partial(target15, a, b, c, d, e, f, g, h, i, j, k),
                    Bound12 = partialBinder.Partial(target15, a, b, c, d, e, f, g, h, i, j, k, l),
                    Bound13 = partialBinder.Partial(target15, a, b, c, d, e, f, g, h, i, j, k, l, m),
                    Bound14 = partialBinder.Partial(target15, a, b, c, d, e, f, g, h, i, j, k, l, m, n),
                },


                Partial14 = new
                {
                    Expected = expected[2],
                    Bound1 = partialBinder.Partial(target14, a),
                    Bound2 = partialBinder.Partial(target14, a, b),
                    Bound3 = partialBinder.Partial(target14, a, b, c),
                    Bound4 = partialBinder.Partial(target14, a, b, c, d),
                    Bound5 = partialBinder.Partial(target14, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target14, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target14, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target14, a, b, c, d, e, f, g, h),
                    Bound9 = partialBinder.Partial(target14, a, b, c, d, e, f, g, h, i),
                    Bound10 = partialBinder.Partial(target14, a, b, c, d, e, f, g, h, i, j),
                    Bound11 = partialBinder.Partial(target14, a, b, c, d, e, f, g, h, i, j, k),
                    Bound12 = partialBinder.Partial(target14, a, b, c, d, e, f, g, h, i, j, k, l),
                    Bound13 = partialBinder.Partial(target14, a, b, c, d, e, f, g, h, i, j, k, l, m),
                },


                Partial13 = new
                {
                    Expected = expected[3],
                    Bound1 = partialBinder.Partial(target13, a),
                    Bound2 = partialBinder.Partial(target13, a, b),
                    Bound3 = partialBinder.Partial(target13, a, b, c),
                    Bound4 = partialBinder.Partial(target13, a, b, c, d),
                    Bound5 = partialBinder.Partial(target13, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target13, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target13, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target13, a, b, c, d, e, f, g, h),
                    Bound9 = partialBinder.Partial(target13, a, b, c, d, e, f, g, h, i),
                    Bound10 = partialBinder.Partial(target13, a, b, c, d, e, f, g, h, i, j),
                    Bound11 = partialBinder.Partial(target13, a, b, c, d, e, f, g, h, i, j, k),
                    Bound12 = partialBinder.Partial(target13, a, b, c, d, e, f, g, h, i, j, k, l)
                },


                Partial12 = new
                {
                    Expected = expected[4],
                    Bound1 = partialBinder.Partial(target12, a),
                    Bound2 = partialBinder.Partial(target12, a, b),
                    Bound3 = partialBinder.Partial(target12, a, b, c),
                    Bound4 = partialBinder.Partial(target12, a, b, c, d),
                    Bound5 = partialBinder.Partial(target12, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target12, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target12, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target12, a, b, c, d, e, f, g, h),
                    Bound9 = partialBinder.Partial(target12, a, b, c, d, e, f, g, h, i),
                    Bound10 = partialBinder.Partial(target12, a, b, c, d, e, f, g, h, i, j),
                    Bound11 = partialBinder.Partial(target12, a, b, c, d, e, f, g, h, i, j, k),
                },


                Partial11 = new
                {
                    Expected = expected[5],
                    Bound1 = partialBinder.Partial(target11, a),
                    Bound2 = partialBinder.Partial(target11, a, b),
                    Bound3 = partialBinder.Partial(target11, a, b, c),
                    Bound4 = partialBinder.Partial(target11, a, b, c, d),
                    Bound5 = partialBinder.Partial(target11, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target11, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target11, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target11, a, b, c, d, e, f, g, h),
                    Bound9 = partialBinder.Partial(target11, a, b, c, d, e, f, g, h, i),
                    Bound10 = partialBinder.Partial(target11, a, b, c, d, e, f, g, h, i, j)
                },
                Partial10 = new
                {
                    Expected = expected[6],
                    Bound1 = partialBinder.Partial(target10, a),
                    Bound2 = partialBinder.Partial(target10, a, b),
                    Bound3 = partialBinder.Partial(target10, a, b, c),
                    Bound4 = partialBinder.Partial(target10, a, b, c, d),
                    Bound5 = partialBinder.Partial(target10, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target10, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target10, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target10, a, b, c, d, e, f, g, h),
                    Bound9 = partialBinder.Partial(target10, a, b, c, d, e, f, g, h, i)
                },
                Partial9 = new
                {
                    Expected = expected[7],
                    Bound1 = partialBinder.Partial(target9, a),
                    Bound2 = partialBinder.Partial(target9, a, b),
                    Bound3 = partialBinder.Partial(target9, a, b, c),
                    Bound4 = partialBinder.Partial(target9, a, b, c, d),
                    Bound5 = partialBinder.Partial(target9, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target9, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target9, a, b, c, d, e, f, g),
                    Bound8 = partialBinder.Partial(target9, a, b, c, d, e, f, g, h),
                },
                Partial8 = new
                {
                    Expected = expected[8],
                    Bound1 = partialBinder.Partial(target8, a),
                    Bound2 = partialBinder.Partial(target8, a, b),
                    Bound3 = partialBinder.Partial(target8, a, b, c),
                    Bound4 = partialBinder.Partial(target8, a, b, c, d),
                    Bound5 = partialBinder.Partial(target8, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target8, a, b, c, d, e, f),
                    Bound7 = partialBinder.Partial(target8, a, b, c, d, e, f, g)
                },
                Partial7 = new
                {
                    Expected = expected[9],
                    Bound1 = partialBinder.Partial(target7, a),
                    Bound2 = partialBinder.Partial(target7, a, b),
                    Bound3 = partialBinder.Partial(target7, a, b, c),
                    Bound4 = partialBinder.Partial(target7, a, b, c, d),
                    Bound5 = partialBinder.Partial(target7, a, b, c, d, e),
                    Bound6 = partialBinder.Partial(target7, a, b, c, d, e, f)
                },
                Partial6 = new
                {
                    Expected = expected[10],
                    Bound1 = partialBinder.Partial(target6, a),
                    Bound2 = partialBinder.Partial(target6, a, b),
                    Bound3 = partialBinder.Partial(target6, a, b, c),
                    Bound4 = partialBinder.Partial(target6, a, b, c, d),
                    Bound5 = partialBinder.Partial(target6, a, b, c, d, e)
                },
                Partial5 = new
                {
                    Expected = expected[11],
                    Bound1 = partialBinder.Partial(target5, a),
                    Bound2 = partialBinder.Partial(target5, a, b),
                    Bound3 = partialBinder.Partial(target5, a, b, c),
                    Bound4 = partialBinder.Partial(target5, a, b, c, d)
                },
                Partial4 = new
                {
                    Expected = expected[12],
                    Bound1 = partialBinder.Partial(target4, a),
                    Bound2 = partialBinder.Partial(target4, a, b),
                    Bound3 = partialBinder.Partial(target4, a, b, c),
                },
                Partial3 = new
                {
                    Expected = expected[13],
                    Bound1 = partialBinder.Partial(target3, a),
                    Bound2 = partialBinder.Partial(target3, a, b),
                },
                Partial2 = new
                {
                    Expected = expected[14],
                    Bound1 = partialBinder.Partial(target2, a),
                }
            };



            await Util.Tasks.Start(() =>
            {


                var target = bound.Partial16;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i, j, k, l, m, n, o, p),
                    target.Bound2(c, d, e, f, g, h, i, j, k, l, m, n, o, p),
                    target.Bound3(d, e, f, g, h, i, j, k, l, m, n,o,p),
                    target.Bound4( e, f, g, h, i, j, k, l, m, n,o,p),
                    target.Bound5(f, g, h, i, j, k, l, m, n,o,p),
                    target.Bound6(g, h, i, j, k, l, m, n,o,p),
                    target.Bound7( h, i, j, k, l, m, n,o,p),
                    target.Bound8(i, j, k, l, m, n,o,p),
                    target.Bound9( j, k, l, m, n,o,p),
                    target.Bound10( k, l, m, n,o,p),
                    target.Bound11( l, m, n, o, p),
                    target.Bound12(m, n, o, p),
                    target.Bound13(n, o, p),
                    target.Bound14(o, p),
                    target.Bound15(p),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial15;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i, j, k, l, m, n, o),
                    target.Bound2(c, d, e, f, g, h, i, j, k, l, m, n, o),
                    target.Bound3(d, e, f, g, h, i, j, k, l, m, n, o),
                    target.Bound4(e, f, g, h, i, j, k, l, m, n, o),
                    target.Bound5(f, g, h, i, j, k, l, m, n, o),
                    target.Bound6(g, h, i, j, k, l, m, n, o),
                    target.Bound7(h, i, j, k, l, m, n, o),
                    target.Bound8(i, j, k, l, m, n, o),
                    target.Bound9(j, k, l, m, n, o),
                    target.Bound10(k, l, m, n, o),
                    target.Bound11(l, m, n, o),
                    target.Bound12(m, n, o),
                    target.Bound13(n, o),
                    target.Bound14(o),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            }, 
            () =>
            {


                var target = bound.Partial14;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i, j, k, l, m, n),
                    target.Bound2( c, d, e, f, g, h, i, j, k, l, m,n),
                    target.Bound3(d, e, f, g, h, i, j, k, l, m,n),
                    target.Bound4(e, f, g, h, i, j, k, l, m,n),
                    target.Bound5(f, g, h, i, j, k, l, m,n),
                    target.Bound6(g, h, i, j, k, l, m,n),
                    target.Bound7(h, i, j, k, l, m,n),
                    target.Bound8(i, j, k, l, m,n),
                    target.Bound9(j, k, l, m,n),
                    target.Bound10(k, l, m,n),
                    target.Bound11(l, m,n),
                    target.Bound12(m,n),
                    target.Bound13(n),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial13;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i, j, k, l, m),
                    target.Bound2(c, d, e, f, g, h, i, j, k, l, m),
                    target.Bound3( d, e, f, g, h, i, j, k, l, m),
                    target.Bound4(e, f, g, h, i, j, k, l, m),
                    target.Bound5(f, g, h, i, j, k, l, m),
                    target.Bound6(g, h, i, j, k, l, m),
                    target.Bound7(h, i, j, k, l, m),
                    target.Bound8(i, j, k, l, m),
                    target.Bound9(j, k, l, m),
                    target.Bound10( k, l, m),
                    target.Bound11(l, m),
                    target.Bound12(m),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial12;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i, j, k, l),
                    target.Bound2( c, d, e, f, g, h, i, j, k, l),
                    target.Bound3(d, e, f, g, h, i, j, k, l),
                    target.Bound4(e, f, g, h, i, j, k, l),
                    target.Bound5(f, g, h, i, j, k, l),
                    target.Bound6( g, h, i, j, k, l),
                    target.Bound7( h, i, j, k, l),
                    target.Bound8(i, j, k, l),
                    target.Bound9(j, k, l),
                    target.Bound10(k, l),
                    target.Bound11(l),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial11;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i, j, k),
                    target.Bound2(c, d, e, f, g, h, i, j, k),
                    target.Bound3(d, e, f, g, h, i, j, k),
                    target.Bound4( e, f, g, h, i, j, k),
                    target.Bound5(f, g, h, i, j, k),
                    target.Bound6( g, h, i, j, k),
                    target.Bound7(h, i, j, k),
                    target.Bound8( i, j, k),
                    target.Bound9( j, k),
                    target.Bound10( k),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial10;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i, j),
                    target.Bound2(c, d, e, f, g, h, i, j),
                    target.Bound3( d, e, f, g, h, i, j),
                    target.Bound4( e, f, g, h, i, j),
                    target.Bound5(f, g, h, i, j),
                    target.Bound6( g, h, i, j),
                    target.Bound7( h, i, j),
                    target.Bound8( i, j),
                    target.Bound9(j),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial9;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h, i),
                    target.Bound2(c, d, e, f, g, h, i),
                    target.Bound3(d, e, f, g, h, i),
                    target.Bound4( e, f, g, h, i),
                    target.Bound5( f, g, h, i),
                    target.Bound6( g, h, i),
                    target.Bound7( h, i),
                    target.Bound8(i),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial8;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g, h),
                    target.Bound2( c, d, e, f, g, h),
                    target.Bound3( d, e, f, g, h),
                    target.Bound4(e, f, g, h),
                    target.Bound5(f, g, h),
                    target.Bound6(g, h),
                    target.Bound7(h),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial7;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f, g),
                    target.Bound2(c, d, e, f, g),
                    target.Bound3(d, e, f, g),
                    target.Bound4(e, f, g),
                    target.Bound5( f, g),
                    target.Bound6(g),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial6;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e, f),
                    target.Bound2( c, d, e, f),
                    target.Bound3(d, e, f),
                    target.Bound4(e, f),
                    target.Bound5( f),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial5;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d, e),
                    target.Bound2(c, d, e),
                    target.Bound3(d, e),
                    target.Bound4( e),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial4;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c, d),
                    target.Bound2(c, d),
                    target.Bound3(d),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial3;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b, c),
                    target.Bound2(c),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            },
            () =>
            {


                var target = bound.Partial2;
                var expecting = target.Expected;

                var results = new[]
                {
                    target.Bound1(b),
                };


                foreach (var r in results)
                    Assert.AreEqual(expecting, r);
            } );
        }
    }
}
