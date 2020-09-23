using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace HealthApp.Models
{
    public class Vitals
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("date")]
        public string Date { get; set; }

        [BsonElement("time")]
        public string Time { get; set; }

        [BsonElement("pulserate")]
        public string Pulserate { get; set; }

        [BsonElement("oxygensat")]
        public string Oxygensat { get; set; }

        [BsonElement("temperature")]
        public string Temperature { get; set; }

        [BsonElement("systolicpressure")]
        public string Systolicpressure { get; set; }

        [BsonElement("diastolicpressure")]
        public string Diastolicpressure { get; set; }

    }
}
