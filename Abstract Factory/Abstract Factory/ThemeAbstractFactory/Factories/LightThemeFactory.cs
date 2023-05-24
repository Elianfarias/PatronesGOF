using Abstract_Factory.Entities;
using Abstract_Factory.Abstract_Factory.Interfaces;

namespace Abstract_Factory.Abstract_Factory
{
    public class LightThemeFactory : ThemeFactory
    {
        public override IColor GetBackgroundColor()
        {
            return new LightColor();
        }
    }
}
