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
    public partial class SourceLifeCycle : IUtf8JsonSerializable, IJsonModel<SourceLifeCycle>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceLifeCycle>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SourceLifeCycle>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceLifeCycle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceLifeCycle)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("deleteAfter"u8);
            writer.WriteObjectValue<DataProtectionBackupDeleteSetting>(DeleteAfter, options);
            writer.WritePropertyName("sourceDataStore"u8);
            writer.WriteObjectValue<DataStoreInfoBase>(SourceDataStore, options);
            if (Optional.IsCollectionDefined(TargetDataStoreCopySettings))
            {
                writer.WritePropertyName("targetDataStoreCopySettings"u8);
                writer.WriteStartArray();
                foreach (var item in TargetDataStoreCopySettings)
                {
                    writer.WriteObjectValue<TargetCopySetting>(item, options);
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

        SourceLifeCycle IJsonModel<SourceLifeCycle>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceLifeCycle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceLifeCycle)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceLifeCycle(document.RootElement, options);
        }

        internal static SourceLifeCycle DeserializeSourceLifeCycle(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupDeleteSetting deleteAfter = default;
            DataStoreInfoBase sourceDataStore = default;
            IList<TargetCopySetting> targetDataStoreCopySettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deleteAfter"u8))
                {
                    deleteAfter = DataProtectionBackupDeleteSetting.DeserializeDataProtectionBackupDeleteSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceDataStore"u8))
                {
                    sourceDataStore = DataStoreInfoBase.DeserializeDataStoreInfoBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetDataStoreCopySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetCopySetting> array = new List<TargetCopySetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetCopySetting.DeserializeTargetCopySetting(item, options));
                    }
                    targetDataStoreCopySettings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SourceLifeCycle(deleteAfter, sourceDataStore, targetDataStoreCopySettings ?? new ChangeTrackingList<TargetCopySetting>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceLifeCycle>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceLifeCycle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceLifeCycle)} does not support writing '{options.Format}' format.");
            }
        }

        SourceLifeCycle IPersistableModel<SourceLifeCycle>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceLifeCycle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceLifeCycle(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceLifeCycle)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceLifeCycle>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
