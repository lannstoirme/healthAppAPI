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
        public class User
        {
           
                [BsonId]
                [BsonRepresentation(BsonType.ObjectId)]
                public string Id { get; set; }

                [BsonElement("fname")]
                public string Fname { get; set; }

                [BsonElement("lname")]
                public string Lname { get; set; }

                [BsonElement("dob")]
                public string Dob { get; set; }

            
        }
}
