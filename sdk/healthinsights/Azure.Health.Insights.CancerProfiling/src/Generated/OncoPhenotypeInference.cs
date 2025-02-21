// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> An inference made by the Onco Phenotype model regarding a patient. </summary>
    public partial class OncoPhenotypeInference
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

        /// <summary> Initializes a new instance of <see cref="OncoPhenotypeInference"/>. </summary>
        /// <param name="type"> The type of the Onco Phenotype inference. </param>
        /// <param name="value"> The value of the inference, as relevant for the given inference type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal OncoPhenotypeInference(OncoPhenotypeInferenceType type, string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Type = type;
            Value = value;
            Evidence = new ChangeTrackingList<InferenceEvidence>();
        }

        /// <summary> Initializes a new instance of <see cref="OncoPhenotypeInference"/>. </summary>
        /// <param name="type"> The type of the Onco Phenotype inference. </param>
        /// <param name="value"> The value of the inference, as relevant for the given inference type. </param>
        /// <param name="description"> The description corresponding to the inference value. </param>
        /// <param name="confidenceScore"> Confidence score for this inference. </param>
        /// <param name="evidence"> The evidence corresponding to the inference value. </param>
        /// <param name="caseId"> An identifier for a clinical case, if there are multiple clinical cases regarding the same patient. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OncoPhenotypeInference(OncoPhenotypeInferenceType type, string value, string description, float? confidenceScore, IReadOnlyList<InferenceEvidence> evidence, string caseId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Value = value;
            Description = description;
            ConfidenceScore = confidenceScore;
            Evidence = evidence;
            CaseId = caseId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OncoPhenotypeInference"/> for deserialization. </summary>
        internal OncoPhenotypeInference()
        {
        }

        /// <summary> The type of the Onco Phenotype inference. </summary>
        public OncoPhenotypeInferenceType Type { get; }
        /// <summary> The value of the inference, as relevant for the given inference type. </summary>
        public string Value { get; }
        /// <summary> The description corresponding to the inference value. </summary>
        public string Description { get; }
        /// <summary> Confidence score for this inference. </summary>
        public float? ConfidenceScore { get; }
        /// <summary> The evidence corresponding to the inference value. </summary>
        public IReadOnlyList<InferenceEvidence> Evidence { get; }
        /// <summary> An identifier for a clinical case, if there are multiple clinical cases regarding the same patient. </summary>
        public string CaseId { get; }
    }
}
