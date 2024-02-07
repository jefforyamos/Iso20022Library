﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatementType5Choice.  ISO2002 ID# _ufLsETqoEeWyoP0PbocV1Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the statement type.
/// </summary>
[KnownType(typeof(StatementType5Choice.Code))]
[KnownType(typeof(StatementType5Choice.Proprietary))]
public abstract partial record StatementType5Choice_ : IIsoXmlSerilizable<StatementType5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static StatementType5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => StatementType5Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => StatementType5Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid StatementType5Choice choice.")
        };
    }
}
