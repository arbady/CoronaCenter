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
        Mapping
    }

    public abstract class BaseServices<Entity, Model, Form> :
        IService<Model, Form>
        where Entity : class, IDataModel<int>
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
        protected virtual Model MapEntity(Entity entity, CRUDAction action = CRUDAction.Mapping)
        {
            return Mapper.MapEntityToModel(entity);
        }
        protected virtual Entity MapForm(Form form, CRUDAction action = CRUDAction.Mapping)
        {
            return Mapper.MapFormToEntity(form);
        }
        protected virtual Entity MapModel(Model model, CRUDAction action = CRUDAction.Mapping)
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
        private Model OnSingleEntityRead(Entity entity)
        {
            return MapEntity(entity, CRUDAction.Read);
        }

        public virtual IEnumerable<Model> GetAll()
        {
            return Query.Select(OnSingleEntityRead);
        }

        public virtual Model GetById(int id)
        {
            return Query
                .Where(a => a.Id == id)
                .Select(OnSingleEntityRead)
                .SingleOrDefault();
        }

        // Appeler avant le _dc.SaveChange() sur l'insertion
        // Cette fonction est appélée dans la fonction Insert un peu plus bas
        protected virtual Entity OnInsert(Form form)
        {
            Entity entity = MapForm(form, CRUDAction.Create);
            Set.Add(entity);
            return entity;
        }

        // Idem que pour le OnInsert
        protected virtual Entity OnUpdate(int id, Form form)
        {
            Entity entity = MapForm(form, CRUDAction.Update);
            entity.Id = id;

            return Set
                .Update(entity)
                .Entity;
        }

        // Idem que pour le OnInsert
        protected virtual Entity OnDelete(int id)
        {
            Entity entity = Set.FirstOrDefault(model => model.Id == id);
            Set.Remove(entity);
            return entity;
        }

        public Model Insert(Form form)
        {
            Entity Entity = OnInsert(form);

            Dc.SaveChanges();

            return MapEntity(Entity, CRUDAction.Create);
        }

        public Form Update(int id, Form form)
        {
            Entity Entity = OnUpdate(id, form);

            Dc.SaveChanges();

            return Mapper.MapModelToForm(Entity);
        }

        public void Delete(int model)
        {
            OnDelete(model);
            Dc.SaveChanges();
        }
    }
}
