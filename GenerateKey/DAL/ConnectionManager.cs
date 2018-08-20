using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace GenerateKey.DAL
{
    public class ConnectionManager
    {
        private DocumentClient client;
        //TODO: read below properties from appsettings.json
        private const string EndpointUrl = "<your endpoint URL>";
        private const string PrimaryKey = "<your primary key>";
        private const string DBName = "<someDBName>";
        public ConnectionManager()
        {
            //intialize Cosmos DB objects here
            client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
            client.CreateDatabaseIfNotExistsAsync(new Database { Id = DBName });
        }
        public bool SaveWorkOrderAsync()
        {
            return false;
        }
    }
}
