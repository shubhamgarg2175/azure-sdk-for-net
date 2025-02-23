// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class RemediationDeploymentSummary : IUtf8JsonSerializable, IJsonModel<RemediationDeploymentSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemediationDeploymentSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RemediationDeploymentSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemediationDeploymentSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemediationDeploymentSummary)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TotalDeployments))
            {
                writer.WritePropertyName("totalDeployments"u8);
                writer.WriteNumberValue(TotalDeployments.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SuccessfulDeployments))
            {
                writer.WritePropertyName("successfulDeployments"u8);
                writer.WriteNumberValue(SuccessfulDeployments.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FailedDeployments))
            {
                writer.WritePropertyName("failedDeployments"u8);
                writer.WriteNumberValue(FailedDeployments.Value);
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

        RemediationDeploymentSummary IJsonModel<RemediationDeploymentSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemediationDeploymentSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemediationDeploymentSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemediationDeploymentSummary(document.RootElement, options);
        }

        internal static RemediationDeploymentSummary DeserializeRemediationDeploymentSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? totalDeployments = default;
            int? successfulDeployments = default;
            int? failedDeployments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeployments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successfulDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successfulDeployments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedDeployments = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RemediationDeploymentSummary(totalDeployments, successfulDeployments, failedDeployments, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RemediationDeploymentSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemediationDeploymentSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RemediationDeploymentSummary)} does not support writing '{options.Format}' format.");
            }
        }

        RemediationDeploymentSummary IPersistableModel<RemediationDeploymentSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemediationDeploymentSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRemediationDeploymentSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RemediationDeploymentSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RemediationDeploymentSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
