using BasicCoreProblem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Enter your choice between 1 to 10: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");
            Console.WriteLine("4 For: Select the Harmonic Number");
            Console.WriteLine("5 For: Select the Prime Factorization");
            Console.WriteLine("6 For: Select the Quantent Remainder");
            Console.WriteLine("7 For: Select the Swap 2 Number");
            Console.WriteLine("8 For: Select the Even Or Odd");
            Console.WriteLine("9 For: Select the Vowel Or Not");
            Console.WriteLine("10 For Select the Check Greater Or Smallest");
            int selection = Convert.ToInt32(Console.ReadLine());

            // user selection

            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    FlipCoinHeadOrTail flip = new FlipCoinHeadOrTail();
                    flip.CheckHeadTail();
                    break;
                case 2:
                    //CheckLeapYearOrNot
                    CheckLeapYearOrNot LeapYearOrNot = new CheckLeapYearOrNot();
                    LeapYearOrNot.LeapYear();
                    break;
                case 3:
                    //Power Of 2
                    CalculatePowerOf2 CalPower = new CalculatePowerOf2();
                    CalPower.CalculatePowerof2();
                    break;
                case 4:
                    //Harmonic Series
                    CalHarmonicSeries calculateHarmonicNumber = new CalHarmonicSeries();
                    calculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                case 5:
                    //Prime factor
                    PrimeFactorization primeFactorization = new PrimeFactorization();
                    primeFactorization.CalcSFactorialSeries();
                    break;
                case 6:
                    QuotentRemainder quotentRemainder = new QuotentRemainder();
                    quotentRemainder.QuotientRemainder();
                    break;
                case 7:
                    Swap2Number swap = new Swap2Number();
                    swap.SwapTwoNumber();
                    break;
                case 8:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.CheckEvenOrdd();
                    break;
                case 9:
                    VowelOrNot vowelOrNot = new VowelOrNot();
                    vowelOrNot.CheckGivenVowel();
                    break;
                case 10:
                    CheckGreaterOrSmallest checkGreaterOrSmallest = new CheckGreaterOrSmallest();
                    checkGreaterOrSmallest.GreaterOrSmaller();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select inBetween 1 to 2");
                    break;
            }
            
        }
    }
    }

           
        

       

    
    

        
    
    
   