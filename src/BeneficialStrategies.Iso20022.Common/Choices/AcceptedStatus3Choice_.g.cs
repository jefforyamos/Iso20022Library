﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcceptedStatus3Choice.  ISO2002 ID# _OM_NkSqAEeO3oOoGGWHH4A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing accepted status.
/// </summary>
[KnownType(typeof(AcceptedStatus3Choice.NoSpecifiedReason))]
[KnownType(typeof(AcceptedStatus3Choice.Reason))]
public abstract partial record AcceptedStatus3Choice_ : IIsoXmlSerilizable<AcceptedStatus3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcceptedStatus3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => AcceptedStatus3Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => AcceptedStatus3Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcceptedStatus3Choice choice.")
        };
    }
}
