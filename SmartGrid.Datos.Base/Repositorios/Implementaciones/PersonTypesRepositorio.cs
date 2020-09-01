using SmartGrid.Datos.Base.Repositorios.Definiciones;
using SmartGrid.Datos.DTO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGrid.Datos.Base.Repositorios.Implementaciones
{
    public class PersonTypesRepositorio : IPersonTypesRepositorio
    {
      
        public PersonTypesRepositorio()
        {
        }

        public PersonType Create(PersonType entity)
        {
            var max = BD.BDPersonType.Values.Any() ? BD.BDPersonType.Aggregate((l, r) => l.Key > r.Key ? l : r).Key : 0;
            int Id = max + 1;
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
