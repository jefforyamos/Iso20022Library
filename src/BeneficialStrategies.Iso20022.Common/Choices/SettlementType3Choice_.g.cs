﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementType3Choice.  ISO2002 ID# _2VKQNeLbEeWFtOV72FbX9w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for settlement type.
/// </summary>
[KnownType(typeof(SettlementType3Choice.Code))]
[KnownType(typeof(SettlementType3Choice.Proprietary))]
public abstract partial record SettlementType3Choice_ : IIsoXmlSerilizable<SettlementType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => SettlementType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => SettlementType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementType3Choice choice.")
        };
    }
}
