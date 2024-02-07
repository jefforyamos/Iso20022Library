﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTradeDetails111.  ISO2002 ID# _aW1YAekGEemm4qhb2yFPOw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
public partial record SecuritiesTradeDetails111
     : IIsoXmlSerilizable<SecuritiesTradeDetails111>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    public IsoMax35Text? NotificationSenderTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    public IsoMax35Text? NotificationReceiverTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Status of the transfer.
    /// </summary>
    public PortfolioTransferStatus2Choice_? Status { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate8Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required SettlementDate17Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    public Reporting7Choice_? Reporting { get; init; } 
    /// <summary>
    /// Details about the financial instrument quantity involved in the transfer.
    /// </summary>
    public required Quantity14 QuantityDetails { get; init; } 
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    public SettlementDetails100? SettlementParameters { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties93? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties93? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection52? SettlementAmount { get; init; } 
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    public OtherAmounts29? OtherAmounts { get; init; } 
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    public OtherParties39? OtherBusinessParties { get; init; } 
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
        if (NotificationSenderTransactionIdentification is IsoMax35Text NotificationSenderTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "NtfctnSndrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NotificationSenderTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (NotificationReceiverTransactionIdentification is IsoMax35Text NotificationReceiverTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "NtfctnRcvrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NotificationReceiverTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CommonIdentification is IsoMax35Text CommonIdentificationValue)
        {
            writer.WriteStartElement(null, "CmonId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommonIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        if (Status is PortfolioTransferStatus2Choice_ StatusValue)
        {
            writer.WriteStartElement(null, "Sts", xmlNamespace );
            StatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDate is TradeDate8Choice_ TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            TradeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        SettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NumberOfDaysAccrued is IsoMax3Number NumberOfDaysAccruedValue)
        {
            writer.WriteStartElement(null, "NbOfDaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Number(NumberOfDaysAccruedValue)); // data type Max3Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes91 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Reporting is Reporting7Choice_ ReportingValue)
        {
            writer.WriteStartElement(null, "Rptg", xmlNamespace );
            ReportingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "QtyDtls", xmlNamespace );
        QuantityDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementParameters is SettlementDetails100 SettlementParametersValue)
        {
            writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
            SettlementParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties93 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties93 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAmount is AmountAndDirection52 SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            SettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherAmounts is OtherAmounts29 OtherAmountsValue)
        {
            writer.WriteStartElement(null, "OthrAmts", xmlNamespace );
            OtherAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherBusinessParties is OtherParties39 OtherBusinessPartiesValue)
        {
            writer.WriteStartElement(null, "OthrBizPties", xmlNamespace );
            OtherBusinessPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesTradeDetails111 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
