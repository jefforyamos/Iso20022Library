﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionPrice13Choice.  ISO2002 ID# _k-0NsQFMEeqUa4noT3P56A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice to define the price of the securities transaction.
/// </summary>
[KnownType(typeof(SecuritiesTransactionPrice13Choice.MonetaryValue))]
[KnownType(typeof(SecuritiesTransactionPrice13Choice.Percentage))]
[KnownType(typeof(SecuritiesTransactionPrice13Choice.Decimal))]
[KnownType(typeof(SecuritiesTransactionPrice13Choice.BasisPointSpread))]
public abstract partial record SecuritiesTransactionPrice13Choice_ : IIsoXmlSerilizable<SecuritiesTransactionPrice13Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecuritiesTransactionPrice13Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "MntryVal" => SecuritiesTransactionPrice13Choice.MonetaryValue.Deserialize(elementWithPayload),
             "Pctg" => SecuritiesTransactionPrice13Choice.Percentage.Deserialize(elementWithPayload),
             "Dcml" => SecuritiesTransactionPrice13Choice.Decimal.Deserialize(elementWithPayload),
             "BsisPtSprd" => SecuritiesTransactionPrice13Choice.BasisPointSpread.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecuritiesTransactionPrice13Choice choice.")
        };
    }
}
