﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentInstrument20Choice.  ISO2002 ID# _wFdXNzbsEead9bDRE_1DAQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between types of payment instrument, that is, cheque, credit transfer, direct debit, investment account or payment card.
/// </summary>
[KnownType(typeof(PaymentInstrument20Choice.PaymentCardDetails))]
[KnownType(typeof(PaymentInstrument20Choice.CreditTransferDetails))]
[KnownType(typeof(PaymentInstrument20Choice.DirectDebitDetails))]
[KnownType(typeof(PaymentInstrument20Choice.ChequeDetails))]
[KnownType(typeof(PaymentInstrument20Choice.BankersDraftDetails))]
[KnownType(typeof(PaymentInstrument20Choice.CashAccountDetails))]
public abstract partial record PaymentInstrument20Choice_ : IIsoXmlSerilizable<PaymentInstrument20Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PaymentInstrument20Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PmtCardDtls" => PaymentInstrument20Choice.PaymentCardDetails.Deserialize(elementWithPayload),
             "CdtTrfDtls" => PaymentInstrument20Choice.CreditTransferDetails.Deserialize(elementWithPayload),
             "DrctDbtDtls" => PaymentInstrument20Choice.DirectDebitDetails.Deserialize(elementWithPayload),
             "ChqDtls" => PaymentInstrument20Choice.ChequeDetails.Deserialize(elementWithPayload),
             "BkrsDrftDtls" => PaymentInstrument20Choice.BankersDraftDetails.Deserialize(elementWithPayload),
             "CshAcctDtls" => PaymentInstrument20Choice.CashAccountDetails.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PaymentInstrument20Choice choice.")
        };
    }
}
