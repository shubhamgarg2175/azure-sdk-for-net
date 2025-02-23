// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppHttpRequestInfo : IUtf8JsonSerializable, IJsonModel<ContainerAppHttpRequestInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppHttpRequestInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppHttpRequestInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppHttpRequestInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsCollectionDefined(HttpHeaders))
            {
                writer.WritePropertyName("httpHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in HttpHeaders)
                {
                    writer.WriteObjectValue<ContainerAppHttpHeaderInfo>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WritePropertyName("port"u8);
            writer.WriteNumberValue(Port);
            if (Optional.IsDefined(Scheme))
            {
                writer.WritePropertyName("scheme"u8);
                writer.WriteStringValue(Scheme.Value.ToString());
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

        ContainerAppHttpRequestInfo IJsonModel<ContainerAppHttpRequestInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppHttpRequestInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppHttpRequestInfo(document.RootElement, options);
        }

        internal static ContainerAppHttpRequestInfo DeserializeContainerAppHttpRequestInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string host = default;
            IList<ContainerAppHttpHeaderInfo> httpHeaders = default;
            string path = default;
            int port = default;
            ContainerAppHttpScheme? scheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppHttpHeaderInfo> array = new List<ContainerAppHttpHeaderInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppHttpHeaderInfo.DeserializeContainerAppHttpHeaderInfo(item, options));
                    }
                    httpHeaders = array;
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheme = new ContainerAppHttpScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppHttpRequestInfo(
                host,
                httpHeaders ?? new ChangeTrackingList<ContainerAppHttpHeaderInfo>(),
                path,
                port,
                scheme,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppHttpRequestInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppHttpRequestInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppHttpRequestInfo IPersistableModel<ContainerAppHttpRequestInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppHttpRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppHttpRequestInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppHttpRequestInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppHttpRequestInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
