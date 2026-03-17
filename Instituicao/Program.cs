using InstituicaoEnsino;

class Program
{
    static void Main(string[] args)
    {
        Instituicao instituicao = new Instituicao();
        Console.Write("Informe seu nome: ");
        instituicao.Nome = Console.ReadLine();
        Console.Write("Informe seu endereço: ");
        instituicao.Endereco = Console.ReadLine();

        Console.WriteLine("=====");
        Console.WriteLine($"Obrigado por informar seus dados para a nossa instituição, {instituicao.Nome}. Seja bem vindo!");
        Console.WriteLine("Pressione qualquer tecla");
        Console.ReadKey();
    }
}