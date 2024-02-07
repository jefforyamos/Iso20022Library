﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LimitStructure2Choice.  ISO2002 ID# __lXa7249EeiU9cctagi5ow.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Limit details of one or more limits set by the member and managed by the transaction administrator.
/// </summary>
[KnownType(typeof(LimitStructure2Choice.CurrentLimitIdentification))]
[KnownType(typeof(LimitStructure2Choice.AllCurrentLimits))]
public abstract partial record LimitStructure2Choice_ : IIsoXmlSerilizable<LimitStructure2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static LimitStructure2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CurLmtId" => LimitStructure2Choice.CurrentLimitIdentification.Deserialize(elementWithPayload),
             "AllCurLmts" => LimitStructure2Choice.AllCurrentLimits.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid LimitStructure2Choice choice.")
        };
    }
}
