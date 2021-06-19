using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {

        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();

    }
}
