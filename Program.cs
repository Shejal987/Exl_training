namespace ConsoleApp1_1_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new string[] { "flower", "house", "tree" };

            /*var result= from element in words select element;
            Console.WriteLine(result);

            foreach (var item in words) {
                Console.WriteLine(item);
            }*/

            /*var result= from element in words where element.Contains("r") select element;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            var result = words.Where(ele => ele.Contains("r"));
            foreach ( var item in result )
            {
                Console.WriteLine(item);
            }
        }
    }
}