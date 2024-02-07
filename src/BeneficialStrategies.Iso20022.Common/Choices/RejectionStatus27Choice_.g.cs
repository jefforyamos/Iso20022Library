﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionStatus27Choice.  ISO2002 ID# _Vl2wcZNSEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of rejection status.
/// </summary>
[KnownType(typeof(RejectionStatus27Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectionStatus27Choice.Reason))]
public abstract partial record RejectionStatus27Choice_ : IIsoXmlSerilizable<RejectionStatus27Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionStatus27Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectionStatus27Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectionStatus27Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionStatus27Choice choice.")
        };
    }
}
