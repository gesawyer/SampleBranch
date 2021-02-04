using System;

namespace MethodPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 2;
        

            Console.WriteLine("Hello there fellow kids.");

            int[] nums = new int [3];
            // 0   1  2    three spots in array but start at zero
            //[]  []  []
            // must give each item a value
            nums[0] = 29;
            nums[1] = 55;
            nums[2] = 49;
            //MEMORIZE
            for(int i=0; i< nums.Length; i++)
            {
                int n = nums[i];
                Console.WriteLine($"index {i}: {n}");
            }

            //If i know the values I want in my array ahead of time, I can put them in at creation
            string[] names = {"Tommy", "Grace", "Braeden", "hi","Freddy", "amy" };

            //This is how we pull out a name:
            string name = names[2];
            //Console.WriteLine(name);
            // string n is basically a variable just for that loop only usable in foreach loop
            //for each run, n gets updated with the next item in the array

            //the advantage of the foreach loop is that you don't need to use indeces and therefore
            //avoid any index related errors and exceptions

            //the downside is that figuring out where you are in a foreach loop is tricky
            int index = 0;
            foreach(string n in names)
            {
                Console.WriteLine($"value at {index}:{n}");
                index++;
            }







        }
    }
}
