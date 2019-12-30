using ApiForTraining.Domain.Entidades;
using ApiForTraining.Domain.Interfaces.Produtos;
using ApiTraining.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTraining.Aplicacao.Aplicacoes
{
    public class ProdutoApp : InterfaceProdutoApp
    {
        InterfaceProduto _InterfaceProduto;

        public ProdutoApp (InterfaceProduto InterfaceProduto)
        {
            _InterfaceProduto = InterfaceProduto;
        }

        public void Adicionar(Produto Objeto)
        {
            _InterfaceProduto.Adicionar(Objeto);
        }

        public void Atualizar(Produto Objeto)
        {
            _InterfaceProduto.Atualizar(Objeto);
        }

        public void Excluir(Produto Objeto)
        {
            _InterfaceProduto.Excluir(Objeto);
        }

        public IList<Produto> Listar()
        {
            return _InterfaceProduto.Listar();
        }

        public Produto ObterPorId(int Id)
        {
            return _InterfaceProduto.ObterPorId(Id);
        }
    }
}
