// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LoadTesting.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LoadTesting
{
    /// <summary>
    /// A class representing the LoadTestingResource data model.
    /// LoadTest details
    /// </summary>
    public partial class LoadTestingResourceData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LoadTestingResourceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public LoadTestingResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadTestingResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The type of identity used for the resource. </param>
        /// <param name="description"> Description of the resource. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="dataPlaneUri"> Resource data plane URI. </param>
        /// <param name="encryption"> CMK Encryption property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadTestingResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string description, LoadTestingProvisioningState? provisioningState, string dataPlaneUri, LoadTestingCmkEncryptionProperties encryption, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Description = description;
            ProvisioningState = provisioningState;
            DataPlaneUri = dataPlaneUri;
            Encryption = encryption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LoadTestingResourceData"/> for deserialization. </summary>
        internal LoadTestingResourceData()
        {
        }

        /// <summary> The type of identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Description of the resource. </summary>
        public string Description { get; set; }
        /// <summary> Resource provisioning state. </summary>
        public LoadTestingProvisioningState? ProvisioningState { get; }
        /// <summary> Resource data plane URI. </summary>
        public string DataPlaneUri { get; }
        /// <summary> CMK Encryption property. </summary>
        public LoadTestingCmkEncryptionProperties Encryption { get; set; }
    }
}
