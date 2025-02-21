// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class StorageAccountLocalUserData : IUtf8JsonSerializable, IJsonModel<StorageAccountLocalUserData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountLocalUserData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountLocalUserData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountLocalUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountLocalUserData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PermissionScopes))
            {
                writer.WritePropertyName("permissionScopes"u8);
                writer.WriteStartArray();
                foreach (var item in PermissionScopes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HomeDirectory))
            {
                writer.WritePropertyName("homeDirectory"u8);
                writer.WriteStringValue(HomeDirectory);
            }
            if (Optional.IsCollectionDefined(SshAuthorizedKeys))
            {
                writer.WritePropertyName("sshAuthorizedKeys"u8);
                writer.WriteStartArray();
                foreach (var item in SshAuthorizedKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid);
            }
            if (Optional.IsDefined(HasSharedKey))
            {
                writer.WritePropertyName("hasSharedKey"u8);
                writer.WriteBooleanValue(HasSharedKey.Value);
            }
            if (Optional.IsDefined(HasSshKey))
            {
                writer.WritePropertyName("hasSshKey"u8);
                writer.WriteBooleanValue(HasSshKey.Value);
            }
            if (Optional.IsDefined(HasSshPassword))
            {
                writer.WritePropertyName("hasSshPassword"u8);
                writer.WriteBooleanValue(HasSshPassword.Value);
            }
            writer.WriteEndObject();
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

        StorageAccountLocalUserData IJsonModel<StorageAccountLocalUserData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountLocalUserData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountLocalUserData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountLocalUserData(document.RootElement, options);
        }

        internal static StorageAccountLocalUserData DeserializeStorageAccountLocalUserData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<StoragePermissionScope>> permissionScopes = default;
            Optional<string> homeDirectory = default;
            Optional<IList<StorageSshPublicKey>> sshAuthorizedKeys = default;
            Optional<string> sid = default;
            Optional<bool> hasSharedKey = default;
            Optional<bool> hasSshKey = default;
            Optional<bool> hasSshPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("permissionScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StoragePermissionScope> array = new List<StoragePermissionScope>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StoragePermissionScope.DeserializeStoragePermissionScope(item));
                            }
                            permissionScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("homeDirectory"u8))
                        {
                            homeDirectory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sshAuthorizedKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StorageSshPublicKey> array = new List<StorageSshPublicKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageSshPublicKey.DeserializeStorageSshPublicKey(item));
                            }
                            sshAuthorizedKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("sid"u8))
                        {
                            sid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hasSharedKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasSharedKey = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasSshKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasSshKey = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasSshPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasSshPassword = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountLocalUserData(id, name, type, systemData.Value, Optional.ToList(permissionScopes), homeDirectory.Value, Optional.ToList(sshAuthorizedKeys), sid.Value, Optional.ToNullable(hasSharedKey), Optional.ToNullable(hasSshKey), Optional.ToNullable(hasSshPassword), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountLocalUserData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountLocalUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountLocalUserData)} does not support '{options.Format}' format.");
            }
        }

        StorageAccountLocalUserData IPersistableModel<StorageAccountLocalUserData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountLocalUserData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountLocalUserData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountLocalUserData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountLocalUserData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
