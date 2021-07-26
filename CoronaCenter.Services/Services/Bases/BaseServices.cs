using CoronaCenter.DataBase;
using CoronaCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    //Cet enum permet d'indiquer quelle action s'effectue
    public enum CRUDAction
    {
        Create,
        Read,
        Update,
        Delete,
        Has,
        Mapping
    }

    public abstract class BaseServices<DataContext, Entity, Model, Form, Tid> :
        IService<Model, Form, Tid>
        where Entity : class, IDataModel<Tid>
        where Tid : IComparable<Tid>
        where DataContext : DbContext
    {
        protected DataContext Dc; 
        protected DbSet<Entity> Set;
        protected IQueryable<Entity> Query; // Pour inclure les différentes query comme include,...
        protected IMapper<Entity, Model, Form> Mapper; // Pour convertir une donnée en une autre forme de données

        public BaseServices(DataContext dc, IMapper<Entity, Model, Form> mapper)
        {
            Dc = dc;
            Set = GetDbSet(dc);
            Query = PrepareQuery(Set);
            Mapper = mapper;
        }
        
        // Pour convertir une entité en model
        // On pouurait faire plusieurs autres conversions a la fois avec cette methode
        protected virtual Model MapEntityToModel(Entity entity, CRUDAction action = CRUDAction.Mapping)
        {
            return Mapper.MapEntityToModel(entity);
        }
        protected virtual Form MapEntityToForm(Entity entity, CRUDAction action = CRUDAction.Mapping)
        {
            return Mapper.MapModelToForm(Mapper.MapEntityToModel(entity));
        }
        protected virtual Entity MapFormToEntity(Form form, CRUDAction action = CRUDAction.Mapping)
        {
            return Mapper.MapFormToEntity(form);
        }
        protected virtual Entity MapModelToEntity(Model model, CRUDAction action = CRUDAction.Mapping)
        {
            return Mapper.MapModelToEntity(model);
        }

        // Me permet de recuperer les données dans le DbSet
        protected abstract DbSet<Entity> GetDbSet(DataContext dc);

        // Renvoie une erreur de base au cas où le modele n'est pas valide
        protected virtual string InvalidModelError(Exception e) => $"{typeof(Entity).Name} is invalid";

        // Permet de préparer ma query. ex : Include ou thenInclude
        protected virtual IQueryable<Entity> PrepareQuery(DbSet<Entity> Entity)
        {
            return Set;
        }

        // Permet de traiter une entité seule, c'est une fonction back-end
        // Permet la repetabilité des Select
        private Model OnSingleEntityModel(Entity entity)
        {
            return MapEntityToModel(entity, CRUDAction.Read);
        }
        private Form OnSingleEntityForm(Entity entity)
        {
            return MapEntityToForm(entity, CRUDAction.Read);
        }

        public virtual IEnumerable<Model> GetAll()
        {
            return Query.Select(OnSingleEntityModel);
        }

        public virtual Model GetById(Tid id)
        {
            return Query
                .Where(a => a.Id.Equals(id))
                .Select(OnSingleEntityModel)
                .SingleOrDefault();
        }

        public virtual Model Get(Form form)
        {
            return Query
                .Where(a => a == MapFormToEntity(form, CRUDAction.Read))
                .Select(OnSingleEntityModel)
                .FirstOrDefault();
        }

        public virtual Form GetToForm(Tid id)
        {
            return Query
                .Where(a => a.Id.Equals(id))
                .Select(OnSingleEntityForm)
                .SingleOrDefault();
        }

        // Appeler avant le _dc.SaveChange() sur l'insertion
        // Cette fonction est appélée dans la fonction Insert un peu plus bas
        protected virtual Entity OnInsert(Form form)
        {
            Entity entity = MapFormToEntity(form, CRUDAction.Create);
            Set.Add(entity);
            return entity;
        }

        // Idem que pour le OnInsert
        protected virtual Entity OnUpdate(Tid id, Form form)
        {
            Entity entity = MapFormToEntity(form, CRUDAction.Update);
            entity.Id = id;

            Set.Update(entity);
            return entity;
        }

        // Idem que pour le OnInsert
        protected virtual Entity OnDelete(Tid id)
        {
            Entity entity = Set.FirstOrDefault(model => model.Id.Equals(id));
            Set.Remove(entity);
            return entity;
        }

        public Model Insert(Form form)
        {
            Entity Entity = OnInsert(form);

            Save();

            return MapEntityToModel(Entity, CRUDAction.Create);
        }

        public Form Update(Tid id, Form form)
        {
            Entity Entity = OnUpdate(id, form);

            Save();

            return MapEntityToForm(Entity, CRUDAction.Update);
        }

        public void Delete(Tid id)
        {
            OnDelete(id);

            Save();
        }

        public bool Has(Tid id)
        {
            return Set.Where(a => a.Id.Equals(id)).FirstOrDefault() != null;
        }

        public bool Has(Model model)
        {
            return Set.Where(a => a == MapModelToEntity(model, CRUDAction.Has)).FirstOrDefault() != null;
        }

        public bool Has(Form form)
        {
            return Set.Where(a => a == MapFormToEntity(form, CRUDAction.Has)).FirstOrDefault() != null;
        }

        public void Save()
        {
            Dc.SaveChanges();
        }
    }
}
