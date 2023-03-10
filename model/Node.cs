public class Node : Entity {
    public string Name { get; set; }

    public Node(int Id, string Name) : base(Id) {
        this.Name = Name;
    }

    public override string ToString() {
        return $"v{this.Id}";
    }

}