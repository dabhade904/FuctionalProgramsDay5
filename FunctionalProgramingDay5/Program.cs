namespace FuctionalProgramingDay5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    FunctionalPrograms.FlipCoin();
                    break;
                case 2:
                    FunctionalPrograms.HarmonicSeries();
                    break;
                case 3:
                    FunctionalPrograms.LeapYear();
                    break;
                case 4:
                    FunctionalPrograms.PowerOfTwo();
                    break;
                case 5:
                    FunctionalPrograms.PrimeFactor();
                    break;
                case 6:
                    FunctionalPrograms.SwapingTwoNumber();
                    break;
                case 7:
                    FunctionalPrograms.Remainder();
                    break;
                case 8:
                    FunctionalPrograms.EvenOdd();
                    break;
                case 9:
                    FunctionalPrograms.VowelAndConstant();
                    break;
                case 10:
                    FunctionalPrograms.ThreeLargestNumber();
                    break;
            }
        }
    }
}
