// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DomainRecommendationSearchContent : IUtf8JsonSerializable, IJsonModel<DomainRecommendationSearchContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DomainRecommendationSearchContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DomainRecommendationSearchContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainRecommendationSearchContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainRecommendationSearchContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Keywords))
            {
                writer.WritePropertyName("keywords"u8);
                writer.WriteStringValue(Keywords);
            }
            if (Optional.IsDefined(MaxDomainRecommendations))
            {
                writer.WritePropertyName("maxDomainRecommendations"u8);
                writer.WriteNumberValue(MaxDomainRecommendations.Value);
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

        DomainRecommendationSearchContent IJsonModel<DomainRecommendationSearchContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainRecommendationSearchContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainRecommendationSearchContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainRecommendationSearchContent(document.RootElement, options);
        }

        internal static DomainRecommendationSearchContent DeserializeDomainRecommendationSearchContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keywords = default;
            int? maxDomainRecommendations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keywords"u8))
                {
                    keywords = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDomainRecommendations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDomainRecommendations = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DomainRecommendationSearchContent(keywords, maxDomainRecommendations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DomainRecommendationSearchContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainRecommendationSearchContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DomainRecommendationSearchContent)} does not support writing '{options.Format}' format.");
            }
        }

        DomainRecommendationSearchContent IPersistableModel<DomainRecommendationSearchContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainRecommendationSearchContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDomainRecommendationSearchContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DomainRecommendationSearchContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DomainRecommendationSearchContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
