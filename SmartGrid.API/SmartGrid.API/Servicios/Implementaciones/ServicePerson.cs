using SmartGrid.API.Servicios.Definiciones;
using SmartGrid.Datos.Base.Repositorios.Definiciones;
using SmartGrid.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGrid.API.Servicios.Implementaciones
{
    public class ServicePerson : IServicePerson
    {
        private IPersonRepositorio _PersonRepositorio;
        public ServicePerson(IPersonRepositorio personRepositorio)
        {
            _PersonRepositorio = personRepositorio;
        }

        public Person Create(Person person)
        {
            return _PersonRepositorio.Create(person);
        }

        public bool Delete(int id)
        {
            return _PersonRepositorio.Delete(id);
        }

        public List<Person> Get()
        {
            return _PersonRepositorio.Get();
        }

        public Person Update(int Id, Person person)
        {
            return _PersonRepositorio.Update(Id, person);
        }
    }
}
