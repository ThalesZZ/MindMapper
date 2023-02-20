public class Edge : Entity {
    public Node Source { get; set; }
    public Node Target { get; set; }

    public Edge(int Id, Node Source, Node Target) : base(Id) {
        this.Source = Source;
        this.Target = Target;
    }

    public override string ToString() {
        return $"e{this.Id} = ({this.Source.ToString()}, {this.Target.ToString()})";
    }

    public override bool Equals(object? obj)
    {
        Edge? that = (Edge?) obj;
        return base.Equals(obj) 
            || this.Id.Equals(that?.Id) 
            || (this.Source.Id.Equals(that?.Source.Id) && this.Target.Id.Equals(that?.Target.Id))
            || (this.Source.Id.Equals(that?.Target.Id) && this.Target.Id.Equals(that?.Source.Id));
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}