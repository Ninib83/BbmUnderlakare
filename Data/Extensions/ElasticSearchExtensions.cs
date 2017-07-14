using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Extensions
{
    public static class ElasticSearchExtensions
    {
        public static void Validate(this IResponse response)
        {
            if (!response.IsValid)
            {
                if (response.OriginalException != null)
                {
                    throw response.OriginalException;
                }

                throw new Exception($"Elastic search exception: {response.ServerError}");
            }
        }
    }
}