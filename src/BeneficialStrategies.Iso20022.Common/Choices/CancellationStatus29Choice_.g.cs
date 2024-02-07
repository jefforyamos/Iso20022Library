﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationStatus29Choice.  ISO2002 ID# _u2DukOBEEeiVRbNQx5-Vhg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Instruction/Request has been cancelled.
/// </summary>
[KnownType(typeof(CancellationStatus29Choice.NoSpecifiedReason))]
[KnownType(typeof(CancellationStatus29Choice.Reason))]
public abstract partial record CancellationStatus29Choice_ : IIsoXmlSerilizable<CancellationStatus29Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CancellationStatus29Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => CancellationStatus29Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => CancellationStatus29Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CancellationStatus29Choice choice.")
        };
    }
}
