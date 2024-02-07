﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcceptedReason7Choice.  ISO2002 ID# _PFE46ljzEeOnqqBHs8Gasw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the reason of an accepted status.
/// </summary>
[KnownType(typeof(AcceptedReason7Choice.Code))]
[KnownType(typeof(AcceptedReason7Choice.Proprietary))]
public abstract partial record AcceptedReason7Choice_ : IIsoXmlSerilizable<AcceptedReason7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcceptedReason7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AcceptedReason7Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AcceptedReason7Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcceptedReason7Choice choice.")
        };
    }
}
