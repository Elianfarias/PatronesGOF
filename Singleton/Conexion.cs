namespace Singleton
{
    public class Conexion
    {
        private static Conexion instancia;
        private bool isConected = false;
        private string message;
        
        private Conexion() { }

        public static Conexion GetInstance() {
            if (instancia == null)
                instancia = new Conexion();

            return instancia;
        }

        public string GetMessage() => isConected ? message : "¡Saludos! :)";

        public void Conectar() {
            message = "¡Bienvenido! :)";
            isConected = true;
        }
    }
}
