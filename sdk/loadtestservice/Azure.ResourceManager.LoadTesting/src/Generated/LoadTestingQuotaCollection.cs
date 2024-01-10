// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTesting
{
    /// <summary>
    /// A class representing a collection of <see cref="LoadTestingQuotaResource"/> and their operations.
    /// Each <see cref="LoadTestingQuotaResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="LoadTestingQuotaCollection"/> instance call the GetLoadTestingQuota method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class LoadTestingQuotaCollection : ArmCollection, IEnumerable<LoadTestingQuotaResource>, IAsyncEnumerable<LoadTestingQuotaResource>
    {
        private readonly ClientDiagnostics _loadTestingQuotaQuotasClientDiagnostics;
        private readonly QuotasRestOperations _loadTestingQuotaQuotasRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="LoadTestingQuotaCollection"/> class for mocking. </summary>
        protected LoadTestingQuotaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadTestingQuotaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The name of Azure region. </param>
        internal LoadTestingQuotaCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _loadTestingQuotaQuotasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LoadTesting", LoadTestingQuotaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LoadTestingQuotaResource.ResourceType, out string loadTestingQuotaQuotasApiVersion);
            _loadTestingQuotaQuotasRestClient = new QuotasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadTestingQuotaQuotasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        public virtual async Task<Response<LoadTestingQuotaResource>> GetAsync(string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaBucketName, nameof(quotaBucketName));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadTestingQuotaQuotasRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), quotaBucketName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        public virtual Response<LoadTestingQuotaResource> Get(string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaBucketName, nameof(quotaBucketName));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = _loadTestingQuotaQuotasRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), quotaBucketName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the available quota per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadTestingQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadTestingQuotaResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadTestingQuotaQuotasRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadTestingQuotaQuotasRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LoadTestingQuotaResource(Client, LoadTestingQuotaData.DeserializeLoadTestingQuotaData(e)), _loadTestingQuotaQuotasClientDiagnostics, Pipeline, "LoadTestingQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available quota per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadTestingQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadTestingQuotaResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadTestingQuotaQuotasRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadTestingQuotaQuotasRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LoadTestingQuotaResource(Client, LoadTestingQuotaData.DeserializeLoadTestingQuotaData(e)), _loadTestingQuotaQuotasClientDiagnostics, Pipeline, "LoadTestingQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaBucketName, nameof(quotaBucketName));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _loadTestingQuotaQuotasRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), quotaBucketName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        public virtual Response<bool> Exists(string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaBucketName, nameof(quotaBucketName));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = _loadTestingQuotaQuotasRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), quotaBucketName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        public virtual async Task<NullableResponse<LoadTestingQuotaResource>> GetIfExistsAsync(string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaBucketName, nameof(quotaBucketName));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _loadTestingQuotaQuotasRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), quotaBucketName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LoadTestingQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new LoadTestingQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaBucketName"/> is null. </exception>
        public virtual NullableResponse<LoadTestingQuotaResource> GetIfExists(string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaBucketName, nameof(quotaBucketName));

            using var scope = _loadTestingQuotaQuotasClientDiagnostics.CreateScope("LoadTestingQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadTestingQuotaQuotasRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), quotaBucketName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LoadTestingQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new LoadTestingQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LoadTestingQuotaResource> IEnumerable<LoadTestingQuotaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LoadTestingQuotaResource> IAsyncEnumerable<LoadTestingQuotaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
