﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedReason16Choice.  ISO2002 ID# _zbyVoSwkEeOEV5XHD-BKpw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the statement query unmatched reason.
/// </summary>
[KnownType(typeof(UnmatchedReason16Choice.Code))]
[KnownType(typeof(UnmatchedReason16Choice.Proprietary))]
public abstract partial record UnmatchedReason16Choice_ : IIsoXmlSerilizable<UnmatchedReason16Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static UnmatchedReason16Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => UnmatchedReason16Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => UnmatchedReason16Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid UnmatchedReason16Choice choice.")
        };
    }
}
