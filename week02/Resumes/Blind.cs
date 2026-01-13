public class Blind
{
    public double _width = 0;
    public double _height = 0;
    public string _color = "";

    public double GetArea()
    {
        return _width * _height;
    }

    public void ShowM()
    {
        Console.WriteLine($"{_width}, {_height}, {_color}");
    }

    public void Area1()
    {
        Console.WriteLine($"Kitchen Area: {GetArea()}");
    }
}
