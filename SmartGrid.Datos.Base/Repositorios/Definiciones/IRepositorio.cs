using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGrid.Datos.Base.Repositorios.Definiciones
{
    public interface IRepositorio<T>
    {
        List<T> Get();
        T Create(T entity);
        T Update(int Id,T entity);
        bool Delete(int Id);

    }
}