// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerCapabilityProperties : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerCapabilityProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerCapabilityProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerCapabilityProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerCapabilityProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Zone))
            {
                writer.WritePropertyName("zone"u8);
                writer.WriteStringValue(Zone);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedHAMode))
            {
                writer.WritePropertyName("supportedHAMode"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedHAMode)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedGeoBackupRegions))
            {
                writer.WritePropertyName("supportedGeoBackupRegions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedGeoBackupRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedFlexibleServerEditions))
            {
                writer.WritePropertyName("supportedFlexibleServerEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedFlexibleServerEditions)
                {
                    writer.WriteObjectValue<MySqlFlexibleServerEditionCapability>(item, options);
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

        MySqlFlexibleServerCapabilityProperties IJsonModel<MySqlFlexibleServerCapabilityProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerCapabilityProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerCapabilityProperties(document.RootElement, options);
        }

        internal static MySqlFlexibleServerCapabilityProperties DeserializeMySqlFlexibleServerCapabilityProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string zone = default;
            IReadOnlyList<string> supportedHAMode = default;
            IReadOnlyList<string> supportedGeoBackupRegions = default;
            IReadOnlyList<MySqlFlexibleServerEditionCapability> supportedFlexibleServerEditions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"u8))
                {
                    zone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedHAMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedHAMode = array;
                    continue;
                }
                if (property.NameEquals("supportedGeoBackupRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedGeoBackupRegions = array;
                    continue;
                }
                if (property.NameEquals("supportedFlexibleServerEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerEditionCapability> array = new List<MySqlFlexibleServerEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerEditionCapability.DeserializeMySqlFlexibleServerEditionCapability(item, options));
                    }
                    supportedFlexibleServerEditions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerCapabilityProperties(zone, supportedHAMode ?? new ChangeTrackingList<string>(), supportedGeoBackupRegions ?? new ChangeTrackingList<string>(), supportedFlexibleServerEditions ?? new ChangeTrackingList<MySqlFlexibleServerEditionCapability>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerCapabilityProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerCapabilityProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerCapabilityProperties IPersistableModel<MySqlFlexibleServerCapabilityProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerCapabilityProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerCapabilityProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerCapabilityProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
