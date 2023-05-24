using Abstract_Factory.Abstract_Factory.Interfaces;

namespace Abstract_Factory.Entities
{
    public class LightColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Aplicando color blanco.");
        }
    }
}