using ApiForTraining.Domain.Entidades;
using ApiForTraining.Domain.Interfaces.Produtos;
using ApiTraining.Infra.Repositorio.Generico;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTraining.Infra.Repositorio.Produtos
{
    public class RepositorioProduto : RepositorioGenerico<Produto>, InterfaceProduto
    {

    }
}
