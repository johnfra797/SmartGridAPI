using SmartGrid.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGrid.API.Servicios.Definiciones
{
    ///<summary>
    ///Interface IServicePerson
    ///</summary>
    ///<remarks>
    ///Se usa como contrato para implementar los metodos necesarios para interactuar con el objeto Person
    ///</remarks>
    public interface IServicePerson
    {
        Person Get(int id);
        List<Person> Get();
        bool Delete(int id);
        Person Update(int Id, Person person);
        Person Create(Person person);
    }
}
