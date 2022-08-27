namespace Activity11
{
    public class Program
    {

        public static void Main(string[] args)


        {
            //difine the variables the Variables
            int diceRoll;
            int diceRoll1;
            int diceRoll2;
            int numOfRolls = 0;

            //message to display a number between 4 to 20
            Console.WriteLine("Enter a number between 4 and 20: ");
            diceRoll = int.Parse(Console.ReadLine());

            //try/ catch methods to catch an exception
            try
            {

                // is stament to check if the number is between 4 and 20
                if (diceRoll < 4 || diceRoll > 20)
                {
                    //Eception to show if the user if the user enter a number out fof the range
                    throw new ArgumentException("Your input is more than the range, Please enter a number between 4 to 20.");

                }

                //to define and set the dice role to dice 1 and dice 2
                RollDice d1 = new RollDice(6);
                RollDice d2 = new RollDice(6);


                //a while loop to do the dice roll untill it is a 1 and 1
                do
                {

                    diceRoll1 = d1.rollDie();
                    diceRoll2 = d2.rollDie();

                    Console.WriteLine("Rolled [Dice 1: " + diceRoll1 + ", Dice 2: " + diceRoll2 + "]");

                    ++numOfRolls;

                } while (diceRoll1 != 1 || diceRoll2 != 1);


                //Message to show how lomg it took for the snake eye
                Console.WriteLine("\nIt took " + numOfRolls + " rolls to get snake eyes!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}