using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTraining.Aplicacao.Interface
{
    public interface InterfaceGenericaApp<T> where T : class
    {
        void Adicionar(T Objeto);

        void Atualizar(T Objeto);

        void Excluir(T Objeto);

        T ObterPorId(int Id);

        IList<T> Listar();
    }

}
