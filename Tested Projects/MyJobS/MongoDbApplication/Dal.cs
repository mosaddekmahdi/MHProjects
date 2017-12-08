using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System.Configuration;

namespace MongoDbApplication
{
    public class Dal : IDisposable
    {
        private MongoServer mongoServer = null;
        private bool disposed = false;

        // To do: update the connection string with the DNS name
        // or IP address of your server. 
        //For example, "mongodb://testlinux.cloudapp.net"
        private string connectionString = "mongodb://localhost/?safe=true";

        // This sample uses a database named "Tasks" and a ;
        //collection named "TasksList".  The database and collection 
        //will be automatically created if they don't already exist.
        private string dbName = "Tasks";
        private string collectionName = "TasksList";

        // Default constructor.        
        public Dal()
        {
        }

        // Gets all Task items from the MongoDB server.        
        public List<Task> GetAllTasks()
        {
            try
            {
                MongoCollection<Task> collection = GetTasksCollection();
                return collection.FindAll().ToList<Task>();
            }
            catch (MongoConnectionException)
            {
                return new List<Task>();
            }
        }
        public void DeleteTask(string id) 
        {
            MongoCollection<Task> collection = GetTasksCollectionForEdit();
            Guid i = new Guid(id.Replace("\"", ""));
            var query = Query.EQ("_id", i);
            collection.Remove(query);
            
        }
        public Task GetTask(string id)
        {
            MongoCollection<Task> collection = GetTasksCollectionForEdit();
            Guid i = new Guid(id.Replace("\"", ""));
            var query = Query.EQ("_id", i);
            var task = collection.FindOne(query);

            return task;
        }
        
                 public void EditTask(Task t) 
        {
            MongoCollection<Task> collection = GetTasksCollectionForEdit();
        
    
            collection.Save(t);

         
        }

        // Creates a Task and inserts it into the collection in MongoDB.
        public void CreateTask(Task task)
        {
            MongoCollection<Task> collection = GetTasksCollectionForEdit();
            try
            {
                collection.Insert(task);
            }
            catch (MongoCommandException ex)
            {
                string msg = ex.Message;
            }
        }

        private MongoCollection<Task> GetTasksCollection()
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<Task> todoTaskCollection = database.GetCollection<Task>(collectionName);
            return todoTaskCollection;
        }
        private void Clean()
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<Task> todoTaskCollection = database.GetCollection<Task>(collectionName);
            todoTaskCollection.RemoveAll();
        }
        private MongoCollection<Task> GetTasksCollectionForEdit()
        {
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase database = server[dbName];
            MongoCollection<Task> todoTaskCollection = database.GetCollection<Task>(collectionName);
            return todoTaskCollection;
        }

        # region IDisposable

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (mongoServer != null)
                    {
                        this.mongoServer.Disconnect();
                    }
                }
            }

            this.disposed = true;
        }

        # endregion

        internal List<Task> SearchByTask(Task t)
        {
            MongoCollection<Task> collection = GetTasksCollectionForEdit();
            

            var ttt = (from p in collection.AsQueryable()
                       where p.JobTitle.ToUpper().Contains(t.JobTitle.ToUpper()) && p.JobCategory == t.JobCategory
                       select new
                       {
                           p.Id,
                           p.JobTitle,
                           p.Institution,
                           p.JobCategory,
                           p.DatePosted, 
                           p.DataEntered,
                           p.Deadline, 
                           p.SourceURL, 
                           p.Notes});
            
            List<Task> l = new List<Task>();
            foreach(var t2 in ttt)
            {

                l.Add(new Task {Id = t2.Id, JobTitle = t2.JobTitle, Institution = t2.Institution, JobCategory = t2.JobCategory, DatePosted = t2.DatePosted, DataEntered = t2.DataEntered, Deadline = t2.Deadline, SourceURL = t2.SourceURL, Notes = t2.Notes });
            }
return l;
        }
    }
}


