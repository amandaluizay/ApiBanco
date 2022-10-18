namespace Business.Models
{
    public class ContaJuridica : Entity
    {
        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string ChaveJ { get; set; }
        public string Usuario { get; set; }
        public int Senha8Dig { get; set; }
        public string Senha6Dig { get; set; }

    }
}

