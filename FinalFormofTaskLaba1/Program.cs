using System;
using System.Collections.Generic;
using firsttask;
using secondtask;
using thirdtask;

void main()
{
    third1task third1Task1 = new third1task();
    secondtask1 secondtask11 = new secondtask1();
    firsttask1 firsttask11 = new firsttask1();
    bool cycle = true;
    int optionchoose;
    string optionchoose1;
    while (cycle == true)
    {
        Console.WriteLine("Variant 23, Uteshev Gleb IDB-21-02\n1. First task\n2. Second task\n3. Third Task\n4. Close Program\n");
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
                firsttask11.main();
                break;
            case 2:
                secondtask11.main();
                break;
            case 3:
                third1Task1.main();
                break;
            case 4:
                cycle = false;
                break;
            default:
                Console.WriteLine("There is no such option");
                break;
        }
    }
}
main();
