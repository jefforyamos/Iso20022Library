﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionTransactionSD6.  ISO2002 ID# _rV3zQQCEEeqouY-yI_q3qQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement option details.
/// </summary>
public partial record OptionTransactionSD6
     : IIsoXmlSerilizable<OptionTransactionSD6>
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC Instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    public required IsoMax15Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    /// <summary>
    /// Oversubscribed quantity of the instruction.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// For prorated events, portion of the instructed units that was accepted by the Issuer / Agent.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; } 
    /// <summary>
    /// For prorated events, the portion of the instructed quantity that was not accepted by the Issuer / Agent.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; } 
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    /// <summary>
    /// Entitled units for the oversubscription.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// Amount paid to the issuer / agent for subscription cost.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; } 
    /// <summary>
    /// Amount paid to the issuer / agent for the oversubscription cost.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    /// <summary>
    /// Quantity entered by the agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    public IsoMax210Text? InstructionComments { get; init; } 
    /// <summary>
    /// Amount of money debited or credited to adjust for the difference between the estimated and the final subscription rate for Rights Exercise events.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; init; } 
    /// <summary>
    /// Amount of money refunded from the original subscription cost for a Rights Exercise event.  This occurs when the event is prorated and the subscription cost relating to the unaffected (unaccepted) balance is returned to the holder.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; } 
    
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
        if (PlaceAndName is IsoMax350Text PlaceAndNameValue)
        {
            writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15Text(TransactionIdentification)); // data type Max15Text System.String
        writer.WriteEndElement();
        if (TransactionSequenceNumber is IsoMax3NumericText TransactionSequenceNumberValue)
        {
            writer.WriteStartElement(null, "TxSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(TransactionSequenceNumberValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxIdDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TransactionIdentificationDate)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxIdQty", xmlNamespace );
        TransactionIdentificationQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransactionIdentificationOversubscriptionQuantity is FinancialInstrumentQuantity15Choice_ TransactionIdentificationOversubscriptionQuantityValue)
        {
            writer.WriteStartElement(null, "TxIdOvrsbcptQty", xmlNamespace );
            TransactionIdentificationOversubscriptionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AcceptedQuantity is FinancialInstrumentQuantity15Choice_ AcceptedQuantityValue)
        {
            writer.WriteStartElement(null, "AccptdQty", xmlNamespace );
            AcceptedQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnacceptedQuantity is FinancialInstrumentQuantity15Choice_ UnacceptedQuantityValue)
        {
            writer.WriteStartElement(null, "UaccptdQty", xmlNamespace );
            UnacceptedQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EntitledAmount is IsoRestrictedFINActiveCurrencyAndAmount EntitledAmountValue)
        {
            writer.WriteStartElement(null, "EntitldAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(EntitledAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (EntitledQuantity is FinancialInstrumentQuantity15Choice_ EntitledQuantityValue)
        {
            writer.WriteStartElement(null, "EntitldQty", xmlNamespace );
            EntitledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EntitledOversubscriptionQuantity is FinancialInstrumentQuantity15Choice_ EntitledOversubscriptionQuantityValue)
        {
            writer.WriteStartElement(null, "EntitldOvrsbcptQty", xmlNamespace );
            EntitledOversubscriptionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubscriptionAmount is IsoRestrictedFINActiveCurrencyAndAmount SubscriptionAmountValue)
        {
            writer.WriteStartElement(null, "SbcptAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(SubscriptionAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OversubscriptionAmount is IsoRestrictedFINActiveCurrencyAndAmount OversubscriptionAmountValue)
        {
            writer.WriteStartElement(null, "OvrsbcptAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(OversubscriptionAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashInLieuOfShare is IsoRestrictedFINActiveCurrencyAndAmount CashInLieuOfShareValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(CashInLieuOfShareValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CustomerReferenceIdentification is IsoMax30Text CustomerReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "CstmrRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax30Text(CustomerReferenceIdentificationValue)); // data type Max30Text System.String
            writer.WriteEndElement();
        }
        if (AgentEnteredQuantity is FinancialInstrumentQuantity15Choice_ AgentEnteredQuantityValue)
        {
            writer.WriteStartElement(null, "AgtNtrdQty", xmlNamespace );
            AgentEnteredQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionComments is IsoMax210Text InstructionCommentsValue)
        {
            writer.WriteStartElement(null, "InstrCmnts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax210Text(InstructionCommentsValue)); // data type Max210Text System.String
            writer.WriteEndElement();
        }
        if (AdjustedSubscriptionAmount is IsoRestrictedFINActiveCurrencyAndAmount AdjustedSubscriptionAmountValue)
        {
            writer.WriteStartElement(null, "AdjstdSbcptAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(AdjustedSubscriptionAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (RefundedSubscriptionAmount is IsoRestrictedFINActiveCurrencyAndAmount RefundedSubscriptionAmountValue)
        {
            writer.WriteStartElement(null, "RfnddSbcptAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(RefundedSubscriptionAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static OptionTransactionSD6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
