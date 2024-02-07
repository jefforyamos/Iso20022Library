﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction77.  ISO2002 ID# _T_zC4WXlEeap-P22vGV91g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
public partial record PaymentTransaction77
     : IIsoXmlSerilizable<PaymentTransaction77>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed transaction.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    public IsoMax35Text? ReversalIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; init; } 
    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    public PaymentReversalReason7? ReversalReasonInformation { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference24? OriginalTransactionReference { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        if (ReversalIdentification is IsoMax35Text ReversalIdentificationValue)
        {
            writer.WriteStartElement(null, "RvslId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReversalIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalInstructionIdentification is IsoMax35Text OriginalInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalEndToEndIdentification is IsoMax35Text OriginalEndToEndIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlEndToEndId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalEndToEndIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalInstructedAmount is IsoActiveOrHistoricCurrencyAndAmount OriginalInstructedAmountValue)
        {
            writer.WriteStartElement(null, "OrgnlInstdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OriginalInstructedAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ReversedInstructedAmount is IsoActiveOrHistoricCurrencyAndAmount ReversedInstructedAmountValue)
        {
            writer.WriteStartElement(null, "RvsdInstdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(ReversedInstructedAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ReversalReasonInformation is PaymentReversalReason7 ReversalReasonInformationValue)
        {
            writer.WriteStartElement(null, "RvslRsnInf", xmlNamespace );
            ReversalReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalTransactionReference is OriginalTransactionReference24 OriginalTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlTxRef", xmlNamespace );
            OriginalTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransaction77 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
