namespace AlgoritmProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice:\n1.Insertion sort\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Insertion insertion = new Insertion();
                    insertion.InsertionOrder();
                    break;
            }
        }


    }
}
