using System;

namespace OSProjects4and5
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Philosopher philosopher = new Philosopher();
            philosopher.run();
            Page page = new Page();
            page.run();
        }
    }

    public class Philosopher
    {
        private string[] stateArray = new string[5];
        private string thinking = "thinking";
        private string eating = "eating";
        private int count = 0;

        public void run()
        {
            while (count < 500)
            {
                for (int i = 0; i < stateArray.Length; i++)
                {
                    Random random = new Random();
                    int rng = random.Next(2);
                    if (rng == 0)
                    {
                        stateArray[i] = thinking;
                        Console.WriteLine("Philosopher " + i + " is " + stateArray[i] + ".");
                    }
                    else
                    {
                        if (stateArray[(i + 1) % 5] != eating && stateArray[(i + 4) % 5] != eating)
                        {
                            stateArray[i] = eating;
                            Console.WriteLine("Philosopher " + i + " is " + stateArray[i] + ".");
                            count++;
                            Console.WriteLine("The philosophers have eaten " + count + " time(s).");
                            if (count == 500)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }

    public class Page
    {
        private int[] pt1 = new int[5];
        private int[] pt2 = new int[5];
        private int[] address = { 0, 1, 1, 0, 0, 1, 1, 1 };
        private double pageNum = 0;
        private double offset = 0;

        public void run()
        {
            Console.WriteLine("\n\npt1");
            int memoryFrames1 = 5;
            pt1[0] = memoryFrames1;
            int numProcesses1 = 5;
            pt1[1] = numProcesses1;
            int numPages1 = 10;
            Console.WriteLine("\nnumber of pages/ process = " + numPages1 / numProcesses1);
            pt1[2] = numPages1;
            int pID1 = 1;
            Console.WriteLine("\npID1 of every process = " + pID1);
            pt1[3] = pID1;
            int processFrames1 = 10;
            pt1[4] = processFrames1;
            Console.WriteLine("[" + string.Join(", ", pt1) + "]");
            while (numProcesses1 > 0 && processFrames1 > 0)
            {
                processFrames1--;
                pt1[4] = processFrames1;
                memoryFrames1++;
                pt1[0] = memoryFrames1;
                numProcesses1--;
                pt1[1] = numProcesses1;
                pt1[2] = numProcesses1 * 2;
                Console.WriteLine("[" + string.Join(", ", pt1) + "]");
                if (processFrames1 == 0)
                {
                    Console.WriteLine("\nProcess " + numProcesses1 + " doesn't have a frame.");
                }
            }

            Console.WriteLine("___________________________________");
            Console.WriteLine("pt2");
            int memoryFrames2 = 5;
            pt2[0] = memoryFrames2;
            int numProcesses2 = 5;
            pt2[1] = numProcesses2;
            int numPages2 = 5;
            Console.WriteLine("\nnumber of pages/ process = " + numPages2 / numProcesses2);
            pt2[2] = numPages2;
            int pID2 = 1;
            Console.WriteLine("\npID2 of every process = " + pID2);
            pt2[3] = pID2;
            int processFrames2 = 3;
            pt2[4] = processFrames2;
            Console.WriteLine("[" + string.Join(", ", pt2) + "]");
            while (numProcesses2 > 0 && processFrames2 > 0)
            {
                processFrames2--;
                pt2[4] = processFrames2;
                memoryFrames2++;
                pt2[0] = memoryFrames2;
                numProcesses2--;
                pt2[1] = numProcesses2;
                pt2[2] = numProcesses2;
                Console.WriteLine("[" + string.Join(", ", pt2) + "]");
                if (processFrames2 == 0)
                {
                    Console.WriteLine("\nProcess " + numProcesses2 + " doesn't have a frame.");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                pageNum += address[i] * Math.Pow(2, i);
                offset += address[address.Length - i - 1] * Math.Pow(2, i);
            }

            Console.WriteLine("___________________________________");
            Console.WriteLine("\npageNum = " + pageNum);
            Console.WriteLine("\noffset = " + offset);
        }
    }
}