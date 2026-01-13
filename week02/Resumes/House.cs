public class House
{
    public string _owner = "";
    public Blind _kitchen = new Blind();
    public Blind _livingRoom = new Blind();

    public void Area2()
    {
        Console.WriteLine(
            $"Owner: {_owner}  Kitchen Area: {_kitchen.GetArea()}"
        );
    }
}
