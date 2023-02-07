
namespace TaskArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Hello", "my", "int", "log", "Int32", "var", "str"};

            string[] myArray2 = new string[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Length <= 3)
                {
                    myArray2[i] = myArray[i];
                }
                continue;
            }

            Array.Sort(myArray2);

            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.Write(myArray2[i] + " ");
            }
        }
    }
}