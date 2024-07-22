using System.ComponentModel.DataAnnotations.Schema;

namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
        Tail = true;
        Legs = 2;
        Habitat = "Rainforest";
        Age = 2;
    }
    public string FeatherColor { get; set; }
    public string BeakColor { get; set; }
    public bool CanFly { get; set; }
    public bool BirdOfPrey { get; set; }
}