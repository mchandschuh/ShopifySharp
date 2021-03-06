﻿using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a Shopify product's variants.
    /// </summary>
    public class ShopifyProductVariantService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyProductVariantService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyProductVariantService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        public async Task<int> CountAsync(long productId)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants/count.json", Method.GET, "count");            

            return await RequestEngine.ExecuteRequestAsync<int>(_RestClient, req);
        }

        /// <summary>
        /// Gets a list of variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        /// <param name="filterOptions">Options for filtering the result.</param>
        public async Task<IEnumerable<ShopifyProductVariant>> ListAsync(long productId, ShopifyListFilter filterOptions = null)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants.json", Method.GET, "variants");

            if (filterOptions != null)
            {
                req.Parameters.AddRange(filterOptions.ToParameters(ParameterType.GetOrPost));
            }
            
            return await RequestEngine.ExecuteRequestAsync<List<ShopifyProductVariant>>(_RestClient, req);
        }
        
        /// <summary>
        /// Retrieves the <see cref="ShopifyProductVariant"/> with the given id.
        /// </summary>
        /// <param name="variantId">The id of the product variant to retrieve.</param>
        public async Task<ShopifyProductVariant> GetAsync(long variantId)
        {
            var req = RequestEngine.CreateRequest($"variants/{variantId}.json", Method.GET, "variant");
            
            return await RequestEngine.ExecuteRequestAsync<ShopifyProductVariant>(_RestClient, req);
        }
        
        /// <summary>
        /// Creates a new <see cref="ShopifyProductVariant"/>.
        /// </summary>
        /// <param name="productId">The product that the new variant will belong to.</param>
        /// <param name="variant">A new <see cref="ShopifyProductVariant"/>. Id should be set to null.</param>
        public async Task<ShopifyProductVariant> CreateAsync(long productId, ShopifyProductVariant variant)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants.json", Method.POST, "variant");

            req.AddJsonBody(new { variant });
            
            return await RequestEngine.ExecuteRequestAsync<ShopifyProductVariant>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyProductVariant"/>. Id must not be null.
        /// </summary>
        /// <param name="variant">The variant to update.</param>
        public async Task<ShopifyProductVariant> UpdateAsync(ShopifyProductVariant variant)
        {
            var req = RequestEngine.CreateRequest($"variants/{variant.Id.Value}.json", Method.PUT, "variant");

            req.AddJsonBody(new { variant });

            return await RequestEngine.ExecuteRequestAsync<ShopifyProductVariant>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a product variant with the given Id.
        /// </summary>
        /// <param name="productId">The product that the variant belongs to.</param>
        /// <param name="variantId">The product variant's id.</param>
        public async Task DeleteAsync(long productId, long variantId)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants/{variantId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }
    }
}
