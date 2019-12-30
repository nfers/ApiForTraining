using ApiTraining.Domain.Entidades.Genericos;
using ApiTraining.Infra.Configuracao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiTraining.Infra.Repositorio.Generico
{
    public class RepositorioGenerico<T> : InterfaceGenerica<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public RepositorioGenerico()
        {
            _OptionsBuilder = new DbContextOptions<Context>();
        }

        public void Adicionar(T Objeto)
        {
            using Context banco = new Context(_OptionsBuilder);
            banco.Set<T>().Add(Objeto);
            Console.WriteLine("Gravando");
            banco.SaveChangesAsync();
        }

        public void Atualizar(T Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<T>().Update(Objeto);
                Console.WriteLine("alterando");
                banco.SaveChangesAsync();
            }
        }

        public void Excluir(T Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<T>().Remove(Objeto);
                Console.WriteLine("excluindo");
                banco.SaveChangesAsync();
            }
        }

        public IList<T> Listar()
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<T>().AsNoTracking().ToList();
            }
        }

        public T ObterPorId(int Id)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<T>().Find(Id);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
