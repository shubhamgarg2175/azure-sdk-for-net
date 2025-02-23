// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceSingleSignOnProperties : IUtf8JsonSerializable, IJsonModel<DynatraceSingleSignOnProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceSingleSignOnProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DynatraceSingleSignOnProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceSingleSignOnProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SingleSignOnState))
            {
                writer.WritePropertyName("singleSignOnState"u8);
                writer.WriteStringValue(SingleSignOnState.Value.ToString());
            }
            if (Optional.IsDefined(EnterpriseAppId))
            {
                writer.WritePropertyName("enterpriseAppId"u8);
                writer.WriteStringValue(EnterpriseAppId.Value);
            }
            if (Optional.IsDefined(SingleSignOnUri))
            {
                writer.WritePropertyName("singleSignOnUrl"u8);
                writer.WriteStringValue(SingleSignOnUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(AadDomains))
            {
                writer.WritePropertyName("aadDomains"u8);
                writer.WriteStartArray();
                foreach (var item in AadDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        DynatraceSingleSignOnProperties IJsonModel<DynatraceSingleSignOnProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceSingleSignOnProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceSingleSignOnProperties(document.RootElement, options);
        }

        internal static DynatraceSingleSignOnProperties DeserializeDynatraceSingleSignOnProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DynatraceSingleSignOnState? singleSignOnState = default;
            Guid? enterpriseAppId = default;
            Uri singleSignOnUrl = default;
            IList<string> aadDomains = default;
            DynatraceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("singleSignOnState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnState = new DynatraceSingleSignOnState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enterpriseAppId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enterpriseAppId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadDomains"u8))
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
                    aadDomains = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DynatraceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DynatraceSingleSignOnProperties(
                singleSignOnState,
                enterpriseAppId,
                singleSignOnUrl,
                aadDomains ?? new ChangeTrackingList<string>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceSingleSignOnProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceSingleSignOnProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DynatraceSingleSignOnProperties IPersistableModel<DynatraceSingleSignOnProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceSingleSignOnProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceSingleSignOnProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceSingleSignOnProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
