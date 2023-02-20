using System;
using System.Collections.Generic;

class GraphServiceImpl : GraphService
{
    public void AddNode(Graph graph, Node node)
    {
        if(checkExistence(node, graph.Nodes))
            throw new Exception($"Node with Id={node.Id} already exists in Graph with Id={graph.Id}");

        graph.Nodes.Add(node);
    }

    public void RemoveNode(Graph graph, Node node)
    {
        graph.Edges.RemoveAll(e => e.Source.Id == node.Id || e.Target.Id == node.Id);
        graph.Nodes.RemoveAll(n => n.Id == node.Id);
    }

    public void AddEdge(Graph graph, Edge edge)
    {
        if(checkExistence(edge, graph.Edges))
            throw new Exception($"Edge with Id={edge.Id} already exists in Graph with Id={graph.Id}");

        if(edge.Source == null || edge.Target == null)
            throw new Exception($"An Edge must have a Source and a Target Node");

        if(!checkExistence(edge.Source, graph.Nodes))
            throw new Exception($"Node Id={edge.Source.Id} doesn't exists in Graph Id={graph.Id}");

        if(!checkExistence(edge.Target, graph.Nodes))
            throw new Exception($"Node Id={edge.Target.Id} doesn't exists in Graph Id={graph.Id}");

        if(edge.Source.Id == edge.Target.Id)
            throw new Exception($"A Node can't connect to itself");

        graph.Edges.Add(edge);
    }


    public void RemoveEdge(Graph graph, Edge edge)
    {
        graph.Edges.RemoveAll(e => e.Id == edge.Id);
    }

    private bool checkExistence<T> (T entity, List<T> entities) where T: Entity {
        return entities.Exists(e => e.Id == entity.Id);
    }
}