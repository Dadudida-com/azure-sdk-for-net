// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing the BatchPrivateEndpointConnection data model.
    /// Contains information about a private link resource.
    /// </summary>
    public partial class BatchPrivateEndpointConnectionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="BatchPrivateEndpointConnectionData"/>. </summary>
        public BatchPrivateEndpointConnectionData()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection. </param>
        /// <param name="privateEndpoint"> The private endpoint of the private endpoint connection. </param>
        /// <param name="groupIds"> The value has one and only one group id. </param>
        /// <param name="connectionState"> The private link service connection state of the private endpoint connection. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BatchPrivateEndpointConnectionProvisioningState? provisioningState, SubResource privateEndpoint, IReadOnlyList<string> groupIds, BatchPrivateLinkServiceConnectionState connectionState, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            ConnectionState = connectionState;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the private endpoint connection. </summary>
        public BatchPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
        /// <summary> The private endpoint of the private endpoint connection. </summary>
        internal SubResource PrivateEndpoint { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> The value has one and only one group id. </summary>
        public IReadOnlyList<string> GroupIds { get; }
        /// <summary> The private link service connection state of the private endpoint connection. </summary>
        public BatchPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
