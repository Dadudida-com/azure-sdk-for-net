// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using ClientModel.Tests.ClientShared;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace System.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    public partial class ApiProfile : IJsonModel<ApiProfile>
    {
        internal static ApiProfile DeserializeApiProfile(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterHelper.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> profileVersion = default;
            OptionalProperty<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileVersion"u8))
                {
                    profileVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ApiProfile(profileVersion.Value, apiVersion.Value);
        }

        void IJsonModel<ApiProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(ProfileVersion))
            {
                writer.WritePropertyName("profileVersion"u8);
                writer.WriteStringValue(ProfileVersion);
            }
            if (OptionalProperty.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        private struct ApiProfileProperties
        {
            public OptionalProperty<string> ProfileVersion { get; set; }
            public OptionalProperty<string> ApiVersion { get; set; }
        }

        ApiProfile IJsonModel<ApiProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApiProfile(doc.RootElement, options);
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ApiProfileProperties properties, ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            if (propertyName.SequenceEqual("profileVersion"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ProfileVersion = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("apiVersion"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ApiVersion = reader.GetString();
                return;
            }
            reader.Skip();
        }

        ApiProfile IPersistableModel<ApiProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeApiProfile(doc.RootElement, options);
        }

        BinaryData IPersistableModel<ApiProfile>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<ApiProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
