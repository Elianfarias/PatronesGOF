using Abstract_Factory.Abstract_Factory.Interfaces;

namespace Abstract_Factory.Entities
{
    public class MonochromeColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Aplicando color monocromatico.");
        }
    }
}