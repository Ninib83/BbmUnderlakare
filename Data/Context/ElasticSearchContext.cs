using BbmUnderlakare.Data.Context.Interface;
using BbmUnderlakare.Data.Converters;
using Nest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Context
{
    public class ElasticSearchContext<T> : IElasticSearchContext<T> where T : class
    {
        private string _index;
        public string Index
        {
            get
            {
                if (_index == null)
                {
                    var key = $"ElasticSearch{typeof(T).Name}Index";
                    var indexName = ConfigurationManager.AppSettings[key];
                    if (string.IsNullOrWhiteSpace(indexName))
                    {
                        throw new NullReferenceException($"\"{key}\" must exist in appsettings");
                    }
                    _index = indexName;
                }

                return _index;
            }
        }

        private IElasticClient _client;
        public IElasticClient GetClient()
        {
            if (_client == null)
            {
                var connectionSettings = ElasticSearchSettings.GetDefaultConnectionSettings()
                    .DefaultIndex(Index)
                    .InferMappingFor<T>(m => m
                        .TypeName(typeof(T).Name));

                _client = new ElasticClient(connectionSettings);
            }
            return _client;
        }

    }
}
