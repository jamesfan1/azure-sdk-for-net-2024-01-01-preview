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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing a LoadBalancingRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="LoadBalancingRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetLoadBalancingRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="LoadBalancerResource"/> using the GetLoadBalancingRule method.
    /// </summary>
    public partial class LoadBalancingRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LoadBalancingRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="loadBalancerName"> The loadBalancerName. </param>
        /// <param name="loadBalancingRuleName"> The loadBalancingRuleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string loadBalancerName, string loadBalancingRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics;
        private readonly LoadBalancerLoadBalancingRulesRestOperations _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient;
        private readonly LoadBalancingRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/loadBalancers/loadBalancingRules";

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleResource"/> class for mocking. </summary>
        protected LoadBalancingRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LoadBalancingRuleResource(ArmClient client, LoadBalancingRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LoadBalancingRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string loadBalancingRuleLoadBalancerLoadBalancingRulesApiVersion);
            _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient = new LoadBalancerLoadBalancingRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadBalancingRuleLoadBalancerLoadBalancingRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LoadBalancingRuleData Data
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
        /// Gets the specified load balancer load balancing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LoadBalancingRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified load balancer load balancing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LoadBalancingRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleResource.Get");
            scope.Start();
            try
            {
                var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
