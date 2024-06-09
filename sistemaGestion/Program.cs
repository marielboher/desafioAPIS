namespace sistemaGestion
{
    internal static class Program
    {
        public static Form1 form1;
        public static FormUsuarios formUsuarios;
        public static FormVentas formVentas;
        public static FormProductos formProductos;
        public static FormProductosVendidos formProductosVendidos;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            form1 = new Form1();
            formUsuarios = new FormUsuarios();
            formVentas = new FormVentas();
            formProductos = new FormProductos();
            formProductosVendidos = new FormProductosVendidos();
            Application.Run(form1);
        }
    }
}
