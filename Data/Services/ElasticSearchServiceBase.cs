using BbmUnderlakare.Data.Context.Interface;
using BbmUnderlakare.Data.Services.Interfaces;
using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Nest;
using BbmUnderlakare.Data.Extensions;

namespace BbmUnderlakare.Data.Services
{
    public class ElasticSearchServiceBase<T> : IElasticSearchService<T> where T : class
    {
        private readonly IElasticSearchContext<T> _context;
        protected IElasticClient Client => _context.GetClient();
        protected string Index => _context.Index;

        public ElasticSearchServiceBase(IElasticSearchContext<T> context)
        {
            _context = context;
        }

        public virtual void ReCreateIndex()
        {
            var indexExists = Client.IndexExists(Index);
            if (indexExists.Exists)
            {
                Client.DeleteIndex(Index);
            }

            var response = Client.CreateIndex(Index, x => x
                .Mappings(m => m
                    .Map<T>(mm => mm
                        .AutoMap()
                    )
                )
            );

            response.Validate();
        }

        public virtual ISearchResponse<T> Search(Func<SearchDescriptor<T>, ISearchRequest> selector)
        {
            var result = Client.Search(selector);

            result.Validate();

            return result;
        }

        public virtual async Task<string> AddToIndexAsync(T obj, Refresh refresh)
        {
            var createdResponse = await Client.IndexAsync(obj, x => x.Refresh(refresh));

            createdResponse.Validate();

            return createdResponse.Id;
        }

        public virtual string AddToIndex(T obj, Refresh refresh)
        {
            var createdResponse = Client.Index(obj, x => x.Refresh(refresh));

            createdResponse.Validate();

            return createdResponse.Id;
        }

        public virtual void RefreshIndex()
        {
            var response = Client.Refresh(Index);

            response.Validate();
        }

        public virtual string Upsert(string id, T obj)
        {
            var response = Client.Update(DocumentPath<T>.Id(id), x => x.Doc(obj).DocAsUpsert());
            response.Validate();
            return response.Id;
        }
    }
}