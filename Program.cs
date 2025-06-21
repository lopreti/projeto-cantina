namespace Cantinaa
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            
            GerenciadorDados.CarregarTodosDados();
            
            Application.Run(new TelaLogin());
            
          
            GerenciadorDados.SalvarTodosDados();
        }
    }
}