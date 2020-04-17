using CommonStandard.Interface.Repository;
using Couchbase.Lite;
using Newtonsoft.Json;
using System;

namespace CommonStandard.Repository
{
    public class CouchbaseJsonRepository<T> : IRepository<T, string>
    {
        protected readonly Database _database;

        public CouchbaseJsonRepository(
            Database database
            )
        {
            _database = database;
        }

        public T Get(string key)
        {
            T result = default(T);

            var document = _database.GetDocument(key);
            if (document == null) return result;

            var json = document.GetString("json");
            if (json == null) return result;

            result = JsonConvert.DeserializeObject<T>(json);
            return result;
        }

        public bool Set(string key, T value)
        {
            try
            {
                string json = JsonConvert.SerializeObject(value);
                MutableDocument document = new MutableDocument(key);
                document.SetString("json", json);
                _database.Save(document);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
