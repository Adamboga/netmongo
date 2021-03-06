﻿using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace netmongo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ppl");
            var collection = database.GetCollection<BsonDocument>("info");

            var info = new BsonDocument{
                { "name", "Adam1"},
                { "age", "38"},
                { "sex", "Male"}
            };
        collection.InsertOne(info);
         }
    }
}
