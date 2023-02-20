public class Edge : Entity {
    public Node Source { get; set; }
    public Node Target { get; set; }

    public Edge(int Id, Node Source, Node Target) : base(Id) {
        this.Source = Source;
        this.Target = Target;
    }

    public override string ToString() {
        return $"e{this.Id}";
    }

}