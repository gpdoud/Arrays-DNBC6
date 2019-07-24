using System;

namespace ArraysProject {

    class Program {

        static void Main(string[] args) {

            int[] frames = new int[10];

            frames[0] = 17;
            frames[1] = 27;
            frames[2] = 15;
            frames[3] = 30;
            frames[4] = 19;
            frames[5] = 28;
            frames[6] = 12;
            frames[7] = 28;
            frames[8] = 26;
            frames[9] = 30;

            int total = 0;
            int index = 0;
            while(index < 10) {
                total = total + frames[index];
                index = index + 1;
            }
            Console.WriteLine($"Total is {total}");
        }
    }
}
