namespace AlgoritmProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice:\n1.Insertion Sort\n2.Bubble Sort\n3.Binary search\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            switch (choice)
            {
                case 1:
                    Insertion insertion = new Insertion();
                    insertion.InsertionOrder();
                    break;
                case 2:
                    BubbleSort sort = new BubbleSort();
                    sort.Bubble();
                    break;
                case 3:
                    const string FILE_PATH = @"D:\RFP-208\AlgoritmProblem\AlgoritmProblem\New.txt";
                    BinarySearch search = new BinarySearch();
                    search.Search(FILE_PATH);
                    break;
                default:
                    break;
            }
        }


    }
}