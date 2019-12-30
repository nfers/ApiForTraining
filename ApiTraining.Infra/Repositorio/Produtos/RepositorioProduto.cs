using ApiTraining.Infra.Repositorio.Generico;
using System;
using System.Collections.Generic;
using System.Text;
using ApiTraining.Domain.Entidades;
using ApiTraining.Domain.Interfaces.Produtos;

namespace ApiTraining.Infra.Repositorio.Produtos
{
    public class RepositorioProduto : RepositorioGenerico<Produto>, InterfaceProduto
    {

    }
}
