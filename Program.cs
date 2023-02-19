
using System;
using System.Collections.Generic;

List<Node> nodes = new List<Node>() {
    new Node(0, "Node 0"),
    new Node(1, "Node 1")
};
List<Edge> edges = new List<Edge>() {
    new Edge(0, nodes[0], nodes[1])
};
Graph graph = new Graph(0, nodes, edges);

Console.WriteLine(graph);
