﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTradeDetails68.  ISO2002 ID# _n5OdUYymEea-QrbCUXny2w.
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
public partial record SecuritiesTradeDetails68
     : IIsoXmlSerilizable<SecuritiesTradeDetails68>
{
    #nullable enable
    
    /// <summary>
    /// Identification of an account owner transaction that could potentially match with the allegement notified.
    /// </summary>
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction as known by the account servicer.
    /// </summary>
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner the account servicer and the market infrastructure.
    /// </summary>
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoMax35Text? TradeIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Status of the allegement.
    /// </summary>
    public AllegementStatus3Choice_? Status { get; init; } 
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate5Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required SettlementDate9Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    public Price2? DealPrice { get; init; } 
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
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    public TradeTransactionCondition5Choice_? TradeTransactionCondition { get; init; } 
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    /// <summary>
    /// Details about the financial instrument quantity and the account involved in the transaction.
    /// </summary>
    public required QuantityAndAccount45 QuantityAndAccountDetails { get; init; } 
    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    public SecuritiesFinancingTransactionDetails29? SecuritiesFinancingDetails { get; init; } 
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    public required SettlementDetails125 SettlementParameters { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties36? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties36? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection48? SettlementAmount { get; init; } 
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    public OtherAmounts32? OtherAmounts { get; init; } 
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    public OtherParties28? OtherBusinessParties { get; init; } 
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
        if (AccountOwnerTransactionIdentification is IsoMax35Text AccountOwnerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctOwnrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountOwnerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountServicerTransactionIdentification is IsoMax35Text AccountServicerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MarketInfrastructureTransactionIdentification is IsoMax35Text MarketInfrastructureTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "MktInfrstrctrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MarketInfrastructureTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessorTransactionIdentification is IsoMax35Text ProcessorTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessorTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TradeIdentification is IsoMax35Text TradeIdentificationValue)
        {
            writer.WriteStartElement(null, "TradId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TradeIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CommonIdentification is IsoMax35Text CommonIdentificationValue)
        {
            writer.WriteStartElement(null, "CmonId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommonIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PoolIdentification is IsoMax35Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PoolIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CollateralTransactionIdentification is IsoMax35Text CollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "CollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CollateralTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        if (Status is AllegementStatus3Choice_ StatusValue)
        {
            writer.WriteStartElement(null, "Sts", xmlNamespace );
            StatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfTrade is PlaceOfTradeIdentification1 PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            PlaceOfTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfClearing is PlaceOfClearingIdentification1 PlaceOfClearingValue)
        {
            writer.WriteStartElement(null, "PlcOfClr", xmlNamespace );
            PlaceOfClearingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDate is TradeDate5Choice_ TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            TradeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        SettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DealPrice is Price2 DealPriceValue)
        {
            writer.WriteStartElement(null, "DealPric", xmlNamespace );
            DealPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NumberOfDaysAccrued is IsoMax3Number NumberOfDaysAccruedValue)
        {
            writer.WriteStartElement(null, "NbOfDaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Number(NumberOfDaysAccruedValue)); // data type Max3Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes64 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeTransactionCondition is TradeTransactionCondition5Choice_ TradeTransactionConditionValue)
        {
            writer.WriteStartElement(null, "TradTxCond", xmlNamespace );
            TradeTransactionConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TypeOfPrice is TypeOfPrice29Choice_ TypeOfPriceValue)
        {
            writer.WriteStartElement(null, "TpOfPric", xmlNamespace );
            TypeOfPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "QtyAndAcctDtls", xmlNamespace );
        QuantityAndAccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecuritiesFinancingDetails is SecuritiesFinancingTransactionDetails29 SecuritiesFinancingDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesFincgDtls", xmlNamespace );
            SecuritiesFinancingDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
        SettlementParameters.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DeliveringSettlementParties is SettlementParties36 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties36 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAmount is AmountAndDirection48 SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            SettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherAmounts is OtherAmounts32 OtherAmountsValue)
        {
            writer.WriteStartElement(null, "OthrAmts", xmlNamespace );
            OtherAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherBusinessParties is OtherParties28 OtherBusinessPartiesValue)
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
    public static SecuritiesTradeDetails68 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
