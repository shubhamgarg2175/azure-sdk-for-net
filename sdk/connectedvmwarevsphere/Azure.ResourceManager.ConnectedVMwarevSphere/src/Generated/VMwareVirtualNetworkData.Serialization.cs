// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VMwareVirtualNetworkData : IUtf8JsonSerializable, IJsonModel<VMwareVirtualNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareVirtualNetworkData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareVirtualNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVirtualNetworkData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            if (Optional.IsDefined(VCenterId))
            {
                writer.WritePropertyName("vCenterId"u8);
                writer.WriteStringValue(VCenterId);
            }
            if (Optional.IsDefined(MoRefId))
            {
                writer.WritePropertyName("moRefId"u8);
                writer.WriteStringValue(MoRefId);
            }
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId"u8);
                writer.WriteStringValue(InventoryItemId);
            }
            if (options.Format != "W" && Optional.IsDefined(MoName))
            {
                writer.WritePropertyName("moName"u8);
                writer.WriteStringValue(MoName);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomResourceName))
            {
                writer.WritePropertyName("customResourceName"u8);
                writer.WriteStringValue(CustomResourceName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue<VMwareResourceStatus>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        VMwareVirtualNetworkData IJsonModel<VMwareVirtualNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVirtualNetworkData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareVirtualNetworkData(document.RootElement, options);
        }

        internal static VMwareVirtualNetworkData DeserializeVMwareVirtualNetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            string kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string uuid = default;
            string vCenterId = default;
            string moRefId = default;
            string inventoryItemId = default;
            string moName = default;
            string customResourceName = default;
            IReadOnlyList<VMwareResourceStatus> statuses = default;
            VMwareResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("uuid"u8))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vCenterId"u8))
                        {
                            vCenterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moRefId"u8))
                        {
                            moRefId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inventoryItemId"u8))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moName"u8))
                        {
                            moName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"u8))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VMwareResourceStatus> array = new List<VMwareResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VMwareResourceStatus.DeserializeVMwareResourceStatus(item, options));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VMwareResourceProvisioningState(property0.Value.GetString());
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
            return new VMwareVirtualNetworkData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                extendedLocation,
                kind,
                uuid,
                vCenterId,
                moRefId,
                inventoryItemId,
                moName,
                customResourceName,
                statuses ?? new ChangeTrackingList<VMwareResourceStatus>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareVirtualNetworkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareVirtualNetworkData)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareVirtualNetworkData IPersistableModel<VMwareVirtualNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareVirtualNetworkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareVirtualNetworkData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareVirtualNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
