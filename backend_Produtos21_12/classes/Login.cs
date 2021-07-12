using System;

namespace backend_UltimoProjetoDoAno_21_12.classes
{
    public class Login
    {
        public bool logado { get; set; }

        public Login(){
            Logar();

            if(logado == true){
                GerarMenu();
            }
        }

        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();
            

            string opcao = "n";

            do{

                Console.WriteLine("Escolha uma das opçoes abaixo: ");
                Console.WriteLine("1 - Cadastrar Marcas"); 
                Console.WriteLine("2 - Listar Marcas"); 
                Console.WriteLine("3 - Excluir Marca"); 
                Console.WriteLine("4 - Cadatrar Produtos"); 
                Console.WriteLine("5 - Listar Produtos"); 
                Console.WriteLine("6 - Excluir Produtos"); 
                Console.WriteLine("0 - Sair da Aplicação"); 

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    marca.Cadastrar();
                        break;

                    case "2":
                    marca.Listar();
                        break;

                    case "3":
                    Console.WriteLine("Digite um codigo para excluir a marca: ");
                    int codigo = int.Parse(Console.ReadLine());
                    marca.Deletar(codigo);
                        break;

                    case "4":
                        produto.Cadastrar();
                        break;

                    case "5":
                        produto.Listar();
                        break;

                    case "6":
                    Console.WriteLine("Digite um codigo para excluir o produto: ");
                    int codigoProduto = int.Parse(Console.ReadLine());
                    produto.Deletar(codigoProduto);
                        break;

                    default:
                        break;
                }
                

            }while(opcao != "0");
        }

         public void Logar(){

            Usuario user = new Usuario();

            Console.WriteLine("Digite seu email: ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == user.Email && senhaLogin == user.Senha){
                logado = true;
            Console.WriteLine("Login efetuado com sucesso! ");
            }else{
                Console.WriteLine("falha ao realizar o Login, tente novamente :( ");
            }


        }
        public void Deslogar(){
            logado = false;
        }
        
        
        
        
    }
}