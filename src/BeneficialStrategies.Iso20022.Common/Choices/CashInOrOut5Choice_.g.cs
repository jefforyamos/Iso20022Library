﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CashInOrOut5Choice.  ISO2002 ID# _SBq60tp-Ed-ak6NoX_4Aeg_1170439952.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of a payment instrument for the cash-in flow or cash-out flow.
/// </summary>
[KnownType(typeof(CashInOrOut5Choice.CashInPaymentInstrument))]
[KnownType(typeof(CashInOrOut5Choice.CashOutPaymentInstrument))]
public abstract partial record CashInOrOut5Choice_ : IIsoXmlSerilizable<CashInOrOut5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CashInOrOut5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CshInPmtInstrm" => CashInOrOut5Choice.CashInPaymentInstrument.Deserialize(elementWithPayload),
             "CshOutPmtInstrm" => CashInOrOut5Choice.CashOutPaymentInstrument.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CashInOrOut5Choice choice.")
        };
    }
}
