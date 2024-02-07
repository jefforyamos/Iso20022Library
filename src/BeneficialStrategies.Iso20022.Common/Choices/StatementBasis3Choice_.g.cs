﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatementBasis3Choice.  ISO2002 ID# _QrsmZNp-Ed-ak6NoX_4Aeg_-114081181.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the statement basis.
/// </summary>
[KnownType(typeof(StatementBasis3Choice.Code))]
[KnownType(typeof(StatementBasis3Choice.Proprietary))]
public abstract partial record StatementBasis3Choice_ : IIsoXmlSerilizable<StatementBasis3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static StatementBasis3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => StatementBasis3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => StatementBasis3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid StatementBasis3Choice choice.")
        };
    }
}
