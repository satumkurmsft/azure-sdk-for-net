// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="StaticSiteCustomDomainOverviewARMResource" /> and their operations.
    /// Each <see cref="StaticSiteCustomDomainOverviewARMResource" /> in the collection will belong to the same instance of <see cref="StaticSiteARMResource" />.
    /// To get a <see cref="StaticSiteCustomDomainOverviewARMCollection" /> instance call the GetStaticSiteCustomDomainOverviewARMs method from an instance of <see cref="StaticSiteARMResource" />.
    /// </summary>
    public partial class StaticSiteCustomDomainOverviewARMCollection : ArmCollection, IEnumerable<StaticSiteCustomDomainOverviewARMResource>, IAsyncEnumerable<StaticSiteCustomDomainOverviewARMResource>
    {
        private readonly ClientDiagnostics _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteCustomDomainOverviewARMStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewARMCollection"/> class for mocking. </summary>
        protected StaticSiteCustomDomainOverviewARMCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewARMCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewARMCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteCustomDomainOverviewARMResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteCustomDomainOverviewARMResource.ResourceType, out string staticSiteCustomDomainOverviewARMStaticSitesApiVersion);
            _staticSiteCustomDomainOverviewARMStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteCustomDomainOverviewARMStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteARMResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteARMResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteCustomDomain
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The custom domain to create. </param>
        /// <param name="staticSiteCustomDomainRequestPropertiesEnvelope"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="staticSiteCustomDomainRequestPropertiesEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteCustomDomainOverviewARMResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainName, StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(staticSiteCustomDomainRequestPropertiesEnvelope, nameof(staticSiteCustomDomainRequestPropertiesEnvelope));

            using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewARMStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewARMResource>(new StaticSiteCustomDomainOverviewARMOperationSource(Client), _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewARMStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a new static site custom domain in an existing resource group and static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_CreateOrUpdateStaticSiteCustomDomain
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The custom domain to create. </param>
        /// <param name="staticSiteCustomDomainRequestPropertiesEnvelope"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="staticSiteCustomDomainRequestPropertiesEnvelope"/> is null. </exception>
        public virtual ArmOperation<StaticSiteCustomDomainOverviewARMResource> CreateOrUpdate(WaitUntil waitUntil, string domainName, StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(staticSiteCustomDomainRequestPropertiesEnvelope, nameof(staticSiteCustomDomainRequestPropertiesEnvelope));

            using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewARMStaticSitesRestClient.CreateOrUpdateStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteCustomDomainOverviewARMResource>(new StaticSiteCustomDomainOverviewARMOperationSource(Client), _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics, Pipeline, _staticSiteCustomDomainOverviewARMStaticSitesRestClient.CreateCreateOrUpdateStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, staticSiteCustomDomainRequestPropertiesEnvelope).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an existing custom domain for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteCustomDomainOverviewARMResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewARMStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an existing custom domain for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<StaticSiteCustomDomainOverviewARMResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewARMStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all static site custom domains for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains
        /// Operation Id: StaticSites_ListStaticSiteCustomDomains
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteCustomDomainOverviewARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteCustomDomainOverviewARMResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteCustomDomainOverviewARMResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteCustomDomainOverviewARMStaticSitesRestClient.ListStaticSiteCustomDomainsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteCustomDomainOverviewARMResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteCustomDomainOverviewARMStaticSitesRestClient.ListStaticSiteCustomDomainsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Gets all static site custom domains for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains
        /// Operation Id: StaticSites_ListStaticSiteCustomDomains
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteCustomDomainOverviewARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteCustomDomainOverviewARMResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteCustomDomainOverviewARMResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteCustomDomainOverviewARMStaticSitesRestClient.ListStaticSiteCustomDomains(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteCustomDomainOverviewARMResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteCustomDomainOverviewARMStaticSitesRestClient.ListStaticSiteCustomDomainsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteCustomDomainOverviewARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteCustomDomainOverviewARMStaticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// Operation Id: StaticSites_GetStaticSiteCustomDomain
        /// </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _staticSiteCustomDomainOverviewARMStaticSitesClientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteCustomDomainOverviewARMStaticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteCustomDomainOverviewARMResource> IEnumerable<StaticSiteCustomDomainOverviewARMResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteCustomDomainOverviewARMResource> IAsyncEnumerable<StaticSiteCustomDomainOverviewARMResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
