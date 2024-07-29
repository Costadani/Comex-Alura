public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente(string nome, string cpf, string email, string profissao, string telefone, Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Profissao = profissao;
            Telefone = telefone;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {CPF}, Email: {Email}, Profissão: {Profissao}, Telefone: {Telefone}, Endereço: [{Endereco}]";
        }
    }

