// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformKeyVaultCertificateProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformKeyVaultCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformKeyVaultCertificateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformKeyVaultCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformKeyVaultCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformKeyVaultCertificateProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("vaultUri"u8);
            writer.WriteStringValue(VaultUri.AbsoluteUri);
            writer.WritePropertyName("keyVaultCertName"u8);
            writer.WriteStringValue(KeyVaultCertName);
            if (Optional.IsDefined(CertVersion))
            {
                writer.WritePropertyName("certVersion"u8);
                writer.WriteStringValue(CertVersion);
            }
            if (Optional.IsDefined(IsPrivateKeyExcluded))
            {
                writer.WritePropertyName("excludePrivateKey"u8);
                writer.WriteBooleanValue(IsPrivateKeyExcluded.Value);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CertificatePropertiesType);
            if (options.Format != "W" && Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
            if (options.Format != "W" && Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (options.Format != "W" && Optional.IsDefined(IssuedOn))
            {
                writer.WritePropertyName("issuedDate"u8);
                writer.WriteStringValue(IssuedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ActivateOn))
            {
                writer.WritePropertyName("activateDate"u8);
                writer.WriteStringValue(ActivateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(SubjectName))
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DnsNames))
            {
                writer.WritePropertyName("dnsNames"u8);
                writer.WriteStartArray();
                foreach (var item in DnsNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        AppPlatformKeyVaultCertificateProperties IJsonModel<AppPlatformKeyVaultCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformKeyVaultCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformKeyVaultCertificateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformKeyVaultCertificateProperties(document.RootElement, options);
        }

        internal static AppPlatformKeyVaultCertificateProperties DeserializeAppPlatformKeyVaultCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri vaultUri = default;
            string keyVaultCertName = default;
            string certVersion = default;
            bool? excludePrivateKey = default;
            string type = default;
            string thumbprint = default;
            string issuer = default;
            DateTimeOffset? issuedDate = default;
            DateTimeOffset? expirationDate = default;
            DateTimeOffset? activateDate = default;
            string subjectName = default;
            IReadOnlyList<string> dnsNames = default;
            AppPlatformCertificateProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultUri"u8))
                {
                    vaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultCertName"u8))
                {
                    keyVaultCertName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certVersion"u8))
                {
                    certVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludePrivateKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludePrivateKey = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issuedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activateDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activateDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subjectName"u8))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsNames = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformCertificateProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformKeyVaultCertificateProperties(
                type,
                thumbprint,
                issuer,
                issuedDate,
                expirationDate,
                activateDate,
                subjectName,
                dnsNames ?? new ChangeTrackingList<string>(),
                provisioningState,
                serializedAdditionalRawData,
                vaultUri,
                keyVaultCertName,
                certVersion,
                excludePrivateKey);
        }

        BinaryData IPersistableModel<AppPlatformKeyVaultCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformKeyVaultCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformKeyVaultCertificateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformKeyVaultCertificateProperties IPersistableModel<AppPlatformKeyVaultCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformKeyVaultCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformKeyVaultCertificateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformKeyVaultCertificateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformKeyVaultCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
