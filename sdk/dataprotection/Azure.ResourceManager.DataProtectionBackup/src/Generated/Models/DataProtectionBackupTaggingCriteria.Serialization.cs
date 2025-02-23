// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupTaggingCriteria : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupTaggingCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupTaggingCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupTaggingCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupTaggingCriteria)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Criteria))
            {
                writer.WritePropertyName("criteria"u8);
                writer.WriteStartArray();
                foreach (var item in Criteria)
                {
                    writer.WriteObjectValue<DataProtectionBackupCriteria>(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("isDefault"u8);
            writer.WriteBooleanValue(IsDefault);
            writer.WritePropertyName("taggingPriority"u8);
            writer.WriteNumberValue(TaggingPriority);
            writer.WritePropertyName("tagInfo"u8);
            writer.WriteObjectValue<DataProtectionBackupRetentionTag>(TagInfo, options);
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

        DataProtectionBackupTaggingCriteria IJsonModel<DataProtectionBackupTaggingCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupTaggingCriteria)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupTaggingCriteria(document.RootElement, options);
        }

        internal static DataProtectionBackupTaggingCriteria DeserializeDataProtectionBackupTaggingCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataProtectionBackupCriteria> criteria = default;
            bool isDefault = default;
            long taggingPriority = default;
            DataProtectionBackupRetentionTag tagInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("criteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataProtectionBackupCriteria> array = new List<DataProtectionBackupCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBackupCriteria.DeserializeDataProtectionBackupCriteria(item, options));
                    }
                    criteria = array;
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("taggingPriority"u8))
                {
                    taggingPriority = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("tagInfo"u8))
                {
                    tagInfo = DataProtectionBackupRetentionTag.DeserializeDataProtectionBackupRetentionTag(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataProtectionBackupTaggingCriteria(criteria ?? new ChangeTrackingList<DataProtectionBackupCriteria>(), isDefault, taggingPriority, tagInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProtectionBackupTaggingCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupTaggingCriteria)} does not support writing '{options.Format}' format.");
            }
        }

        DataProtectionBackupTaggingCriteria IPersistableModel<DataProtectionBackupTaggingCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupTaggingCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupTaggingCriteria)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupTaggingCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
