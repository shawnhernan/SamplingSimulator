using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace SamplingSimulator
{

    class Population
    {
        private Dictionary<uint, bool> thePopulation = new Dictionary<uint, bool>();
        private Random rnd = new Random();
        private double roll;
        public uint trues {get;}
        public  uint falses { get; }

        public Population(uint size, double probability)
        {
            trues = 0;
            falses = 0; 
            for (uint i = 0; i < size; i++)
            {
                roll = rnd.NextDouble(); 
                if (roll < probability)
                {
                    thePopulation.Add(i, true);
                    trues++; 
                }
                else
                {
                    thePopulation.Add(i, false);
                    falses++; 
                }
            }
        }

        public void Print()
        {
            foreach (KeyValuePair<uint, bool> kvp in thePopulation)
            {
                Console.WriteLine("Entry: {0}, value: {1}", kvp.Key, kvp.Value); 
            }
        }
    }
}
