// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DatasetStorageFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetStorageFormatType);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                JsonSerializer.Serialize(writer, Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                JsonSerializer.Serialize(writer, Deserializer);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        internal static DatasetStorageFormat DeserializeDatasetStorageFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroFormat": return DatasetAvroFormat.DeserializeDatasetAvroFormat(element);
                    case "JsonFormat": return DatasetJsonFormat.DeserializeDatasetJsonFormat(element);
                    case "OrcFormat": return DatasetOrcFormat.DeserializeDatasetOrcFormat(element);
                    case "ParquetFormat": return DatasetParquetFormat.DeserializeDatasetParquetFormat(element);
                    case "TextFormat": return DatasetTextFormat.DeserializeDatasetTextFormat(element);
                }
            }
            return UnknownDatasetStorageFormat.DeserializeUnknownDatasetStorageFormat(element);
        }
    }
}
