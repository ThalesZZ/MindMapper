using System.Collections.Generic;

public class Graph : Entity {
    public List<Node> Nodes { get; set; }
    public List<Edge> Edges { get; set; }

    public Graph(int Id, List<Node> Nodes, List<Edge> Edges) : base(Id) {
        this.Nodes = Nodes;
        this.Edges = Edges;
     }

    public override string ToString() {
        return $"Graph @ Nodes.Count = {Nodes.Count}; Edges.Count = {Edges.Count} ";
    }

}