namespace ProjetoModeloDDD.Domains.Entities
{
    public  class Produto
    {
        public int Produto_Id { get; set; }
        public string Produto_Nome { get; set; }
        public decimal ProdutoValor { get; set; }
        public bool Produto_Disponivel { get; set; }
        public int Cliente_id { get; set; }
        public virtual Cliente Cliente { get; set; }


    }
}
