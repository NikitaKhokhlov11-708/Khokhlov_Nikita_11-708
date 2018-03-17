using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM1
{
    public class Edge
    {
        public Edge(Tuple<int,int> data)
        {
            Data = data;
        }
        public Tuple<int,int> Data { get; set; }
        public Edge Next { get; set; }
    }
}
