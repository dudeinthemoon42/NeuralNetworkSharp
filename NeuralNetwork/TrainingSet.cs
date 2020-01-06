using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class TrainingSet
    {
        public List<double> Input { get; set; }

        public List<double> Answer { get; set; }

        public TrainingSet(List<double> input, List<double> answer)
        {
            Input = input;
            Answer = answer;
        }
    }
}
