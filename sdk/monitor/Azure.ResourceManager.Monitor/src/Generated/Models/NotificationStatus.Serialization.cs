// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class NotificationStatus : IUtf8JsonSerializable, IJsonModel<NotificationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NotificationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteObjectValue<NotificationContext>(Context, options);
            }
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State);
            if (Optional.IsDefined(CompletedOn))
            {
                writer.WritePropertyName("completedTime"u8);
                writer.WriteStringValue(CompletedOn.Value, "O");
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(ActionDetails))
            {
                writer.WritePropertyName("actionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ActionDetails)
                {
                    writer.WriteObjectValue<NotificationActionDetail>(item, options);
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

        NotificationStatus IJsonModel<NotificationStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationStatus(document.RootElement, options);
        }

        internal static NotificationStatus DeserializeNotificationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NotificationContext context = default;
            string state = default;
            DateTimeOffset? completedTime = default;
            DateTimeOffset? createdTime = default;
            IReadOnlyList<NotificationActionDetail> actionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("context"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    context = NotificationContext.DeserializeNotificationContext(property.Value, options);
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("completedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("actionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotificationActionDetail> array = new List<NotificationActionDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotificationActionDetail.DeserializeNotificationActionDetail(item, options));
                    }
                    actionDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NotificationStatus(
                context,
                state,
                completedTime,
                createdTime,
                actionDetails ?? new ChangeTrackingList<NotificationActionDetail>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationStatus)} does not support writing '{options.Format}' format.");
            }
        }

        NotificationStatus IPersistableModel<NotificationStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
