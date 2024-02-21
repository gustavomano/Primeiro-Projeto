internal class program
{
    static void Main(string[] args) 
          
    {
        string Nome;
        int Idade;
        string Cidade;

        Console.WriteLine("Qual teu nome?"); 
        Nome = Console.ReadLine();
        Console.WriteLine("Qual a tua idade mané?: ");
        Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("teu ninho?");
        Cidade = Console.ReadLine();
        
        Console.WriteLine("Nome:  {0}", Nome);
        Console.WriteLine("Idade: {0} anos", Idade);
        Console.WriteLine("Cidade: {0} ", Cidade);
        Console.WriteLine("Nome: {0} Idade: {1} Cidade: {2}", Nome, Idade, Cidade); 
        
        

       
    }   
}