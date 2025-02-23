// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm.Models
{
    internal partial class ScVmmNetworkProfileUpdate : IUtf8JsonSerializable, IJsonModel<ScVmmNetworkProfileUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScVmmNetworkProfileUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScVmmNetworkProfileUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmNetworkProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmNetworkProfileUpdate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteObjectValue<ScVmmNetworkInterfaceUpdate>(item, options);
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

        ScVmmNetworkProfileUpdate IJsonModel<ScVmmNetworkProfileUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmNetworkProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmNetworkProfileUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScVmmNetworkProfileUpdate(document.RootElement, options);
        }

        internal static ScVmmNetworkProfileUpdate DeserializeScVmmNetworkProfileUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ScVmmNetworkInterfaceUpdate> networkInterfaces = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScVmmNetworkInterfaceUpdate> array = new List<ScVmmNetworkInterfaceUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScVmmNetworkInterfaceUpdate.DeserializeScVmmNetworkInterfaceUpdate(item, options));
                    }
                    networkInterfaces = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScVmmNetworkProfileUpdate(networkInterfaces ?? new ChangeTrackingList<ScVmmNetworkInterfaceUpdate>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScVmmNetworkProfileUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmNetworkProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScVmmNetworkProfileUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ScVmmNetworkProfileUpdate IPersistableModel<ScVmmNetworkProfileUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmNetworkProfileUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScVmmNetworkProfileUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScVmmNetworkProfileUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScVmmNetworkProfileUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
