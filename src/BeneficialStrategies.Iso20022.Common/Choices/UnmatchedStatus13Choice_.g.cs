﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedStatus13Choice.  ISO2002 ID# _NoI_sSwjEeOEV5XHD-BKpw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(UnmatchedStatus13Choice.NoSpecifiedReason))]
[KnownType(typeof(UnmatchedStatus13Choice.Reason))]
public abstract partial record UnmatchedStatus13Choice_ : IIsoXmlSerilizable<UnmatchedStatus13Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static UnmatchedStatus13Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => UnmatchedStatus13Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => UnmatchedStatus13Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid UnmatchedStatus13Choice choice.")
        };
    }
}
