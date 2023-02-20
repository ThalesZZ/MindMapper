using System.Collections.Generic;
using System;
using System.Linq;

public class Graph : Entity {
    public List<Node> Nodes { get; set; }
    public List<Edge> Edges { get; set; }


    public Graph(int Id) : base(Id) {
        this.Nodes = new List<Node>();
        this.Edges = new List<Edge>();
    }

    public override string ToString() {
        string nodesList = String.Join(", ", Nodes.Select(n => n.ToString()).ToList());
        string edgesList = String.Join(", ", Edges.Select(e => e.ToString()).ToList());

        return $"G{this.Id} = ({{{nodesList}}}, {{{edgesList}}})";
    }

}