using SmartGrid.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGrid.API.Servicios.Definiciones
{
    public interface IServicePerson
    {
        List<Person> Get();
        bool Delete(int id);
        Person Update(int Id, Person person);
        Person Create(Person person);
    }
}
