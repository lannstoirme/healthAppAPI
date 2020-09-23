using System;
using HealthApp.Models;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using HealthApp.Controllers;
using Microsoft.AspNetCore.Routing;


namespace HealthApp.Services
{
    public class VitalService
    {
        private readonly IMongoCollection<Vitals> _vitals;

        public VitalService(IHealthAppDatabaseSettings settings)
        {


            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _vitals = database.GetCollection<Vitals>(settings.VitalsCollectionsName);
        }

        public List<Vitals> Get() =>
            _vitals.Find(vitals => true).ToList();

        public Vitals Get(string id) =>
            _vitals.Find<Vitals>(vitals => vitals.Id == id).FirstOrDefault();

        public Vitals Create(Vitals vitals)
        {
            _vitals.InsertOne(vitals);
            return vitals;
        }

        public void Update(string id, Vitals vitalsIn) =>
            _vitals.ReplaceOne(vitals => vitals.Id == id, vitalsIn);

        public void Remove(Vitals vitalsIn) =>
            _vitals.DeleteOne(vitals => vitals.Id == vitalsIn.Id);

        public void Remove(string id) =>
            _vitals.DeleteOne(vitals => vitals.Id == id);
    }

}
