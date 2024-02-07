﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionAmounts2.  ISO2002 ID# _ONxHoY2mEeuPp4VyLQDHhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the card transaction.
/// </summary>
public partial record TransactionAmounts2
     : IIsoXmlSerilizable<TransactionAmounts2>
{
    #nullable enable
    
    /// <summary>
    /// Qualifier or type of amount.
    /// ISO 8583:93/2003 bit 24
    /// </summary>
    public TypeOfAmount22Code? AmountQualifier { get; init; } 
    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    public required TransactionAmount1 TransactionAmount { get; init; } 
    /// <summary>
    /// Present when the cardholder billing currency differs from the transaction currency expressed in the amount of the transaction. It may be populated by the card scheme or an intermediary processor as normally the acceptor does not know the billing currency for which the cardholder will be debited.
    /// </summary>
    public Amount15? CardholderBillingAmount { get; init; } 
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    public Amount15? ReconciliationAmount { get; init; } 
    /// <summary>
    /// Further details of some or all amounts in the transaction amount. 
    /// </summary>
    public DetailedAmount22? DetailedAmount { get; init; } 
    /// <summary>
    /// Amount related to the original transaction.
    /// ISO 8583:87 bit 95
    /// ISO 8583:93/2003 bit 30
    /// </summary>
    public OriginalTransactionAmount2? OriginalTransactionAmounts { get; init; } 
    
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
        if (AmountQualifier is TypeOfAmount22Code AmountQualifierValue)
        {
            writer.WriteStartElement(null, "AmtQlfr", xmlNamespace );
            writer.WriteValue(AmountQualifierValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxAmt", xmlNamespace );
        TransactionAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CardholderBillingAmount is Amount15 CardholderBillingAmountValue)
        {
            writer.WriteStartElement(null, "CrdhldrBllgAmt", xmlNamespace );
            CardholderBillingAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReconciliationAmount is Amount15 ReconciliationAmountValue)
        {
            writer.WriteStartElement(null, "RcncltnAmt", xmlNamespace );
            ReconciliationAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DetailedAmount is DetailedAmount22 DetailedAmountValue)
        {
            writer.WriteStartElement(null, "DtldAmt", xmlNamespace );
            DetailedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalTransactionAmounts is OriginalTransactionAmount2 OriginalTransactionAmountsValue)
        {
            writer.WriteStartElement(null, "OrgnlTxAmts", xmlNamespace );
            OriginalTransactionAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionAmounts2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
