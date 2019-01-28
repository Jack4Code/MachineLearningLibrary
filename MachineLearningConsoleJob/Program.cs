using MachineLearningLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningConsoleJob
{
    class Program
    {
        public static void Main(string[] args)
        {
            int inputCount = 2;
            Neuron neuron = new Neuron(inputCount);
            double[] inputs = { 50, 25 };
            neuron.inputs = inputs;

            //Print the goal
            Console.WriteLine("The target is to get the computer to take 50 and 25 and give us 75");

            //the initialized weights are:
            Console.WriteLine("The initialized weights are: ");
            for(int i=0; i<2; i++)
            {
                Console.WriteLine(neuron.weights[i]);
            }
            Console.WriteLine(); //print a space

            for(int i=0; i<200; i++)
            {
                neuron.UpdateWeights();
                Console.WriteLine("The output is: " + neuron.output[0]);
                Console.WriteLine("The updated weights are: ");
                neuron.weights.ToList().ForEach(Console.WriteLine);
                Console.WriteLine();
            }

            ExitProgram();
        }

        public static void ExitProgram()
        {
            Console.WriteLine("Press any key to escape: ");
            Console.ReadLine();
        }

    }
}
