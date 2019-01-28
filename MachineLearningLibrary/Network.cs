using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningLibrary
{
    public class Network
    {
        public double LEARNING_RATE { get; set; }
        public int TOTAL_LAYER_COUNT { get; set; }
        //public int HIDDEN_LAYER_COUNT { get; set; }
        //public NetworkLayer inputLayer { get; set; }
        //public NetworkLayer[] hiddenLayers { get; set; }
        //public NetworkLayer outputLayer { get; set; }
        public NetworkLayer[] layers { get; set; }

        //Constructor
        public Network(int layerCount, double learningRate = 0.01)
        {
            //if (layerCount < 2) return;

            LEARNING_RATE = learningRate;
            TOTAL_LAYER_COUNT = layerCount;
            //HIDDEN_LAYER_COUNT = layerCount - 2;
        }


        //public double Sigmoid(double x)
        //{
        //    return 1 / (1 + Math.Exp(-x));
        //}

        public void TrainNetwork()
        {
            //It should calculate the output of each neron in a layer and take each outut 
            foreach(NetworkLayer layer in layers)
            {
                double[] outputs = new double[layer.Neurons.Count()];
                for(int i=0; i<layer.Neurons.Count(); i++)
                {
                    //layer.Neurons[i].ForwardFeed();
                    outputs[i] = layer.Neurons[i].output[0];
                }
            }
        }

    }
}
