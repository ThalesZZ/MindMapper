public abstract class Entity {

    private int id;

    public Entity(int id) {
        this.id = id;
    }

    public int Id {
        get { return id; }
        set { id = value; }
    }

}