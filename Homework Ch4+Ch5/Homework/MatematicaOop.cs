using System;

namespace Homework
{
    /// <summary>
    /// Ce ar afisa metoda AfiseazaRezultate de mai jos? Testeaza intr-o aplicatie consola.
    /// </summary>
    interface IFunc { int GetValue(int x); }
    class IdentityFunc : IFunc
    {
        public virtual int GetValue(int x) { return x; }
    }
    class DoubleFunc : IdentityFunc
    {
        public override int GetValue(int x) { return 2 * x; }
    }
    class TripleFunc : DoubleFunc
    {
        public new virtual int GetValue(int x) { return 3 * x; }
    }
    class QuadFunc : TripleFunc
    {
        public override int GetValue(int x) { return 4 * x; }
    }
    public static class OopMath
    {
        static void AfiseazaRezultate()
        {
            var triple = new TripleFunc();
            var quad = new QuadFunc();
            Console.WriteLine(((IdentityFunc)triple).GetValue(3));
            Console.WriteLine(((IdentityFunc)quad).GetValue(3));
            Console.WriteLine(((DoubleFunc)triple).GetValue(3));
            Console.WriteLine(((DoubleFunc)quad).GetValue(3));
            Console.WriteLine((triple).GetValue(3));
            Console.WriteLine(((TripleFunc)quad).GetValue(3));
            Console.WriteLine(((IFunc)triple).GetValue(3));
            Console.WriteLine(((IFunc)quad).GetValue(3));
        }
    }
}
