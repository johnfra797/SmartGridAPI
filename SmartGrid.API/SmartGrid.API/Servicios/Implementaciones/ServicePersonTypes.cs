using SmartGrid.API.Servicios.Definiciones;
using SmartGrid.Datos.Base.Repositorios.Definiciones;
using SmartGrid.Datos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGrid.API.Servicios.Implementaciones
{
    ///<summary>
    ///Clase ServicePersonTypes
    ///</summary>
    ///<remarks>
    ///Se usa como servicio individual para la logica de interacción con el objeto PersonType
    ///</remarks>
    public class ServicePersonTypes : IServicePersonType
    {
        private IPersonTypesRepositorio _PersonTypesRepositorio;
        public ServicePersonTypes(IPersonTypesRepositorio personTypesRepositorio)
        {
            _PersonTypesRepositorio = personTypesRepositorio;
        }

        public PersonType Create(PersonType personType)
        {
            return _PersonTypesRepositorio.Create(personType);
        }

        public bool Delete(int id)
        {
            return _PersonTypesRepositorio.Delete(id);
        }

        public List<PersonType> Get()
        {
            return _PersonTypesRepositorio.Get();
        }

        public PersonType Get(int id)
        {
            return _PersonTypesRepositorio.Get(id);
        }

        public PersonType Update(int Id, PersonType personType)
        {
            return _PersonTypesRepositorio.Update(Id, personType);
        }
    }
}
