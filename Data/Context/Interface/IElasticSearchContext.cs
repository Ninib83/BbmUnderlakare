using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nest;

namespace BbmUnderlakare.Data.Context.Interface
{
    public interface IElasticSearchContext<T> where T : class
    {
        string Index { get; }
        IElasticClient GetClient();
    }
}