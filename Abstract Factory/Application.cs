using Abstract_Factory.Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    public class Application
    {
        private readonly ThemeFactory themeFactory;

        public Application(ThemeFactory factory)
        {
            themeFactory = factory;
        }

        public void Draw()
        {
            themeFactory.GetBackgroundColor().ApplyColor();
        }
    }
}
