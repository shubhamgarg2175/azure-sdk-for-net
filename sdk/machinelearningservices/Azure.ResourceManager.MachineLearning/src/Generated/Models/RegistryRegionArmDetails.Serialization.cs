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
    public partial class RegistryRegionArmDetails : IUtf8JsonSerializable, IJsonModel<RegistryRegionArmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegistryRegionArmDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RegistryRegionArmDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryRegionArmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegistryRegionArmDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AcrDetails))
            {
                if (AcrDetails != null)
                {
                    writer.WritePropertyName("acrDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in AcrDetails)
                    {
                        writer.WriteObjectValue<RegistryAcrDetails>(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("acrDetails");
                }
            }
            if (Optional.IsDefined(Location))
            {
                if (Location != null)
                {
                    writer.WritePropertyName("location"u8);
                    writer.WriteStringValue(Location.Value);
                }
                else
                {
                    writer.WriteNull("location");
                }
            }
            if (Optional.IsCollectionDefined(StorageAccountDetails))
            {
                if (StorageAccountDetails != null)
                {
                    writer.WritePropertyName("storageAccountDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in StorageAccountDetails)
                    {
                        writer.WriteObjectValue<StorageAccountDetails>(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("storageAccountDetails");
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

        RegistryRegionArmDetails IJsonModel<RegistryRegionArmDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryRegionArmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegistryRegionArmDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegistryRegionArmDetails(document.RootElement, options);
        }

        internal static RegistryRegionArmDetails DeserializeRegistryRegionArmDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<RegistryAcrDetails> acrDetails = default;
            AzureLocation? location = default;
            IList<StorageAccountDetails> storageAccountDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acrDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acrDetails = null;
                        continue;
                    }
                    List<RegistryAcrDetails> array = new List<RegistryAcrDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegistryAcrDetails.DeserializeRegistryAcrDetails(item, options));
                    }
                    acrDetails = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        location = null;
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountDetails = null;
                        continue;
                    }
                    List<StorageAccountDetails> array = new List<StorageAccountDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.StorageAccountDetails.DeserializeStorageAccountDetails(item, options));
                    }
                    storageAccountDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegistryRegionArmDetails(acrDetails ?? new ChangeTrackingList<RegistryAcrDetails>(), location, storageAccountDetails ?? new ChangeTrackingList<StorageAccountDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegistryRegionArmDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryRegionArmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegistryRegionArmDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RegistryRegionArmDetails IPersistableModel<RegistryRegionArmDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryRegionArmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegistryRegionArmDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegistryRegionArmDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegistryRegionArmDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
