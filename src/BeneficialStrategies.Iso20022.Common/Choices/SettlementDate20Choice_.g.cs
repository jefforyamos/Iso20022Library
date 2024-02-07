﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementDate20Choice.  ISO2002 ID# _qImeT83yEee5nJBZsW8MFQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the settlement date.
/// </summary>
[KnownType(typeof(SettlementDate20Choice.Date))]
[KnownType(typeof(SettlementDate20Choice.DateCode))]
public abstract partial record SettlementDate20Choice_ : IIsoXmlSerilizable<SettlementDate20Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementDate20Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Dt" => SettlementDate20Choice.Date.Deserialize(elementWithPayload),
             "DtCd" => SettlementDate20Choice.DateCode.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementDate20Choice choice.")
        };
    }
}
