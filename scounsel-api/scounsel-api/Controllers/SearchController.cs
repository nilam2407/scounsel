using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using scounsel_api.Features.courses.Queries.GetAllCourses;
using scounsel_api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using scounsel_api.Mappings;
using System.Threading;
using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Spatial;

namespace scounsel_api.Controllers
{
    /*
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : Controller
    {
        
        IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
        IConfigurationRoot configuration = builder.Build();

        SearchServiceClient serviceClient = CreateSearchServiceClient(configuration);

        string indexName = configuration["SearchIndexName"];

        Console.WriteLine("{0}", "Deleting index...\n");
        DeleteIndexIfExists(indexName, serviceClient);

        Console.WriteLine("{0}", "Creating index...\n");
        CreateIndex(indexName, serviceClient);

        ISearchIndexClient indexClient = serviceClient.Indexes.GetClient(indexName);
    

        private static SearchServiceClient CreateSearchServiceClient(IConfigurationRoot configuration)
        {
            string searchServiceName = configuration["SearchServiceName"];
            string adminApiKey = configuration["SearchServiceAdminApiKey"];

            SearchServiceClient serviceClient = new SearchServiceClient(searchServiceName, new SearchCredentials(adminApiKey));
            return serviceClient;
        }

        private static SearchIndexClient CreateSearchIndexClient(string indexName, IConfigurationRoot configuration)
        {
            string searchServiceName = configuration["SearchServiceName"];
            string queryApiKey = configuration["SearchServiceQueryApiKey"];

            SearchIndexClient indexClient = new SearchIndexClient(searchServiceName, indexName, new SearchCredentials(queryApiKey));
            return indexClient;
        }

        private static void DeleteIndexIfExists(string indexName, SearchServiceClient serviceClient)
        {
            if (serviceClient.Indexes.Exists(indexName))
            {
                serviceClient.Indexes.Delete(indexName);
            }
        }

        private static void CreateIndex(string indexName, SearchServiceClient serviceClient)
        {
            var definition = new Index()
            {
                Name = indexName,
                Fields = FieldBuilder.BuildForType<Course>()
            };
    
            serviceClient.Indexes.Create(definition);
        }
        
    }
    */
}