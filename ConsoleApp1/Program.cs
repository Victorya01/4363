using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            Graph g = new Graph(4);
            g.addEdge(0, 1);
            g.addEdge(1, 1);
            g.addEdge(1, 2);
            g.addEdge(1, 3);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 2);

            g.DFS(3);
            Console.WriteLine("");
            g.BFS(2);

        }
    }
}
