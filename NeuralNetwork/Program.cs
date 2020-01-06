using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace NeuralNetwork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var neuralNetwork = new NeuralNetwork();
            var Layer1 = new Layer();
            var Layer2 = new Layer();
            var Layer3 = new Layer();
            neuralNetwork.Layers.Add(Layer1);
            neuralNetwork.Layers.Add(Layer2);
            neuralNetwork.Layers.Add(Layer3);
            var data1 = new List<double> { 1, 0.01, 0.01 }; // each digit in the array is an input neuron, 0.0 - 1.0 value (0 is white, 1 is black) - 1,0,0 means first input neuron is 1, others 0
            var answer1 = new List<double> { 1, 0, 0 };
            var data2 = new List<double> { 0, 1, 0 };
            var answer2 = new List<double> { 0, 1, 0 };
            var data3 = new List<double> { 0, 0, 1 };
            var answer3 = new List<double> { 0, 0, 1 };
            var random = new Random();

            var input1 = new Neuron();
            input1.Value = 1.0;
            var input2 = new Neuron();
            input2.Value = 0.01;
            var input3 = new Neuron();
            input3.Value = 0.01;

            // input layer
            Layer1.Neurons.Add(input1);
            Layer1.Neurons.Add(input2);
            Layer1.Neurons.Add(input3);
            // we want the answer to be like .99, .0001, .0001 for the final three output neurons (for the first training example data set that is)

            // hidden layer
            var h1 = new Neuron();
            var h2 = new Neuron();
            var h3 = new Neuron();

            // output neurons
            var o1 = new Neuron();
            var o2 = new Neuron();
            var o3 = new Neuron();

            // input layer weights
            // number of weights per layer is (number of input neurons) * (number of hidden layer neurons)
            // in this case 3*3 = 9 weights for the first layer
            var w1 = new Weight(random.NextDouble());
            var w2 = new Weight(random.NextDouble());
            var w3 = new Weight(random.NextDouble());
            var w4 = new Weight(random.NextDouble());
            var w5 = new Weight(random.NextDouble());
            var w6 = new Weight(random.NextDouble());
            var w7 = new Weight(random.NextDouble());
            var w8 = new Weight(random.NextDouble());
            var w9 = new Weight(random.NextDouble());
            var w10 = new Weight(random.NextDouble());
            var w11 = new Weight(random.NextDouble());
            var w12 = new Weight(random.NextDouble());
            var w13 = new Weight(random.NextDouble());
            var w14 = new Weight(random.NextDouble());
            var w15 = new Weight(random.NextDouble());
            var w16 = new Weight(random.NextDouble());
            var w17 = new Weight(random.NextDouble());
            var w18 = new Weight(random.NextDouble());

            //in case we add another hidden layer, more weights
            var w19 = new Weight(random.NextDouble());
            var w20 = new Weight(random.NextDouble());
            var w21 = new Weight(random.NextDouble());
            var w22 = new Weight(random.NextDouble());
            var w23 = new Weight(random.NextDouble());
            var w24 = new Weight(random.NextDouble());
            var w25 = new Weight(random.NextDouble());
            var w26 = new Weight(random.NextDouble());
            var w27 = new Weight(random.NextDouble());

            input1.ConnectToOutputNeuron(h1, w1);
            input1.ConnectToOutputNeuron(h2, w2);
            input1.ConnectToOutputNeuron(h3, w3);
            input2.ConnectToOutputNeuron(h1, w4);
            input2.ConnectToOutputNeuron(h2, w5);
            input2.ConnectToOutputNeuron(h3, w6);
            input3.ConnectToOutputNeuron(h1, w7);
            input3.ConnectToOutputNeuron(h2, w8);
            input3.ConnectToOutputNeuron(h3, w9);

            h1.Value = ActivationFunction(input1.OutputSynapses[0].Weight.CurrentWeight * input1.Value + input2.OutputSynapses[0].Weight.CurrentWeight * input2.Value + input3.OutputSynapses[0].Weight.CurrentWeight * input3.Value);
            h2.Value = ActivationFunction(input1.OutputSynapses[1].Weight.CurrentWeight * input1.Value + input2.OutputSynapses[1].Weight.CurrentWeight * input2.Value + input3.OutputSynapses[1].Weight.CurrentWeight * input3.Value);
            h3.Value = ActivationFunction(input1.OutputSynapses[2].Weight.CurrentWeight * input1.Value + input2.OutputSynapses[2].Weight.CurrentWeight * input2.Value + input3.OutputSynapses[2].Weight.CurrentWeight * input3.Value);

            // hidden layer weights
            h1.ConnectToOutputNeuron(o1, w10);
            h1.ConnectToOutputNeuron(o2, w11);
            h1.ConnectToOutputNeuron(o3, w12);
            h2.ConnectToOutputNeuron(o1, w13);
            h2.ConnectToOutputNeuron(o2, w14);
            h2.ConnectToOutputNeuron(o3, w15);
            h3.ConnectToOutputNeuron(o1, w16);
            h3.ConnectToOutputNeuron(o2, w17);
            h3.ConnectToOutputNeuron(o3, w18);

            o1.Value = ActivationFunction(h1.OutputSynapses[0].Weight.CurrentWeight * h1.Value + h2.OutputSynapses[0].Weight.CurrentWeight * h2.Value + h3.OutputSynapses[0].Weight.CurrentWeight * h3.Value);
            o2.Value = ActivationFunction(h1.OutputSynapses[1].Weight.CurrentWeight * h1.Value + h2.OutputSynapses[1].Weight.CurrentWeight * h2.Value + h3.OutputSynapses[1].Weight.CurrentWeight * h3.Value);
            o3.Value = ActivationFunction(h1.OutputSynapses[2].Weight.CurrentWeight * h1.Value + h2.OutputSynapses[2].Weight.CurrentWeight * h2.Value + h3.OutputSynapses[2].Weight.CurrentWeight * h3.Value);
        }

        public static double ActivationFunction(double net)
        {
            return 1 / (1 + Math.Exp(-1 * net));
        }
    }
}
