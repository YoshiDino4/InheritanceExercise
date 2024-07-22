namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        Tail = true;
        Legs = 4;
        Habitat = "Marsh";
        Age = 10;
    }
    public string ScaleColor { get; set; }
    public bool HasShell { get; set; }
    public bool ForkedTongue { get; set; }
    public bool LiveInWater { get; set; }

}