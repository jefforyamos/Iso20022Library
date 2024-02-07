﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails8.  ISO2002 ID# _UdsRWdp-Ed-ak6NoX_4Aeg_-8315197.
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
public partial record TransactionDetails8
     : IIsoXmlSerilizable<TransactionDetails8>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    public required TransactionActivity1Choice_ TransactionActivity { get; init; } 
    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    public SettlementOrCorporateActionEvent2Choice_? SettlementTransactionOrCorporateActionEventType { get; init; } 
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
    public SettlementDetails7? SettlementParameters { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public MarketIdentification4? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    public required Quantity6Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    public required AmountAndDirection8 PostingAmount { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate1Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required SettlementDate2Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties2? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties2? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? TransactionAdditionalDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension2? Extension { get; init; } 
    
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
        if (SettlementTransactionOrCorporateActionEventType is SettlementOrCorporateActionEvent2Choice_ SettlementTransactionOrCorporateActionEventTypeValue)
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
        if (SettlementParameters is SettlementDetails7 SettlementParametersValue)
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
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PstngQty", xmlNamespace );
        PostingQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PstngAmt", xmlNamespace );
        PostingAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TradeDate is TradeDate1Choice_ TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            TradeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpectedSettlementDate is DateAndDateTimeChoice_ ExpectedSettlementDateValue)
        {
            writer.WriteStartElement(null, "XpctdSttlmDt", xmlNamespace );
            ExpectedSettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        SettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LateDeliveryDate is DateAndDateTimeChoice_ LateDeliveryDateValue)
        {
            writer.WriteStartElement(null, "LateDlvryDt", xmlNamespace );
            LateDeliveryDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpectedValueDate is DateAndDateTimeChoice_ ExpectedValueDateValue)
        {
            writer.WriteStartElement(null, "XpctdValDt", xmlNamespace );
            ExpectedValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties2 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties2 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionAdditionalDetails is IsoMax350Text TransactionAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "TxAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(TransactionAdditionalDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (Extension is Extension2 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionDetails8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
