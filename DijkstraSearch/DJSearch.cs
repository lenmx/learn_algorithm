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
            var name = FindLowCostNode(costs); // 找到最小开销的点
            while (!string.IsNullOrEmpty(name))
            {
                var cost = costs[name]; 
                var nodes = graph[name]; // 找到他的邻居
                float newCost = 0;

                foreach (var node in nodes) // 遍历邻居
                {
                    newCost = cost + node.Value;    
                    if (costs[node.Key] > newCost)
                    {
                        costs[node.Key] = newCost; // 更新邻居的开销
                        parents[node.Key] = name; // 更新节点的父节点
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
            List<string> paths = new List<string>();

            while (!string.IsNullOrEmpty(key))
            {
                paths.Add(key);
                key = parents.ContainsKey(key)?parents[key]:"";
            }

            return paths.ToArray().Reverse().ToArray();
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
