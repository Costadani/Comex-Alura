 public class Endereco
    {
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }


        public override string ToString()
        {
            return $"Rua: {Rua}, Número: {Numero}, Bairro: {Bairro}, Cidade: {Cidade}, Estado: {Estado}, Complemento: {Complemento}";
        }
    }
