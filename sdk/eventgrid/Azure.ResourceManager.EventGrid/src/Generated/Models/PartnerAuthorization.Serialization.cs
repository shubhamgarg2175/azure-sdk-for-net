// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerAuthorization : IUtf8JsonSerializable, IJsonModel<PartnerAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerAuthorization>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultMaximumExpirationTimeInDays))
            {
                writer.WritePropertyName("defaultMaximumExpirationTimeInDays"u8);
                writer.WriteNumberValue(DefaultMaximumExpirationTimeInDays.Value);
            }
            if (Optional.IsCollectionDefined(AuthorizedPartnersList))
            {
                writer.WritePropertyName("authorizedPartnersList"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizedPartnersList)
                {
                    writer.WriteObjectValue<EventGridPartnerContent>(item, options);
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

        PartnerAuthorization IJsonModel<PartnerAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerAuthorization(document.RootElement, options);
        }

        internal static PartnerAuthorization DeserializePartnerAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? defaultMaximumExpirationTimeInDays = default;
            IList<EventGridPartnerContent> authorizedPartnersList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultMaximumExpirationTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMaximumExpirationTimeInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authorizedPartnersList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventGridPartnerContent> array = new List<EventGridPartnerContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventGridPartnerContent.DeserializeEventGridPartnerContent(item, options));
                    }
                    authorizedPartnersList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartnerAuthorization(defaultMaximumExpirationTimeInDays, authorizedPartnersList ?? new ChangeTrackingList<EventGridPartnerContent>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PartnerAuthorization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support writing '{options.Format}' format.");
            }
        }

        PartnerAuthorization IPersistableModel<PartnerAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerAuthorization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
