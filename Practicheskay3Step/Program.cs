using System.ComponentModel.Design;

namespace BlaBla
{
    class Stepa
    {
        static void Main()
        {
            Console.WriteLine("Выберите октаву F1 и F2");
            Console.WriteLine("Клавиши - от q до ]");
            ConsoleKeyInfo Button = Console.ReadKey(true);
            if (Button.Key == ConsoleKey.F1 | Button.Key == ConsoleKey.F2)
            {
                ChangeOctave(Button);
            }
            else
            {
                Console.WriteLine("Вы не ввели первую октаву!");
                Main();
            }
        }

        static void ChangeOctave(ConsoleKeyInfo a)
        {
            if (a.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else if (a.Key == ConsoleKey.F1)
            {
                Console.WriteLine("1 Октава");
                Octave1();
            }
            else if (a.Key == ConsoleKey.F2)
            {
                Console.WriteLine("2 Октава");
                Octave2();
            }
        }
        static void Octave1()
        {
            int[] oct1 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            Sound(oct1);
        }
        static void Octave2()
        {
            int[] oct2 = new int[] { 1047, 1109, 1175, 1245, 1391, 1397, 1480, 1568, 1661, 1760, 1885, 1976 };
            Sound(oct2);
        }
        static void Sound(int[] a)
        {
            do
            {
                ConsoleKeyInfo b = Console.ReadKey(true);
                if (b.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                switch (b.KeyChar)
                {
                    case 'q':
                        Console.Beep(a[0], 650);
                        break;
                    case 'w':
                        Console.Beep(a[1], 650);
                        break;
                    case 'e':
                        Console.Beep(a[2], 650);
                        break;
                    case 'r':
                        Console.Beep(a[3], 650);
                        break;
                    case 't':
                        Console.Beep(a[4], 650);
                        break;
                    case 'y':
                        Console.Beep(a[5], 650);
                        break;
                    case 'u':
                        Console.Beep(a[6], 650);
                        break;
                    case 'i':
                        Console.Beep(a[7], 650);
                        break;
                    case 'o':
                        Console.Beep(a[8], 650);
                        break;
                    case 'p':
                        Console.Beep(a[9], 650);
                        break;
                    case '[':
                        Console.Beep(a[10], 650);
                        break;
                    case ']':
                        Console.Beep(a[11], 650);
                        break;
                    default:
                        ChangeOctave(b);
                        break;
                }
            } while (1 == 1);
        }
    }
}
