﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ReversalRequest.  ISO2002 ID# _8caEINuREeiB5uLfkg9ZJA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform1Choice;

/// <summary>
/// Content of the Reversal Request message.
/// </summary>
public partial record ReversalRequest : TransactionToPerform1Choice_
     , IIsoXmlSerilizable<ReversalRequest>
{
    #nullable enable
    
    /// <summary>
    /// Original transaction to reverse.
    /// </summary>
    public CardPaymentTransaction91? OriginalPaymentTransaction { get; init; } 
    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    public required ReversalReason1Code ReversalReason { get; init; } 
    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    public IsoImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (OriginalPaymentTransaction is CardPaymentTransaction91 OriginalPaymentTransactionValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtTx", xmlNamespace );
            OriginalPaymentTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RvslRsn", xmlNamespace );
        writer.WriteValue(ReversalReason.ToString()); // Enum value
        writer.WriteEndElement();
        if (ReversedAmount is IsoImpliedCurrencyAndAmount ReversedAmountValue)
        {
            writer.WriteStartElement(null, "RvsdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(ReversedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CustomerOrder is CustomerOrder1 CustomerOrderValue)
        {
            writer.WriteStartElement(null, "CstmrOrdr", xmlNamespace );
            CustomerOrderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new ReversalRequest Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
