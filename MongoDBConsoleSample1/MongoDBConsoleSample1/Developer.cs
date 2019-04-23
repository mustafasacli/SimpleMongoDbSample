using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongoDBConsoleSample1
{
    public class Developer
    {
        /// [BsonId]
        public int ID { get; set; }
        /* ObjectId */
        ///[BsonElement("name")]
        public string Name { get; set; }

        ////[BsonElement("company_name")]
        public string CompanyName { get; set; }

        private DateTime createdOn = DateTime.Now;

        ////[BsonElement("created_on")]
        public DateTime CreatedOn
        {
            get { return createdOn; }
            set { createdOn = value; }
        }

        ////[BsonElement("created_on_unix")]
        public long CreatedOnUnix { get { return createdOn.Ticks; } }

        ////[BsonElement("knowledge_base")]
        public List<Knowledge> KnowledgeBase { get; set; }
    }
}