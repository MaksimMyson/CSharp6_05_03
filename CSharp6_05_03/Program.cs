namespace CSharp6_05_03
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements;
        }

        public void Show()
        {
            Console.WriteLine("Elements of the array:");
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"Elements of the array: {info}");
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = { 1, 2, 3, 4, 5 };

            Array array = new Array(arrayElements);

            
            array.Show();

          
            array.Show("Array elements");

            Console.ReadLine(); 
        }
    }
}