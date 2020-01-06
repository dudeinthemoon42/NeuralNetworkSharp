using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class Synapse
    {
        public Weight Weight { get; set; }

        public Neuron StartNeuron { get; set; }
        public Neuron EndNeuron { get; set; }

        public Synapse(Neuron startNeuron, Neuron endNeuron, Weight weight)
        {
            this.StartNeuron = startNeuron;
            this.EndNeuron = endNeuron;
            this.Weight = weight;
        }
    }
}
