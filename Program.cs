
using System;

GraphService graphService = new GraphServiceImpl();

Graph graph = new Graph(1);
graphService.AddNode(graph, new Node(1, "Node 1"));
graphService.AddNode(graph, new Node(2, "Node 2"));
graphService.AddNode(graph, new Node(3, "Node 3"));

Console.WriteLine(graph);
