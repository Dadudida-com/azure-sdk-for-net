// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownJobOutput))]
    public partial class MachineLearningJobOutput : IUtf8JsonSerializable, IJsonModel<MachineLearningJobOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningJobOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningJobOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            writer.WritePropertyName("jobOutputType"u8);
            writer.WriteStringValue(JobOutputType.ToString());
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

        MachineLearningJobOutput IJsonModel<MachineLearningJobOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobOutput(document.RootElement, options);
        }

        internal static MachineLearningJobOutput DeserializeMachineLearningJobOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobOutputType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "custom_model": return MachineLearningCustomModelJobOutput.DeserializeMachineLearningCustomModelJobOutput(element);
                    case "mlflow_model": return MachineLearningFlowModelJobOutput.DeserializeMachineLearningFlowModelJobOutput(element);
                    case "mltable": return MachineLearningTableJobOutput.DeserializeMachineLearningTableJobOutput(element);
                    case "triton_model": return MachineLearningTritonModelJobOutput.DeserializeMachineLearningTritonModelJobOutput(element);
                    case "uri_file": return MachineLearningUriFileJobOutput.DeserializeMachineLearningUriFileJobOutput(element);
                    case "uri_folder": return MachineLearningUriFolderJobOutput.DeserializeMachineLearningUriFolderJobOutput(element);
                }
            }
            return UnknownJobOutput.DeserializeUnknownJobOutput(element);
        }

        BinaryData IPersistableModel<MachineLearningJobOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningJobOutput IPersistableModel<MachineLearningJobOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningJobOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningJobOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
