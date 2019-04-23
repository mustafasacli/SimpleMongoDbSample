using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBConsoleSample1
{
    public class Knowledge
    {
        ////[BsonElement("langu_name")]
        public string Language
        { get; set; }

        ////[BsonElement("technology")]
        public string Technology
        { get; set; }

        ////[BsonElement("rating")]
        public ushort Rating
        { get; set; }
    }
}
