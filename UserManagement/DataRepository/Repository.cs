    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataAccess;
    using System.Data.Entity;
using System.Data.SqlClient;


    namespace DataRepository
    {
        public class Repository<T> : IRepository<T> where T: class
        {
             protected DbSet<T> dbSet { get; set; }

            UserManagementContext context = new UserManagementContext();

            
            public Repository ()
	            {
                dbSet = context.Set<T>();
	            }

            public UserManagementContext UserManagementContextInstance { get { return context; } }
            public List<T> GetAll(string spName)
            {
              return context.Database.SqlQuery<T>(spName).ToList();         
            }

            public void ExecuteStoredProcedure(string spName, object[] parmList)
            {
                  context.Database.ExecuteSqlCommand(spName, parmList);

            }
            public void ExecuteStoredProcedure(string spName)
            {
                context.Database.ExecuteSqlCommand(spName);

            }
            public List<T> GetAll()
            {
                return dbSet.ToList();
            }

            public  T Get(Guid id)
            {
                return dbSet.Find(id);
            }

            public void Create(T entity)
            {
                try
                {
                    dbSet.Add(entity);
                }
                catch(Exception ex)
                {

                }
            }

            public void SaveChanges()
            {
                context.SaveChanges();
            }
        }
    }
