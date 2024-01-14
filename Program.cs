namespace FirstCalculator_;

class Program
{
    static void Main(string[] args)
    {
        Calculator main = new Calculator();
        Console.WriteLine("Please enter first number: ");
        float[] array = new float[2];
        array[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        array[1] = Convert.ToInt32(Console.ReadLine());

        bool flag = false;
        bool flag2 = true;
        do
        {
            Console.WriteLine("Please enter a operator: ");
            char keySwitch = Console.ReadLine()[0];
            switch (keySwitch)
            {
                case '+':
                    Console.WriteLine(main.Sum(array[0], array[1]));
                    
                    break;
                case '-':
                    Console.WriteLine(main.Substract(array[0], array[1]));
                    flag = false;
                    break;
                case '/':
                    Console.WriteLine(main.Divide(array[0], array[1]));
                    flag = false;
                    break;
                case '*':
                    Console.WriteLine(main.Multiplication(array[0], array[1]));
                    flag = false;
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    flag = true;
                    break;
            }

            if (flag == false)
            {
                char secondKey;
                do
                {
                    Console.WriteLine("Do you want to play again?[Y]/[N] : ");
                    secondKey = Console.ReadLine()[0];
                } while (secondKey != 'Y' && secondKey != 'y'&& secondKey!= 'N'&& secondKey!='n');

                if (secondKey == 'y' || secondKey == 'Y')
                {
                    flag2 = true;
                    flag = true;
                }
                    
                else
                {
                    flag2 = false;
                }
            }
        } while (flag && flag2);

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}