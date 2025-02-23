// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PartnerManagedResourceProperties : IUtf8JsonSerializable, IJsonModel<PartnerManagedResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerManagedResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerManagedResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerManagedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerManagedResourceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(InternalLoadBalancerId))
            {
                writer.WritePropertyName("internalLoadBalancerId"u8);
                writer.WriteStringValue(InternalLoadBalancerId);
            }
            if (options.Format != "W" && Optional.IsDefined(StandardLoadBalancerId))
            {
                writer.WritePropertyName("standardLoadBalancerId"u8);
                writer.WriteStringValue(StandardLoadBalancerId);
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

        PartnerManagedResourceProperties IJsonModel<PartnerManagedResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerManagedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerManagedResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerManagedResourceProperties(document.RootElement, options);
        }

        internal static PartnerManagedResourceProperties DeserializePartnerManagedResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            ResourceIdentifier internalLoadBalancerId = default;
            ResourceIdentifier standardLoadBalancerId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("internalLoadBalancerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalLoadBalancerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("standardLoadBalancerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standardLoadBalancerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartnerManagedResourceProperties(id, internalLoadBalancerId, standardLoadBalancerId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PartnerManagedResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerManagedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartnerManagedResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PartnerManagedResourceProperties IPersistableModel<PartnerManagedResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerManagedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerManagedResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerManagedResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerManagedResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
