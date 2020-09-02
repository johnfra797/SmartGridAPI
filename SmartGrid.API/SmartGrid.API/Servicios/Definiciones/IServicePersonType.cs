using SmartGrid.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGrid.API.Servicios.Definiciones
{
    ///<summary>
    ///Interface IServicePersonType
    ///</summary>
    ///<remarks>
    ///Se usa como contrato para implementar los metodos necesarios para interactuar con el objeto PersonType
    ///</remarks>
    public interface IServicePersonType
    {
        PersonType Get(int id);
        List<PersonType> Get();
        bool Delete(int id);
        PersonType Update(int Id, PersonType personType);
        PersonType Create(PersonType personType);
    }
}
