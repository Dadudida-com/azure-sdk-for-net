// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownOnlineDeployment : IUtf8JsonSerializable, IJsonModel<MachineLearningOnlineDeploymentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningOnlineDeploymentProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningOnlineDeploymentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AppInsightsEnabled))
            {
                writer.WritePropertyName("appInsightsEnabled"u8);
                writer.WriteBooleanValue(AppInsightsEnabled.Value);
            }
            if (Optional.IsDefined(DataCollector))
            {
                if (DataCollector != null)
                {
                    writer.WritePropertyName("dataCollector"u8);
                    writer.WriteObjectValue(DataCollector);
                }
                else
                {
                    writer.WriteNull("dataCollector");
                }
            }
            if (Optional.IsDefined(EgressPublicNetworkAccess))
            {
                writer.WritePropertyName("egressPublicNetworkAccess"u8);
                writer.WriteStringValue(EgressPublicNetworkAccess.Value.ToString());
            }
            writer.WritePropertyName("endpointComputeType"u8);
            writer.WriteStringValue(EndpointComputeType.ToString());
            if (Optional.IsDefined(InstanceType))
            {
                if (InstanceType != null)
                {
                    writer.WritePropertyName("instanceType"u8);
                    writer.WriteStringValue(InstanceType);
                }
                else
                {
                    writer.WriteNull("instanceType");
                }
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                if (LivenessProbe != null)
                {
                    writer.WritePropertyName("livenessProbe"u8);
                    writer.WriteObjectValue(LivenessProbe);
                }
                else
                {
                    writer.WriteNull("livenessProbe");
                }
            }
            if (Optional.IsDefined(Model))
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteStringValue(Model);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (Optional.IsDefined(ModelMountPath))
            {
                if (ModelMountPath != null)
                {
                    writer.WritePropertyName("modelMountPath"u8);
                    writer.WriteStringValue(ModelMountPath);
                }
                else
                {
                    writer.WriteNull("modelMountPath");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                if (ReadinessProbe != null)
                {
                    writer.WritePropertyName("readinessProbe"u8);
                    writer.WriteObjectValue(ReadinessProbe);
                }
                else
                {
                    writer.WriteNull("readinessProbe");
                }
            }
            if (Optional.IsDefined(RequestSettings))
            {
                if (RequestSettings != null)
                {
                    writer.WritePropertyName("requestSettings"u8);
                    writer.WriteObjectValue(RequestSettings);
                }
                else
                {
                    writer.WriteNull("requestSettings");
                }
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                if (ScaleSettings != null)
                {
                    writer.WritePropertyName("scaleSettings"u8);
                    writer.WriteObjectValue(ScaleSettings);
                }
                else
                {
                    writer.WriteNull("scaleSettings");
                }
            }
            if (Optional.IsDefined(CodeConfiguration))
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    writer.WriteObjectValue(CodeConfiguration);
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId"u8);
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
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

        MachineLearningOnlineDeploymentProperties IJsonModel<MachineLearningOnlineDeploymentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownOnlineDeployment(document.RootElement, options);
        }

        internal static UnknownOnlineDeployment DeserializeUnknownOnlineDeployment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> appInsightsEnabled = default;
            Optional<DataCollector> dataCollector = default;
            Optional<MachineLearningEgressPublicNetworkAccessType> egressPublicNetworkAccess = default;
            MachineLearningEndpointComputeType endpointComputeType = "Unknown";
            Optional<string> instanceType = default;
            Optional<MachineLearningProbeSettings> livenessProbe = default;
            Optional<string> model = default;
            Optional<string> modelMountPath = default;
            Optional<MachineLearningDeploymentProvisioningState> provisioningState = default;
            Optional<MachineLearningProbeSettings> readinessProbe = default;
            Optional<MachineLearningOnlineRequestSettings> requestSettings = default;
            Optional<MachineLearningOnlineScaleSettings> scaleSettings = default;
            Optional<MachineLearningCodeConfiguration> codeConfiguration = default;
            Optional<string> description = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<IDictionary<string, string>> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appInsightsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataCollector"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataCollector = null;
                        continue;
                    }
                    dataCollector = DataCollector.DeserializeDataCollector(property.Value);
                    continue;
                }
                if (property.NameEquals("egressPublicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressPublicNetworkAccess = new MachineLearningEgressPublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointComputeType"u8))
                {
                    endpointComputeType = new MachineLearningEndpointComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceType = null;
                        continue;
                    }
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("livenessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        livenessProbe = null;
                        continue;
                    }
                    livenessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelMountPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelMountPath = null;
                        continue;
                    }
                    modelMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningDeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readinessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readinessProbe = null;
                        continue;
                    }
                    readinessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("requestSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestSettings = null;
                        continue;
                    }
                    requestSettings = MachineLearningOnlineRequestSettings.DeserializeMachineLearningOnlineRequestSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("scaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scaleSettings = null;
                        continue;
                    }
                    scaleSettings = MachineLearningOnlineScaleSettings.DeserializeMachineLearningOnlineScaleSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownOnlineDeployment(codeConfiguration.Value, description.Value, environmentId.Value, Optional.ToDictionary(environmentVariables), Optional.ToDictionary(properties), serializedAdditionalRawData, Optional.ToNullable(appInsightsEnabled), dataCollector.Value, Optional.ToNullable(egressPublicNetworkAccess), endpointComputeType, instanceType.Value, livenessProbe.Value, model.Value, modelMountPath.Value, Optional.ToNullable(provisioningState), readinessProbe.Value, requestSettings.Value, scaleSettings.Value);
        }

        BinaryData IPersistableModel<MachineLearningOnlineDeploymentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningOnlineDeploymentProperties IPersistableModel<MachineLearningOnlineDeploymentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownOnlineDeployment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningOnlineDeploymentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
