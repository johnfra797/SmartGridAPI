using SmartGrid.Datos.Base.Repositorios.Definiciones;
using SmartGrid.Datos.DTO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGrid.Datos.Base.Repositorios.Implementaciones
{
    ///<summary>
    ///Clase PersonTypesRepositorio
    ///</summary>
    ///<remarks>
    ///Se usa para manejar la logica CRUD del objeto PersonType
    ///</remarks>
    public class PersonTypesRepositorio : IPersonTypesRepositorio
    {

        public PersonTypesRepositorio()
        {
        }

        public PersonType Create(PersonType entity)
        {
            var max = BD.BDPersonType.Values.Any() ? BD.BDPersonType.Aggregate((l, r) => l.Key > r.Key ? l : r).Key : 0;
            int Id = entity.ID == 0 ? max + 1 : entity.ID;
            bool result = BD.BDPersonType.TryAdd(Id, entity);
            entity.ID = Id;
            return entity;
        }

        public bool Delete(int Id)
        {
            PersonType entity;
            bool result = BD.BDPersonType.TryRemove(Id, out entity);
            return result;
        }

        public List<PersonType> Get()
        {
            var values = new List<PersonType>(BD.BDPersonType.Values);
            return values;
        }

        public PersonType Get(int id)
        {
            PersonType entity;
            bool returnTrue = BD.BDPersonType.TryGetValue(id, out entity);
            return entity;
        }

        public PersonType Update(int Id, PersonType entity)
        {
            PersonType entityUpd;
            bool returnTrue = BD.BDPersonType.TryGetValue(Id, out entityUpd);
            Delete(Id);
            entity.ID = Id;
            entity = Create(entity);
            return entity;
        }
    }
}
