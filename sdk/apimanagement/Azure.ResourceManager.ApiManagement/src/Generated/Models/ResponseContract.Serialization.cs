// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ResponseContract : IUtf8JsonSerializable, IJsonModel<ResponseContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResponseContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResponseContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseContract)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("statusCode"u8);
            writer.WriteNumberValue(StatusCode);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Representations))
            {
                writer.WritePropertyName("representations"u8);
                writer.WriteStartArray();
                foreach (var item in Representations)
                {
                    writer.WriteObjectValue<RepresentationContract>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue<ParameterContract>(item, options);
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

        ResponseContract IJsonModel<ResponseContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseContract)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResponseContract(document.RootElement, options);
        }

        internal static ResponseContract DeserializeResponseContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int statusCode = default;
            string description = default;
            IList<RepresentationContract> representations = default;
            IList<ParameterContract> headers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"u8))
                {
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("representations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RepresentationContract> array = new List<RepresentationContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RepresentationContract.DeserializeRepresentationContract(item, options));
                    }
                    representations = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParameterContract> array = new List<ParameterContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParameterContract.DeserializeParameterContract(item, options));
                    }
                    headers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResponseContract(statusCode, description, representations ?? new ChangeTrackingList<RepresentationContract>(), headers ?? new ChangeTrackingList<ParameterContract>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResponseContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResponseContract)} does not support writing '{options.Format}' format.");
            }
        }

        ResponseContract IPersistableModel<ResponseContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResponseContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResponseContract)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResponseContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
