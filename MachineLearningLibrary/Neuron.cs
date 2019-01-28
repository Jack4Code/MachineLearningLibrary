using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningLibrary
{
    public class Neuron
    {
        public double[] inputs { get; set; }
        public double[] weights { get; set; }
        public double[] output { get; set; }

        public double bias { get; set; }

        public Neuron(int inputCount)
        {
            inputs = new double[inputCount];
            weights = new double[inputCount];
            output = new double[1]; //hard code to 1 for now. Think this should be a single double
            output[0] = 0;
            bias = 0;
            InitializeRandomWeights(inputCount);
        }

        public void InitializeRandomWeights(int weightCount)
        {
            Random random = new Random();
            for(int i=0; i<weightCount; i++)
            {
                double randomWeight = random.NextDouble();
                weights[i] = randomWeight;
            }
        }

        public void DotProduct() 
        {
            double sum = 0; 
            for(int i=0; i<inputs.Count(); i++)
            {
                var whatisit = inputs[i];
                sum += inputs[i] * weights[i];
            }
            sum += bias;
            output[0] = sum;
        }

        public double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        ///////////
        //Let's simplify here and try everything with just this class. then we will generalize and expand outwards in OOP design
        //take output and compare with target
        // (target - output(yhat))^2

        public void UpdateWeights()
        {
            DotProduct();
            //output[0] = Sigmoid(output[0]);
            for(int i=0; i<2; i++)
            {
                //weights[i] = weights[i] + (0.01 * output[0] * (1 - output[0]) * inputs[i]);
                weights[i] = weights[i] + (0.01 * 0.5 * (75 - output[0]));
            }
        }

    }
}
