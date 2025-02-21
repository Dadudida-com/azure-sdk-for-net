// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Copy log details for a storage account for Databox heavy. </summary>
    public partial class DataBoxHeavyAccountCopyLogDetails : CopyLogDetails
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxHeavyAccountCopyLogDetails"/>. </summary>
        internal DataBoxHeavyAccountCopyLogDetails()
        {
            CopyLogLink = new ChangeTrackingList<string>();
            CopyVerboseLogLink = new ChangeTrackingList<string>();
            CopyLogDetailsType = DataBoxOrderType.DataBoxHeavy;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxHeavyAccountCopyLogDetails"/>. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="copyLogLink"> Link for copy logs. </param>
        /// <param name="copyVerboseLogLink"> Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose. </param>
        internal DataBoxHeavyAccountCopyLogDetails(DataBoxOrderType copyLogDetailsType, IDictionary<string, BinaryData> serializedAdditionalRawData, string accountName, IReadOnlyList<string> copyLogLink, IReadOnlyList<string> copyVerboseLogLink) : base(copyLogDetailsType, serializedAdditionalRawData)
        {
            AccountName = accountName;
            CopyLogLink = copyLogLink;
            CopyVerboseLogLink = copyVerboseLogLink;
            CopyLogDetailsType = copyLogDetailsType;
        }

        /// <summary> Account name. </summary>
        public string AccountName { get; }
        /// <summary> Link for copy logs. </summary>
        public IReadOnlyList<string> CopyLogLink { get; }
        /// <summary> Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose. </summary>
        public IReadOnlyList<string> CopyVerboseLogLink { get; }
    }
}
