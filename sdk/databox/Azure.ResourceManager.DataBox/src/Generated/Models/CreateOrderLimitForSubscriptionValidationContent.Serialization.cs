// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class CreateOrderLimitForSubscriptionValidationContent : IUtf8JsonSerializable, IJsonModel<CreateOrderLimitForSubscriptionValidationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateOrderLimitForSubscriptionValidationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateOrderLimitForSubscriptionValidationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateOrderLimitForSubscriptionValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateOrderLimitForSubscriptionValidationContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("deviceType"u8);
            writer.WriteStringValue(DeviceType.ToSerialString());
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
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

        CreateOrderLimitForSubscriptionValidationContent IJsonModel<CreateOrderLimitForSubscriptionValidationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateOrderLimitForSubscriptionValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateOrderLimitForSubscriptionValidationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateOrderLimitForSubscriptionValidationContent(document.RootElement, options);
        }

        internal static CreateOrderLimitForSubscriptionValidationContent DeserializeCreateOrderLimitForSubscriptionValidationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxSkuName deviceType = default;
            DataBoxValidationInputDiscriminator validationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceType"u8))
                {
                    deviceType = property.Value.GetString().ToDataBoxSkuName();
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateOrderLimitForSubscriptionValidationContent(validationType, serializedAdditionalRawData, deviceType);
        }

        BinaryData IPersistableModel<CreateOrderLimitForSubscriptionValidationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateOrderLimitForSubscriptionValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateOrderLimitForSubscriptionValidationContent)} does not support writing '{options.Format}' format.");
            }
        }

        CreateOrderLimitForSubscriptionValidationContent IPersistableModel<CreateOrderLimitForSubscriptionValidationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateOrderLimitForSubscriptionValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateOrderLimitForSubscriptionValidationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateOrderLimitForSubscriptionValidationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateOrderLimitForSubscriptionValidationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
