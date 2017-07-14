using Elasticsearch.Net;
using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Converters
{
    public static class ElasticSearchSettings
    {
        public static List<JsonConverter> Converters = new List<JsonConverter>();

        public static void AddConverter<TInterface, TConcrete>()
        {
            Converters.Add(new ConcreteTypeConverter<TInterface, TConcrete>());
        }

        public static ConnectionSettings GetDefaultConnectionSettings()
        {
            var url = ConfigurationManager.AppSettings["ElasticSearchUrl"];

            if (string.IsNullOrWhiteSpace(url))
            {
                throw new NullReferenceException("\"ElasticSearchUrl\" must exist in appsettings");
            }

            var pool = new SingleNodeConnectionPool(new Uri(url));

            var settings = new ConnectionSettings(pool, new HttpConnection(),
                new SerializerFactory((jsonSettings, nestSettings) =>
                {
                    jsonSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    foreach (var converter in Converters)
                    {
                        jsonSettings.Converters.Add(converter);
                    }
                }));

            var user = ConfigurationManager.AppSettings["ElasticSearchUser"];
            var password = ConfigurationManager.AppSettings["ElasticSearchPassword"];
            if (!string.IsNullOrWhiteSpace(user))
            {
                settings.BasicAuthentication(user, password);
            }

            return settings;
        }
    }
}