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
    [JsonConverter(typeof(UpdateLandingZoneCredentialConverter))]
    public partial class UpdateLandingZoneCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken"u8);
                writer.WriteObjectValue<SecureString>(SasToken);
            }
            writer.WriteEndObject();
        }

        internal partial class UpdateLandingZoneCredentialConverter : JsonConverter<UpdateLandingZoneCredential>
        {
            public override void Write(Utf8JsonWriter writer, UpdateLandingZoneCredential model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<UpdateLandingZoneCredential>(model);
            }
            public override UpdateLandingZoneCredential Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
