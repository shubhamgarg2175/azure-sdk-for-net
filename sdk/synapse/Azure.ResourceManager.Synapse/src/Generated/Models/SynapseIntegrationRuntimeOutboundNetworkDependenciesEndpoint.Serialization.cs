// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsCollectionDefined(EndpointDetails))
            {
                writer.WritePropertyName("endpointDetails"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointDetails)
                {
                    writer.WriteObjectValue<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails>(item, options);
                }
                writer.WriteEndArray();
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

        SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails> endpointDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails> array = new List<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails.DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails(item, options));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint(domainName, endpointDetails ?? new ChangeTrackingList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
