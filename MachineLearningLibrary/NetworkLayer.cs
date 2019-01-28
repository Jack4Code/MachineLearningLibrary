using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningLibrary
{
    public class NetworkLayer
    {
        public Neuron[] Neurons { get; set; }
        public string LayerType { get; set; }

        public NetworkLayer(int numOfNeurons, string typeOfLayer)
        {
            Neurons = new Neuron[numOfNeurons];
            LayerType = typeOfLayer;
        }



    }
}
