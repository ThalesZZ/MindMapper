using System;
using System.Collections.Generic;
using System.Reflection;

public abstract class Entity {

    public int Id { get; set; }

    public Entity(int Id) {
        this.Id = Id;
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