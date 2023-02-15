using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ABOBA
{
    public class Boks
    {
        public string baza;
        public DateTime[] vidacha;
        public DateTime[] sdacha;

    }
    class HelloWorld //фио=0 , названия произв=1 , идент номер=2, год издания=3, издательство=4 , жанр=5
    {
        static void Main()
        {
            int bup = 0;
            List<Boks> biblia = new List<Boks>();
            int count = 0;
            while (true)
            {
                Console.SetCursorPosition(0, 0);

                Console.WriteLine("Ввести новые данные");
                Console.WriteLine("Выборка");
                Console.SetCursorPosition(40, bup);
                ConsoleKeyInfo key = Console.ReadKey();


                if (key.Key == ConsoleKey.Enter && bup == 0)
                {
                    while (true)
                    {

                        Console.Clear();
                        Console.WriteLine("Введите фамилию, название произведения, идентификационный номер, год издания, издательство, жанр:");
                        string da = Console.ReadLine();
                        Console.WriteLine("Введите даты выдачи:");
                        string net = Console.ReadLine();
                        Console.WriteLine("Введите даты сдачи:");
                        string ok = Console.ReadLine();

                        Boks q = new Boks();
                        q.baza = da;
                        q.sdacha = ok.Split(' ').Select(x => Convert.ToDateTime(x)).ToArray();
                        q.vidacha = net.Split(' ').Select(x => Convert.ToDateTime(x)).ToArray();
                        biblia.Add(q);

                        Console.WriteLine("Для возврата в главное меню нажмите Enter");
                        Console.WriteLine("Для ввода новых данный нажмите шо хотите, тока не ентр пж");
                        ConsoleKeyInfo key11 = Console.ReadKey();
                        Console.Clear();
                        if (key11.Key == ConsoleKey.Enter)
                            break;

                    }
                }
                if (key.Key == ConsoleKey.Enter && bup == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Фамилия автора");
                    Console.WriteLine("Выданы на данном интервале");
                    Console.WriteLine("Жанр");
                    Console.WriteLine("На руках");
                    Console.WriteLine("Издательство");

                    while (true)
                    {
                        Console.SetCursorPosition(40, count);

                        ConsoleKeyInfo key1 = Console.ReadKey();

                        if (key1.Key == ConsoleKey.Enter && count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите фамилию автора");
                            string familia = Console.ReadLine();
                            Console.Clear();

                            foreach (Boks vibor in biblia)
                            {
                                string[] avtor = vibor.baza.Split(' ');
                                if (familia == avtor[0])
                                    Console.WriteLine(vibor.baza);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для возврата в главное меню нажмите Enter");
                            while (true)
                            {
                                ConsoleKeyInfo key2 = Console.ReadKey();
                                if (key2.Key == ConsoleKey.Enter)
                                    break;
                            }
                            Console.Clear();
                            break;
                        }

                        if (key1.Key == ConsoleKey.Enter && count == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите интервал");
                            string interval = Console.ReadLine();
                            string[] strings = interval.Split(' ');
                            DateTime nachalo = Convert.ToDateTime(strings[0]);
                            DateTime konec = Convert.ToDateTime(strings[1]);
                            Console.Clear();

                            foreach (Boks vibor in biblia)
                            {
                                DateTime[] dal = vibor.vidacha;

                                int z = 0;
                                while (z < dal.Length)
                                {
                                    if (Convert.ToDateTime(nachalo) <= Convert.ToDateTime(dal[z]) && Convert.ToDateTime(konec) >= Convert.ToDateTime(dal[z]))
                                        Console.WriteLine(vibor.baza);
                                    z++;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для возврата в главное меню нажмите Enter");
                            while (true)
                            {
                                ConsoleKeyInfo key2 = Console.ReadKey();
                                if (key2.Key == ConsoleKey.Enter)
                                    break;
                            }

                            Console.Clear();
                            break;
                        }

                        if (key1.Key == ConsoleKey.Enter && count == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите жанр");
                            string zanr = Console.ReadLine();
                            Console.Clear();

                            foreach (Boks vibor in biblia)
                            {
                                string[] plot = vibor.baza.Split(' ');
                                if (zanr == plot[5])
                                    Console.WriteLine(vibor.baza);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для возврата в главное меню нажмите Enter");
                            while (true)
                            {
                                ConsoleKeyInfo key2 = Console.ReadKey();
                                if (key2.Key == ConsoleKey.Enter)
                                    break;
                            }
                            Console.Clear();
                            break;
                        }

                        if (key1.Key == ConsoleKey.Enter && count == 3)
                        {
                            Console.Clear();

                            foreach (Boks vibor in biblia)
                            {
                                DateTime[] dal = vibor.vidacha;
                                DateTime[] vernul = vibor.sdacha;
                                if (dal.Length != vernul.Length)
                                    Console.WriteLine(vibor.baza);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для возврата в главное меню нажмите Enter");
                            while (true)
                            {
                                ConsoleKeyInfo key2 = Console.ReadKey();
                                if (key2.Key == ConsoleKey.Enter)
                                    break;
                            }

                            Console.Clear();
                            break;
                        }
                        if (key1.Key == ConsoleKey.Enter && count == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите издание");
                            string izdanie = Console.ReadLine();
                            Console.Clear();

                            foreach (Boks vibor in biblia)
                            {
                                string[] plot = vibor.baza.Split(' ');
                                if (izdanie == plot[4])
                                    Console.WriteLine(vibor.baza);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для возврата в главное меню нажмите Enter");
                            while (true)
                            {
                                ConsoleKeyInfo key2 = Console.ReadKey();
                                if (key2.Key == ConsoleKey.Enter)
                                    break;
                            }
                            Console.Clear();
                            break;
                        }

                        if ((key1.Key == ConsoleKey.UpArrow && count == 0) || (key1.Key == ConsoleKey.DownArrow && count == 3))
                        {
                            count = 4;
                            continue;
                        }

                        if ((key1.Key == ConsoleKey.UpArrow && count == 1) || (key1.Key == ConsoleKey.DownArrow && count == 4))
                        {
                            count = 0;
                            continue;
                        }

                        if ((key1.Key == ConsoleKey.UpArrow && count == 2) || (key1.Key == ConsoleKey.DownArrow && count == 0))
                        {
                            count = 1;
                            continue;
                        }

                        if ((key1.Key == ConsoleKey.UpArrow && count == 3) || (key1.Key == ConsoleKey.DownArrow && count == 1))
                        {
                            count = 2;
                            continue;
                        }
                        if ((key1.Key == ConsoleKey.UpArrow && count == 4) || (key1.Key == ConsoleKey.DownArrow && count == 2))
                        {
                            count = 3;
                            continue;
                        }
                    }
                }
                if (biblia.Count != 0)
                {
                    bup++;
                }
                if (bup == 2)
                    bup = 0;
            }

        }
    }
}