﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentConditionStatus1.  ISO2002 ID# _IGiOt3VlEeiEU7thYTAN1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the status of the payment conditions.
/// </summary>
public partial record PaymentConditionStatus1
     : IIsoXmlSerilizable<PaymentConditionStatus1>
{
    #nullable enable
    
    /// <summary>
    /// Amount accepted to be paid.
    /// Usage:
    /// May only be present when AmountModificationAllowed is present in the request.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AcceptedAmount { get; init; } 
    /// <summary>
    /// Indicates if the DebtorAgent guarantees the payment, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    public required IsoTrueFalseIndicator GuaranteedPayment { get; init; } 
    /// <summary>
    /// Indicates if the debtor will pay before the requested execution date.
    /// </summary>
    public required IsoTrueFalseIndicator EarlyPayment { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (AcceptedAmount is IsoActiveCurrencyAndAmount AcceptedAmountValue)
        {
            writer.WriteStartElement(null, "AccptdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AcceptedAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "GrntedPmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(GuaranteedPayment)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "EarlyPmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(EarlyPayment)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
    }
    public static PaymentConditionStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
