namespace AlgoritmProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your choice:\n1.Insertion Sort\n2.Bubble Sort\n3.Anagram\n4.PrimeNoInRange\n");
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
                    Anagramcs anagram = new Anagramcs();
                    anagram.CheckAnagram();
                    break;
                case 4:
                    PrimeNoRange check = new PrimeNoRange();
                    check.CheckPrime();
                    break;
                    default:
                    break;
            }
        }


    }
}