namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddOne foo = new AddOne();
            foo.x = 2;

            AddOne bar = new AddOne();
            bar.x = 3;

            // And 2 + 3 now is 6
            Console.WriteLine((foo + bar).x.ToString());
            Console.Read();

        }
    }

    public class AddOne
    {
        public int x;

        public static AddOne operator +(AddOne a, AddOne b)
        {
            AddOne addone = new AddOne();

            addone.x = a.x + b.x + 1;

            return addone;
        }
    }
}