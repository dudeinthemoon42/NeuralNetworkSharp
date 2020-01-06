using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NeuralNetwork
{
    public class Neuron
    {
        public double Value { get; set; }

        public double Error { get; set; }

        // Synapse is just a neuron-to-neuron connection (which has a weight)
        public List<Synapse> InputSynapses { get; set; }
        public List<Synapse> OutputSynapses { get; set; }


        public Neuron()
        {
            this.InputSynapses = new List<Synapse>();
            this.OutputSynapses = new List<Synapse>();
        }

        public void ConnectToInputNeuron(Neuron inputNeuron, Weight weight)
        {
            var synapse = new Synapse(inputNeuron, this, weight);
            this.InputSynapses.Add(synapse);
        }

        public void ConnectToOutputNeuron(Neuron outputNeuron, Weight weight)
        {
            var synapse = new Synapse(this, outputNeuron, weight);
            this.OutputSynapses.Add(synapse);
        }

        /// <summary>
        /// Get all input synapses for this neuron
        /// </summary>
        /// <returns></returns>
        public List<Synapse> GetInputSynapses()
        {
            if (!InputSynapses.Any())
            {
                return new List<Synapse>();
            }

            return InputSynapses.Take(InputSynapses.Count - 1).ToList();
        }
    }
}
