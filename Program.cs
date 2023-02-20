
using System;

GraphService graphService = new GraphServiceImpl();

Node node1 = new Node(1, "Node 1");
Node node2 = new Node(2, "Node 2");
Node node3 = new Node(3, "Node 3");
Edge edge1 = new Edge(1, node1, node2);
Edge edge2 = new Edge(2, node2, node3);
Edge edge3 = new Edge(3, node1, node3);

Graph graph = new Graph(1);
graphService.AddNode(graph, node1);
graphService.AddNode(graph, node2);
graphService.AddNode(graph, node3);
graphService.AddEdge(graph, edge1);
graphService.AddEdge(graph, edge2);
graphService.AddEdge(graph, edge3);
// graphService.AddEdge(graph, new Edge(4, node3, node1));

Console.WriteLine(graph);
