using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGrid.Datos.Base.Repositorios.Definiciones
{

    ///<summary>
    ///Interface IRepositorio
    ///</summary>
    ///<remarks>
    ///Se usa para dictar reglas para cada clases repositorio que la implemente
    ///</remarks>
    public interface IRepositorio<T>
    {
        T Get(int id);
        List<T> Get();
        T Create(T entity);
        T Update(int Id, T entity);
        bool Delete(int Id);

    }
}