using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class Layer
    {
        public List<Neuron> Neurons { get; set; }

        public Layer()
        {
            Neurons = new List<Neuron>();
        }
    }
}
