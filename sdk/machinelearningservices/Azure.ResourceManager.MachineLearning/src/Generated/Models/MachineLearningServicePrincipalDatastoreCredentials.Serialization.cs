// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningServicePrincipalDatastoreCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorityUri))
            {
                if (AuthorityUri != null)
                {
                    writer.WritePropertyName("authorityUrl"u8);
                    writer.WriteStringValue(AuthorityUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("authorityUrl");
                }
            }
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            if (Optional.IsDefined(ResourceUri))
            {
                if (ResourceUri != null)
                {
                    writer.WritePropertyName("resourceUrl"u8);
                    writer.WriteStringValue(ResourceUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("resourceUrl");
                }
            }
            writer.WritePropertyName("secrets"u8);
            writer.WriteObjectValue<MachineLearningServicePrincipalDatastoreSecrets>(Secrets, options);
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
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

        MachineLearningServicePrincipalDatastoreCredentials IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicePrincipalDatastoreCredentials(document.RootElement, options);
        }

        internal static MachineLearningServicePrincipalDatastoreCredentials DeserializeMachineLearningServicePrincipalDatastoreCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri authorityUrl = default;
            Guid clientId = default;
            Uri resourceUrl = default;
            MachineLearningServicePrincipalDatastoreSecrets secrets = default;
            Guid tenantId = default;
            CredentialsType credentialsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorityUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authorityUrl = null;
                        continue;
                    }
                    authorityUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceUrl = null;
                        continue;
                    }
                    resourceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    secrets = MachineLearningServicePrincipalDatastoreSecrets.DeserializeMachineLearningServicePrincipalDatastoreSecrets(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningServicePrincipalDatastoreCredentials(
                credentialsType,
                serializedAdditionalRawData,
                authorityUrl,
                clientId,
                resourceUrl,
                secrets,
                tenantId);
        }

        BinaryData IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningServicePrincipalDatastoreCredentials IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningServicePrincipalDatastoreCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
