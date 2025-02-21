// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    [PersistableModelProxy(typeof(UnknownEventHubsApplicationGroupPolicy))]
    public partial class EventHubsApplicationGroupPolicy : IUtf8JsonSerializable, IJsonModel<EventHubsApplicationGroupPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsApplicationGroupPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubsApplicationGroupPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsApplicationGroupPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsApplicationGroupPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ApplicationGroupPolicyType.ToString());
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

        EventHubsApplicationGroupPolicy IJsonModel<EventHubsApplicationGroupPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsApplicationGroupPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsApplicationGroupPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsApplicationGroupPolicy(document.RootElement, options);
        }

        internal static EventHubsApplicationGroupPolicy DeserializeEventHubsApplicationGroupPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ThrottlingPolicy": return EventHubsThrottlingPolicy.DeserializeEventHubsThrottlingPolicy(element);
                }
            }
            return UnknownEventHubsApplicationGroupPolicy.DeserializeUnknownEventHubsApplicationGroupPolicy(element);
        }

        BinaryData IPersistableModel<EventHubsApplicationGroupPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsApplicationGroupPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsApplicationGroupPolicy)} does not support '{options.Format}' format.");
            }
        }

        EventHubsApplicationGroupPolicy IPersistableModel<EventHubsApplicationGroupPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsApplicationGroupPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubsApplicationGroupPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubsApplicationGroupPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsApplicationGroupPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
