﻿namespace apivendas.Dtos.Vendas
{
    public class MostrarVendaItemDTO
    {
        public int Quantidade { get; set; }
        public decimal ValorVenda { get; set; }
        public MostrarProdutoDTO Produto { get; set; }

    }
}