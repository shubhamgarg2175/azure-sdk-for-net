// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(NotebookSessionPropertiesConverter))]
    public partial class NotebookSessionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("driverMemory"u8);
            writer.WriteStringValue(DriverMemory);
            writer.WritePropertyName("driverCores"u8);
            writer.WriteNumberValue(DriverCores);
            writer.WritePropertyName("executorMemory"u8);
            writer.WriteStringValue(ExecutorMemory);
            writer.WritePropertyName("executorCores"u8);
            writer.WriteNumberValue(ExecutorCores);
            writer.WritePropertyName("numExecutors"u8);
            writer.WriteNumberValue(NumExecutors);
            writer.WriteEndObject();
        }

        internal static NotebookSessionProperties DeserializeNotebookSessionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string driverMemory = default;
            int driverCores = default;
            string executorMemory = default;
            int executorCores = default;
            int numExecutors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("driverMemory"u8))
                {
                    driverMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverCores"u8))
                {
                    driverCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("executorMemory"u8))
                {
                    executorMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executorCores"u8))
                {
                    executorCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numExecutors"u8))
                {
                    numExecutors = property.Value.GetInt32();
                    continue;
                }
            }
            return new NotebookSessionProperties(driverMemory, driverCores, executorMemory, executorCores, numExecutors);
        }

        internal partial class NotebookSessionPropertiesConverter : JsonConverter<NotebookSessionProperties>
        {
            public override void Write(Utf8JsonWriter writer, NotebookSessionProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<NotebookSessionProperties>(model);
            }
            public override NotebookSessionProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookSessionProperties(document.RootElement);
            }
        }
    }
}
