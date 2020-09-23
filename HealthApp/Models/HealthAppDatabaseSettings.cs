using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApp.Models
{
    public class HealthAppDatabaseSettings : IHealthAppDatabaseSettings
    {
        public string UserCollectionsName { get; set; }
        public string VitalsCollectionsName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IHealthAppDatabaseSettings
    {
        string UserCollectionsName { get; set; }
        string VitalsCollectionsName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

    }
}

