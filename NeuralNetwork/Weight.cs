using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class Weight
    {
        public double CurrentWeight { get; set; }
        public double PreviousWeight { get; set; }

        public Weight(double weight)
        {
            CurrentWeight = weight;
        }
    }
}
