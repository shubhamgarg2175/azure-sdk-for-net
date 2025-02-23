// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class ImportInfo : IUtf8JsonSerializable, IJsonModel<ImportInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImportInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ChildObjectName))
            {
                writer.WritePropertyName("childObjectName"u8);
                writer.WriteStringValue(ChildObjectName);
            }
            if (Optional.IsDefined(ImportStatus))
            {
                writer.WritePropertyName("importStatus"u8);
                writer.WriteStringValue(ImportStatus.Value.ToString());
            }
            if (Optional.IsDefined(ParentObjectName))
            {
                writer.WritePropertyName("parentObjectName"u8);
                writer.WriteStringValue(ParentObjectName);
            }
            if (Optional.IsDefined(Remarks))
            {
                writer.WritePropertyName("remarks"u8);
                writer.WriteStringValue(Remarks);
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

        ImportInfo IJsonModel<ImportInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportInfo(document.RootElement, options);
        }

        internal static ImportInfo DeserializeImportInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string childObjectName = default;
            ImportStatus? importStatus = default;
            string parentObjectName = default;
            string remarks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("childObjectName"u8))
                {
                    childObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("importStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importStatus = new ImportStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parentObjectName"u8))
                {
                    parentObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remarks"u8))
                {
                    remarks = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImportInfo(childObjectName, importStatus, parentObjectName, remarks, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImportInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ImportInfo IPersistableModel<ImportInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImportInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImportInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImportInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImportInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImportInfo(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ImportInfo>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
