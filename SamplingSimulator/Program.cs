using System;

// this is a tool to simulate sampling from a set of binary choices. 
// 

namespace SamplingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Population thePopulation = new Population(5000, 0.5);
            //thePopulation.Print();
            Console.WriteLine("total true: {0}, total false: {1}", thePopulation.trues, thePopulation.falses); 
        }
    }
}
