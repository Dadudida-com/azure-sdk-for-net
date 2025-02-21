// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    public partial class AttestationServiceCreationSpecificParams : IUtf8JsonSerializable, IJsonModel<AttestationServiceCreationSpecificParams>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AttestationServiceCreationSpecificParams>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AttestationServiceCreationSpecificParams>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServiceCreationSpecificParams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AttestationServiceCreationSpecificParams)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(PolicySigningCertificates))
            {
                writer.WritePropertyName("policySigningCertificates"u8);
                writer.WriteObjectValue(PolicySigningCertificates);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AttestationServiceCreationSpecificParams IJsonModel<AttestationServiceCreationSpecificParams>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServiceCreationSpecificParams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AttestationServiceCreationSpecificParams)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAttestationServiceCreationSpecificParams(document.RootElement, options);
        }

        internal static AttestationServiceCreationSpecificParams DeserializeAttestationServiceCreationSpecificParams(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PublicNetworkAccessType> publicNetworkAccess = default;
            Optional<JsonWebKeySet> policySigningCertificates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySigningCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policySigningCertificates = JsonWebKeySet.DeserializeJsonWebKeySet(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AttestationServiceCreationSpecificParams(Optional.ToNullable(publicNetworkAccess), policySigningCertificates.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AttestationServiceCreationSpecificParams>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServiceCreationSpecificParams>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AttestationServiceCreationSpecificParams)} does not support '{options.Format}' format.");
            }
        }

        AttestationServiceCreationSpecificParams IPersistableModel<AttestationServiceCreationSpecificParams>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestationServiceCreationSpecificParams>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAttestationServiceCreationSpecificParams(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AttestationServiceCreationSpecificParams)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AttestationServiceCreationSpecificParams>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
