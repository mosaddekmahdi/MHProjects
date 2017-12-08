using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;

namespace MongoDbApplication
{
    public class Task 
    {
        [BsonId(IdGenerator = typeof(CombGuidGenerator))]
        public Guid Id { get; set; }

        [BsonElement("JobTitle")]
        public string JobTitle { get; set; }

        [BsonElement("Institution")]
        public string Institution { get; set; }

        [BsonElement("JobCategory")]
        public string JobCategory { get; set; }

        [BsonElement("DatePosted")]
        //public DateTime DatePosted { get; set; }
        public string DatePosted { get; set; }

        [BsonElement("Deadline")]
        public string Deadline { get; set; }

        [BsonElement("DataEntered")]
        public DateTime DataEntered { get; set; }

        
        [BsonElement("SourceURL")]
        public string SourceURL { get; set; }

        [BsonElement("Notes")]
        public string Notes { get; set; }

    }
}