﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails37.  ISO2002 ID# _PlRaAfvmEeCBQp5TnX1XKQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
public partial record TransactionDetails37
     : IIsoXmlSerilizable<TransactionDetails37>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    public required TransactionActivity1Choice_ TransactionActivity { get; init; } 
    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    public SettlementOrCorporateActionEvent5Choice_? SettlementTransactionOrCorporateActionEventType { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    public SettlementDetails48? SettlementParameters { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public MarketIdentification4? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    public AmountAndDirection3? PostingAmount { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection4? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate1Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is, payment is effected and securities are delivered.
    /// </summary>
    public required DateAndDateTimeChoice_ EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public SettlementDate1Choice_? SettlementDate { get; init; } 
    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties13? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties13? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Specifies whether it is the reversal of a previously reported movement.
    /// </summary>
    public IsoYesNoIndicator? ReversalIndicator { get; init; } 
    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? TransactionAdditionalDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "TxActvty", xmlNamespace );
        TransactionActivity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementTransactionOrCorporateActionEventType is SettlementOrCorporateActionEvent5Choice_ SettlementTransactionOrCorporateActionEventTypeValue)
        {
            writer.WriteStartElement(null, "SttlmTxOrCorpActnEvtTp", xmlNamespace );
            SettlementTransactionOrCorporateActionEventTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        if (SettlementParameters is SettlementDetails48 SettlementParametersValue)
        {
            writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
            SettlementParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfTrade is MarketIdentification4 PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            PlaceOfTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormat3Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfClearing is IsoAnyBICIdentifier PlaceOfClearingValue)
        {
            writer.WriteStartElement(null, "PlcOfClr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoAnyBICIdentifier(PlaceOfClearingValue)); // data type AnyBICIdentifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PstngQty", xmlNamespace );
        PostingQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NumberOfDaysAccrued is IsoMax3Number NumberOfDaysAccruedValue)
        {
            writer.WriteStartElement(null, "NbOfDaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Number(NumberOfDaysAccruedValue)); // data type Max3Number System.UInt64
            writer.WriteEndElement();
        }
        if (PostingAmount is AmountAndDirection3 PostingAmountValue)
        {
            writer.WriteStartElement(null, "PstngAmt", xmlNamespace );
            PostingAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccruedInterestAmount is AmountAndDirection4 AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            AccruedInterestAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDate is TradeDate1Choice_ TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            TradeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FctvSttlmDt", xmlNamespace );
        EffectiveSettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementDate is SettlementDate1Choice_ SettlementDateValue)
        {
            writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
            SettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueDate is DateAndDateTimeChoice_ ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            ValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties13 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties13 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReversalIndicator is IsoYesNoIndicator ReversalIndicatorValue)
        {
            writer.WriteStartElement(null, "RvslInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ReversalIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (TransactionAdditionalDetails is IsoMax350Text TransactionAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "TxAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(TransactionAdditionalDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static TransactionDetails37 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
