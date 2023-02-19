using System.Collections.Generic;
using System;

public class Graph : Entity {
    public List<Node> Nodes { get; set; }
    public List<Edge> Edges { get; set; }


    public Graph(int Id) : base(Id) {
        this.Nodes = new List<Node>();
        this.Edges = new List<Edge>();
    }

    public Graph(int Id, List<Node> Nodes, List<Edge> Edges) : base(Id) {
        foreach(Node node in Nodes) node.Validate();
        foreach(Edge edge in Edges) edge.Validate();

        this.Nodes = Nodes;
        this.Edges = Edges;
     }

    public void AddNode(Node node) {
        if(checkExistence(node, this.Nodes)) throw new Exception($"Node with Id={node.Id} already exists in Graph with Id={this.Id}");
        node.Validate();
        this.Nodes.Add(node);
    }

    public void AddEdge(Edge edge) {
        if(checkExistence(edge, this.Edges)) throw new Exception($"Edge with Id={edge.Id} already exists in Graph with Id={this.Id}");
        edge.Validate();
        this.Edges.Add(edge);
    }

    private bool checkExistence<T> (T entity, List<T> entities) where T: Entity {
        return entities.Exists(e => e.Id == entity.Id);
    }

    public override void Validate() {
        foreach (Node node in this.Nodes) node.Validate();
        foreach (Edge edge in this.Edges) edge.Validate();
    }

    public override string ToString() {
        return $"Graph @ Nodes.Count = {Nodes.Count}; Edges.Count = {Edges.Count} ";
    }

}