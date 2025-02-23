// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("domainNameLabel"u8);
            writer.WriteStringValue(DomainNameLabel);
            if (Optional.IsDefined(DomainNameLabelScope))
            {
                writer.WritePropertyName("domainNameLabelScope"u8);
                writer.WriteStringValue(DomainNameLabelScope.Value.ToString());
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

        VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings IJsonModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainNameLabel = default;
            DomainNameLabelScopeType? domainNameLabelScope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainNameLabel"u8))
                {
                    domainNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNameLabelScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainNameLabelScope = new DomainNameLabelScopeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(domainNameLabel, domainNameLabelScope, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
