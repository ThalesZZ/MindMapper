using System;
using System.Collections.Generic;
using System.Reflection;

public class Node : Entity {
    private string name;

    public Node(int id, string name) : base(id) {
        this.name = name;
    }

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public override string ToString() {
        List<string> values = new List<string>();

        Type clazz = typeof(Node);
        PropertyInfo[] attribs = clazz.GetProperties();
        foreach(PropertyInfo attrib in attribs)
            values.Add($"{attrib.Name}({attrib.PropertyType.Name}) = {attrib.GetValue(this)}");

        return $"Node @ {String.Join("; ", values)}";
    }

}