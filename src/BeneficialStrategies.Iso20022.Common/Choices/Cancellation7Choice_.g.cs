﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Cancellation7Choice.  ISO2002 ID# _lZHWSQgMEeSFYfyUKDXKaw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between cancellation by transfer details or reference.
/// </summary>
[KnownType(typeof(Cancellation7Choice.CancellationByTransferInstructionDetails))]
[KnownType(typeof(Cancellation7Choice.CancellationByReference))]
public abstract partial record Cancellation7Choice_ : IIsoXmlSerilizable<Cancellation7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Cancellation7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CxlByTrfInstrDtls" => Cancellation7Choice.CancellationByTransferInstructionDetails.Deserialize(elementWithPayload),
             "CxlByRef" => Cancellation7Choice.CancellationByReference.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Cancellation7Choice choice.")
        };
    }
}
