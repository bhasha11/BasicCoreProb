namespace BasicCoreProgram1
{
    internal class FlipCoinHeadOrTail
    {
       
       
            public void CheckHeadTail()
            {
                int constantdec=0, FlipHead=0, FlipTail=0;
                Console.WriteLine("How Many Times You Want To Flip Coin : ");
                int FlipNumber = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                for (int coinFlip = 1; coinFlip > 0; coinFlip++)
                {
                    double CheckFlipCoin = random.Next(0, 2);
                    if (CheckFlipCoin < constantdec)
                    {

                        //if Head
                        Console.WriteLine("Result: is Head ");
                        FlipHead++;
                    }

                    else
                    {

                        //if Tail
                        Console.WriteLine("Result: is Tail");
                        FlipTail++;
                    }
                }

                double CheckPercentageTails = FlipHead * 100 / FlipNumber;
                double CheckPercentageHeads = FlipTail * 100 / FlipNumber;
                Console.WriteLine("Percentage of TAILS and HEADS is : " + CheckPercentageTails + "" + CheckPercentageHeads);
                Console.ReadKey();

            }



        }
    }
