// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RuleEngineWorkerSelectorAttachment : IUtf8JsonSerializable, IJsonModel<RuleEngineWorkerSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuleEngineWorkerSelectorAttachment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RuleEngineWorkerSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEngineWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleEngineWorkerSelectorAttachment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("rule"u8);
            writer.WriteObjectValue<RouterRule>(Rule, options);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        RuleEngineWorkerSelectorAttachment IJsonModel<RuleEngineWorkerSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEngineWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleEngineWorkerSelectorAttachment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuleEngineWorkerSelectorAttachment(document.RootElement, options);
        }

        internal static RuleEngineWorkerSelectorAttachment DeserializeRuleEngineWorkerSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterRule rule = default;
            WorkerSelectorAttachmentKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rule"u8))
                {
                    rule = RouterRule.DeserializeRouterRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new WorkerSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RuleEngineWorkerSelectorAttachment(kind, serializedAdditionalRawData, rule);
        }

        BinaryData IPersistableModel<RuleEngineWorkerSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEngineWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RuleEngineWorkerSelectorAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        RuleEngineWorkerSelectorAttachment IPersistableModel<RuleEngineWorkerSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEngineWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRuleEngineWorkerSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RuleEngineWorkerSelectorAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RuleEngineWorkerSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RuleEngineWorkerSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRuleEngineWorkerSelectorAttachment(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<RuleEngineWorkerSelectorAttachment>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
