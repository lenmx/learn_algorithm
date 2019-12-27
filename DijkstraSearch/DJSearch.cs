using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DijkstraSearch
{
    public class DJSearch
    {
        private Dictionary<string, Dictionary<string, float>> graph = new Dictionary<string, Dictionary<string, float>>();
        private Dictionary<string, float> costs = new Dictionary<string, float>();
        private Dictionary<string, string> parents = new Dictionary<string, string>();
        private List<string> processed = new List<string>();

        public DJSearch()
        {
            graph.Add("start", new Dictionary<string, float> { { "a", 6 }, { "b", 2 } });
            graph.Add("a", new Dictionary<string, float> { { "end", 1 } });
            graph.Add("b", new Dictionary<string, float> { { "a", 3 }, { "end", 5 } });
            graph.Add("end", new Dictionary<string, float> { });

            costs.Add("a", 6);
            costs.Add("b", 2);
            costs.Add("end", float.PositiveInfinity);

            parents.Add("a", "start");
            parents.Add("b", "start");
            parents.Add("end", null);
        }

        public void Search()
        {
            var name = FindLowCostNode(costs);
            while (!string.IsNullOrEmpty(name))
            {
                var cost = costs[name];
                var nodes = graph[name];
                float newCost = 0;

                foreach (var node in nodes)
                {
                    newCost = cost + node.Value;
                    if (costs[node.Key] > newCost)
                    {
                        costs[node.Key] = newCost;
                        parents[node.Key] = node.Key;
                    }
                }

                processed.Add(name);
                name = FindLowCostNode(costs);
            }
        }

        public override string ToString()
        {
            var paths = GetPath();
            

            return $@"paths: {string.Join("->", paths)}";
        }

        string[] GetPath(string key = "end")
        {
            int i = 0;
            string[] paths = new string[parents.Count];

            while (!string.IsNullOrEmpty(key))
            {
                paths[i++] = key;
                key = parents[key];
            }

            return paths.Reverse().ToArray();
        }

        string FindLowCostNode(Dictionary<string, float> _costs)
        {
            string lowNodeName = "";
            float lowCost = float.PositiveInfinity;

            foreach (var cost in _costs)
            {
                if (!processed.Contains(cost.Key) && cost.Value < lowCost)
                {
                    lowNodeName = cost.Key;
                    lowCost = cost.Value;
                }
            }

            return lowNodeName;
        }

    }
}
