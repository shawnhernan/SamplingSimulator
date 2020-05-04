using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SamplingSimulator
{
    public struct Sample

    {
        public static uint Sampler(in Population thePopulation, uint frequency)
        {
            uint count = 0; 
            for (uint i = 0; i < thePopulation.count; i += frequency)

            {
                if (thePopulation.GetVal(i)) count++; 
            }
            return count; 

        }

    }
}
