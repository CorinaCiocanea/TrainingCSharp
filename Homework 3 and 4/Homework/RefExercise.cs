namespace Homework
{
    /// <summary>
    /// Exercise: Cu ce parametri putem chema metoda astfel incat aceasta sa printeze 'true'?
    /// </summary>
    public class RefExercise
    {
        public static void TestRef(ref int x, ref int y)
        {
            x = 42;
            y = 75;
            System.Console.WriteLine(x == y);
        }
    }
}
