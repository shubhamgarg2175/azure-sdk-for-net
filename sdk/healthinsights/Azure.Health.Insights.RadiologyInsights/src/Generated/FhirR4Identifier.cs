// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// An identifier intended for computation
    /// Based on [FHIR Identifier](https://www.hl7.org/fhir/R4/identifier.html)
    /// </summary>
    public partial class FhirR4Identifier : FhirR4Element
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4Identifier"/>. </summary>
        public FhirR4Identifier()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4Identifier"/>. </summary>
        /// <param name="id"> Unique id for inter-element referencing. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="use"> usual | official | temp | secondary | old (If known). </param>
        /// <param name="type"> Description of identifier. </param>
        /// <param name="system"> The namespace for the identifier value. </param>
        /// <param name="value"> The value that is unique. </param>
        /// <param name="period"> Time period when id is/was valid for use. </param>
        /// <param name="assigner"> Organization that issued id (may be just text). </param>
        internal FhirR4Identifier(string id, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, string use, FhirR4CodeableConcept type, string system, string value, FhirR4Period period, FhirR4Reference assigner) : base(id, extension, serializedAdditionalRawData)
        {
            Use = use;
            Type = type;
            System = system;
            Value = value;
            Period = period;
            Assigner = assigner;
        }

        /// <summary> usual | official | temp | secondary | old (If known). </summary>
        public string Use { get; set; }
        /// <summary> Description of identifier. </summary>
        public FhirR4CodeableConcept Type { get; set; }
        /// <summary> The namespace for the identifier value. </summary>
        public string System { get; set; }
        /// <summary> The value that is unique. </summary>
        public string Value { get; set; }
        /// <summary> Time period when id is/was valid for use. </summary>
        public FhirR4Period Period { get; set; }
        /// <summary> Organization that issued id (may be just text). </summary>
        public FhirR4Reference Assigner { get; set; }
    }
}
