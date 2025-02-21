// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> TagResource contract properties. </summary>
    public partial class TagResourceContractDetails
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

        /// <summary> Initializes a new instance of <see cref="TagResourceContractDetails"/>. </summary>
        /// <param name="tag"> Tag associated with the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tag"/> is null. </exception>
        internal TagResourceContractDetails(AssociatedTagProperties tag)
        {
            Argument.AssertNotNull(tag, nameof(tag));

            Tag = tag;
        }

        /// <summary> Initializes a new instance of <see cref="TagResourceContractDetails"/>. </summary>
        /// <param name="tag"> Tag associated with the resource. </param>
        /// <param name="api"> API associated with the tag. </param>
        /// <param name="operation"> Operation associated with the tag. </param>
        /// <param name="product"> Product associated with the tag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TagResourceContractDetails(AssociatedTagProperties tag, AssociatedApiProperties api, AssociatedOperationProperties operation, AssociatedProductProperties product, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tag = tag;
            Api = api;
            Operation = operation;
            Product = product;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TagResourceContractDetails"/> for deserialization. </summary>
        internal TagResourceContractDetails()
        {
        }

        /// <summary> Tag associated with the resource. </summary>
        public AssociatedTagProperties Tag { get; }
        /// <summary> API associated with the tag. </summary>
        public AssociatedApiProperties Api { get; }
        /// <summary> Operation associated with the tag. </summary>
        public AssociatedOperationProperties Operation { get; }
        /// <summary> Product associated with the tag. </summary>
        public AssociatedProductProperties Product { get; }
    }
}
