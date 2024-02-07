﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionLoanData31Choice.  ISO2002 ID# _lmwk8czsEeux2uvSBFU54Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Provides the details of the reported transaction.
/// </summary>
[KnownType(typeof(TransactionLoanData31Choice.RepurchaseTrade))]
[KnownType(typeof(TransactionLoanData31Choice.BuySellBack))]
[KnownType(typeof(TransactionLoanData31Choice.SecuritiesLending))]
[KnownType(typeof(TransactionLoanData31Choice.MarginLending))]
public abstract partial record TransactionLoanData31Choice_ : IIsoXmlSerilizable<TransactionLoanData31Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TransactionLoanData31Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "RpTrad" => TransactionLoanData31Choice.RepurchaseTrade.Deserialize(elementWithPayload),
             "BuySellBck" => TransactionLoanData31Choice.BuySellBack.Deserialize(elementWithPayload),
             "SctiesLndg" => TransactionLoanData31Choice.SecuritiesLending.Deserialize(elementWithPayload),
             "MrgnLndg" => TransactionLoanData31Choice.MarginLending.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TransactionLoanData31Choice choice.")
        };
    }
}
