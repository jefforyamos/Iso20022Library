﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LinkedMessage6Choice.  ISO2002 ID# _2mW56TWhEe2OzdGcZrUAEQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Reference to a message.
/// </summary>
[KnownType(typeof(LinkedMessage6Choice.PreviousReference))]
[KnownType(typeof(LinkedMessage6Choice.OtherReference))]
[KnownType(typeof(LinkedMessage6Choice.RelatedReference))]
public abstract partial record LinkedMessage6Choice_ : IIsoXmlSerilizable<LinkedMessage6Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static LinkedMessage6Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PrvsRef" => LinkedMessage6Choice.PreviousReference.Deserialize(elementWithPayload),
             "OthrRef" => LinkedMessage6Choice.OtherReference.Deserialize(elementWithPayload),
             "RltdRef" => LinkedMessage6Choice.RelatedReference.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid LinkedMessage6Choice choice.")
        };
    }
}
