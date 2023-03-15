using System;
using System.Collections.Generic;
namespace thirdtask
{
    class third1task
    {
        public void main()
        {
            List<ManLenght> people = new List<ManLenght>();
            people.Add(new ManLenght("Uteshev", 183));
            people.Add(new ManLenght("Zhizhechkin", 187));
            people.Add(new ManLenght("Isparov", 189));
            int optionchoose;
            string optionchoose1;
            string EnterTheLastName;
            string EnterTheLenght;
            int ActualLenght;
            bool cycle = true;
            while (cycle == true)
            {
                Console.WriteLine("1. Show List\n2. Add new member\n3. Delete member\n4. Show people with length more than avarage\n5. Close task\n");
                optionchoose1 = Console.ReadLine();
                while (!(int.TryParse(optionchoose1, out _)))
                {
                    Console.WriteLine($"Not a number, try again enter an option:\n");
                    optionchoose1 = Console.ReadLine();
                }
                Console.WriteLine();
                optionchoose = int.Parse(optionchoose1);
                switch (optionchoose)
                {
                    case 1:
                        for (int i = 0; i < people.Count; i++)
                        {
                            Console.WriteLine($"{people[i].Lastnam} {people[i].Lena}");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine($"Enter the Lastname:");
                        EnterTheLastName = Console.ReadLine();
                        bool flag = true;
                        foreach (var symbol in EnterTheLastName)
                            if (!char.IsDigit(symbol))
                            {
                                flag = false;
                                break;
                            }
                        while (flag)
                        {
                            Console.WriteLine($"Lastname can`t include digits, try enter it again:\n");
                            EnterTheLastName = Console.ReadLine();
                            flag = true;
                            foreach (var symbol in EnterTheLastName)
                                if (!char.IsDigit(symbol))
                                {
                                    flag = false;
                                    break;
                                }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Enter the Lenght:");
                        EnterTheLenght = Console.ReadLine();
                        while (!(int.TryParse(EnterTheLenght, out _)))
                        {
                            Console.WriteLine($"Not a number, try again enter a lenght:\n");
                            EnterTheLenght = Console.ReadLine();
                        }
                        Console.WriteLine();
                        ActualLenght = int.Parse(EnterTheLenght);
                        people.Add(new ManLenght(EnterTheLastName, ActualLenght));
                        break;
                    case 3:
                        Console.WriteLine($"Write a number of member of List, who you want to be deleted:\n");
                        optionchoose1 = Console.ReadLine();
                        while (!(int.TryParse(optionchoose1, out _)))
                        {
                            Console.WriteLine($"Not a number, try again enter an option:\n");
                            optionchoose1 = Console.ReadLine();
                        }
                        Console.WriteLine();
                        optionchoose = int.Parse(optionchoose1);
                        optionchoose--;
                        if (optionchoose >= people.Count)
                        {
                            Console.WriteLine($"There is no such member:\n");
                            break;
                        }
                        people.RemoveAt(optionchoose);
                        break;
                    case 4:
                        int SumOfLenght = 0;
                        for (int i = 0; i < people.Count; i++)
                        {
                            SumOfLenght += people[i].Lena;
                        }
                        SumOfLenght = SumOfLenght / people.Count;
                        for (int i = 0; i < people.Count; i++)
                        {
                            if (people[i].Lena > SumOfLenght)
                            {
                                Console.WriteLine($"{people[i].Lastnam} {people[i].Lena}");
                            }
                        }
                        break;
                    case 5:
                        cycle = false;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }
            }
        }

        public struct ManLenght
        {
            private string _lastname;
            private int _lenght;

            public ManLenght(string tr, int intu3)
            {
                _lastname = tr;
                _lenght = intu3;
            }

            public string Lastnam
            {
                get { return _lastname; }
                set
                {
                    _lastname = value;
                }
            }

            public int Lena
            {
                get { return _lenght; }
                set
                {
                    _lenght = value;
                }
            }
        }
    }
}
