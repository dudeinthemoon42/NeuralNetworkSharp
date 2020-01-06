using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class NeuralNetwork
    {
        public List<Layer> Layers { get; set; }

        public NeuralNetwork()
        {
            Layers = new List<Layer>();
        }
    }
}
