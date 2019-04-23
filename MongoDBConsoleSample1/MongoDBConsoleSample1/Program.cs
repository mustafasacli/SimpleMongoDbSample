using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace MongoDBConsoleSample1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new MongoDB.Driver.MongoClient(ConfigurationManager.ConnectionStrings["MstMongoDB"].ConnectionString);
            var collection = client.GetDatabase("mst2").GetCollection<Developer>("developer");

            var docCount = collection.CountDocuments(FilterDefinition<Developer>.Empty);
            Console.WriteLine(string.Format("Element Count(Before) : {0}", docCount));

            var dev = new Developer
            {
                CompanyName = "ZD",
                Name = "Mustafa Saçlı",
                KnowledgeBase = new List<Knowledge> {
                    new Knowledge { Language = "C#", Rating = 4, Technology = "Net" },
                    new Knowledge { Language = "Java", Rating = 2, Technology = "Oracle" } }
            };
            collection.InsertOne(dev);

            docCount = collection.CountDocuments(FilterDefinition<Developer>.Empty);
            Console.WriteLine(string.Format("Element Count(After) : {0}", docCount));

            Console.ReadKey();
        }
    }
}