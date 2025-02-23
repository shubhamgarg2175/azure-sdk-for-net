// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpProjectDetails : IUtf8JsonSerializable, IJsonModel<GcpProjectDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GcpProjectDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GcpProjectDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpProjectDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpProjectDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProjectNumber))
            {
                writer.WritePropertyName("projectNumber"u8);
                writer.WriteStringValue(ProjectNumber);
            }
            if (Optional.IsDefined(ProjectId))
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteStringValue(ProjectId);
            }
            if (options.Format != "W" && Optional.IsDefined(WorkloadIdentityPoolId))
            {
                writer.WritePropertyName("workloadIdentityPoolId"u8);
                writer.WriteStringValue(WorkloadIdentityPoolId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProjectName))
            {
                writer.WritePropertyName("projectName"u8);
                writer.WriteStringValue(ProjectName);
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

        GcpProjectDetails IJsonModel<GcpProjectDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpProjectDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpProjectDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpProjectDetails(document.RootElement, options);
        }

        internal static GcpProjectDetails DeserializeGcpProjectDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string projectNumber = default;
            string projectId = default;
            string workloadIdentityPoolId = default;
            string projectName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectNumber"u8))
                {
                    projectNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    projectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityPoolId"u8))
                {
                    workloadIdentityPoolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GcpProjectDetails(projectNumber, projectId, workloadIdentityPoolId, projectName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GcpProjectDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpProjectDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GcpProjectDetails)} does not support writing '{options.Format}' format.");
            }
        }

        GcpProjectDetails IPersistableModel<GcpProjectDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpProjectDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGcpProjectDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GcpProjectDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GcpProjectDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
