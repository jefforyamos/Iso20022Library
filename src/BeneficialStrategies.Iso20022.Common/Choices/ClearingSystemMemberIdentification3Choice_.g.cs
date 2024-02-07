﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClearingSystemMemberIdentification3Choice.  ISO2002 ID# _TMehGdp-Ed-ak6NoX_4Aeg_-1564562098.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identifiers for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
/// </summary>
[KnownType(typeof(ClearingSystemMemberIdentification3Choice.Identification))]
[KnownType(typeof(ClearingSystemMemberIdentification3Choice.Proprietary))]
public abstract partial record ClearingSystemMemberIdentification3Choice_ : IIsoXmlSerilizable<ClearingSystemMemberIdentification3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ClearingSystemMemberIdentification3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Id" => ClearingSystemMemberIdentification3Choice.Identification.Deserialize(elementWithPayload),
             "Prtry" => ClearingSystemMemberIdentification3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ClearingSystemMemberIdentification3Choice choice.")
        };
    }
}
