// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A Class representing an OSOptionProfile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="OSOptionProfileResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetOSOptionProfileResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetOSOptionProfile method.
    /// </summary>
    public partial class OSOptionProfileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="OSOptionProfileResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/osOptions/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _osOptionProfileManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _osOptionProfileManagedClustersRestClient;
        private readonly OSOptionProfileData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/locations/osOptions";

        /// <summary> Initializes a new instance of the <see cref="OSOptionProfileResource"/> class for mocking. </summary>
        protected OSOptionProfileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OSOptionProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal OSOptionProfileResource(ArmClient client, OSOptionProfileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="OSOptionProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OSOptionProfileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _osOptionProfileManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string osOptionProfileManagedClustersApiVersion);
            _osOptionProfileManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, osOptionProfileManagedClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual OSOptionProfileData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets supported OS options in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/osOptions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetOSOptions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OSOptionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type for which the OS options needs to be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OSOptionProfileResource>> GetAsync(ResourceType? resourceType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _osOptionProfileManagedClustersClientDiagnostics.CreateScope("OSOptionProfileResource.Get");
            scope.Start();
            try
            {
                var response = await _osOptionProfileManagedClustersRestClient.GetOSOptionsAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), resourceType, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSOptionProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets supported OS options in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/osOptions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetOSOptions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OSOptionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type for which the OS options needs to be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OSOptionProfileResource> Get(ResourceType? resourceType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _osOptionProfileManagedClustersClientDiagnostics.CreateScope("OSOptionProfileResource.Get");
            scope.Start();
            try
            {
                var response = _osOptionProfileManagedClustersRestClient.GetOSOptions(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), resourceType, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSOptionProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
