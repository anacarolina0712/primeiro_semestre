using System;

namespace backend_UltimoProjetoDoAno_21_12.classes
{
    public class Usuario
    {
        public  int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro{ get; set; }

        public Usuario(){
            cadastrar();
        }

        public Usuario(int _Codigo, string _nome, string _email, string _senha ){
            
            Codigo = _Codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }
        public void cadastrar(){
            Nome = "Ana Carolina";
            Email = "admin@admin";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;
        }
       
        public void deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");
        }
        
        
        
        
    }
}