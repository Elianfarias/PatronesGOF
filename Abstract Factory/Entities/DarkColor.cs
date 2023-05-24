using Abstract_Factory.Abstract_Factory.Interfaces;

namespace Abstract_Factory.Entities
{
    public class DarkColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Aplicando color oscuro.");
        }
    }
}
