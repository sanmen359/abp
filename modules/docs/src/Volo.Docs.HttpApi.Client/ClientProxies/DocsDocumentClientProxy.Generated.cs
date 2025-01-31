// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Docs.Documents;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Volo.Docs.Documents.ClientProxies
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IDocumentAppService), typeof(DocsDocumentClientProxy))]
    public partial class DocsDocumentClientProxy : ClientProxyBase<IDocumentAppService>, IDocumentAppService
    {
        public virtual async Task<DocumentWithDetailsDto> GetAsync(GetDocumentInput input)
        {
            return await RequestAsync<DocumentWithDetailsDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
            {
                { typeof(GetDocumentInput), input }
            });
        }

        public virtual async Task<DocumentWithDetailsDto> GetDefaultAsync(GetDefaultDocumentInput input)
        {
            return await RequestAsync<DocumentWithDetailsDto>(nameof(GetDefaultAsync), new ClientProxyRequestTypeValue
            {
                { typeof(GetDefaultDocumentInput), input }
            });
        }

        public virtual async Task<NavigationNode> GetNavigationAsync(GetNavigationDocumentInput input)
        {
            return await RequestAsync<NavigationNode>(nameof(GetNavigationAsync), new ClientProxyRequestTypeValue
            {
                { typeof(GetNavigationDocumentInput), input }
            });
        }

        public virtual async Task<DocumentResourceDto> GetResourceAsync(GetDocumentResourceInput input)
        {
            return await RequestAsync<DocumentResourceDto>(nameof(GetResourceAsync), new ClientProxyRequestTypeValue
            {
                { typeof(GetDocumentResourceInput), input }
            });
        }

        public virtual async Task<List<DocumentSearchOutput>> SearchAsync(DocumentSearchInput input)
        {
            return await RequestAsync<List<DocumentSearchOutput>>(nameof(SearchAsync), new ClientProxyRequestTypeValue
            {
                { typeof(DocumentSearchInput), input }
            });
        }

        public virtual async Task<bool> FullSearchEnabledAsync()
        {
            return await RequestAsync<bool>(nameof(FullSearchEnabledAsync));
        }

        public virtual async Task<List<String>> GetUrlsAsync(string prefix)
        {
            return await RequestAsync<List<String>>(nameof(GetUrlsAsync), new ClientProxyRequestTypeValue
            {
                { typeof(string), prefix }
            });
        }

        public virtual async Task<DocumentParametersDto> GetParametersAsync(GetParametersDocumentInput input)
        {
            return await RequestAsync<DocumentParametersDto>(nameof(GetParametersAsync), new ClientProxyRequestTypeValue
            {
                { typeof(GetParametersDocumentInput), input }
            });
        }
    }
}
