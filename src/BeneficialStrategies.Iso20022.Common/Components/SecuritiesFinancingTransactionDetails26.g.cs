﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesFinancingTransactionDetails26.  ISO2002 ID# _LQgj6x5gEeWE3PufGMdJ3w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
public partial record SecuritiesFinancingTransactionDetails26
     : IIsoXmlSerilizable<SecuritiesFinancingTransactionDetails26>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    public IsoMax35Text? ClosingLegIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent's point of view.
    /// </summary>
    public IsoMax35Text? TripartyAgentCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification98? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount19 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace1? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required Quantity6Choice_ SettlementQuantity { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    public AmountAndDirection51? OpeningSettlementAmount { get; init; } 
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    public AmountAndDirection21? TerminationTransactionAmount { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required SettlementDate10Choice_ OpeningSettlementDate { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public TerminationDate4Choice_? TerminationDate { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate5Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; } 
    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    public DateAndDateTimeChoice_? RateChangeDate { get; init; } 
    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    public required SecuritiesFinancingTransactionType1Code SecuritiesFinancingTransactionType { get; init; } 
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
    public SettlementDetails98? SettlementParameters { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    public RateType35Choice_? RateType { get; init; } 
    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    public RateName1? VariableRateSupport { get; init; } 
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    public Rate2? RepurchaseRate { get; init; } 
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender's risk.
    /// </summary>
    public Rate2? StockLoanMargin { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    public Rate2? SecuritiesHaircut { get; init; } 
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    public RateOrName1Choice_? PricingRate { get; init; } 
    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    public Rate2? Spread { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties36? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties36? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentification99? Investor { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    
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
        if (SecuritiesFinancingTradeIdentification is IsoMax35Text SecuritiesFinancingTradeIdentificationValue)
        {
            writer.WriteStartElement(null, "SctiesFincgTradId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecuritiesFinancingTradeIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClosingLegIdentification is IsoMax35Text ClosingLegIdentificationValue)
        {
            writer.WriteStartElement(null, "ClsgLegId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClosingLegIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PoolIdentification is IsoMax35Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PoolIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CorporateActionEventIdentification is IsoMax35Text CorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CorporateActionEventIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentCollateralTransactionIdentification is IsoMax35Text TripartyAgentCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TripartyAgentCollateralTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientTripartyCollateralTransactionIdentification is IsoMax35Text ClientTripartyCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntTrptyCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientTripartyCollateralTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification98 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SafekeepingPlace is SafeKeepingPlace1 SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfTrade is PlaceOfTradeIdentification1 PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            PlaceOfTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmQty", xmlNamespace );
        SettlementQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OpeningSettlementAmount is AmountAndDirection51 OpeningSettlementAmountValue)
        {
            writer.WriteStartElement(null, "OpngSttlmAmt", xmlNamespace );
            OpeningSettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminationTransactionAmount is AmountAndDirection21 TerminationTransactionAmountValue)
        {
            writer.WriteStartElement(null, "TermntnTxAmt", xmlNamespace );
            TerminationTransactionAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OpngSttlmDt", xmlNamespace );
        OpeningSettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TerminationDate is TerminationDate4Choice_ TerminationDateValue)
        {
            writer.WriteStartElement(null, "TermntnDt", xmlNamespace );
            TerminationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDate is TradeDate5Choice_ TradeDateValue)
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
        if (ExpectedValueDate is DateAndDateTimeChoice_ ExpectedValueDateValue)
        {
            writer.WriteStartElement(null, "XpctdValDt", xmlNamespace );
            ExpectedValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LateDeliveryDate is DateAndDateTimeChoice_ LateDeliveryDateValue)
        {
            writer.WriteStartElement(null, "LateDlvryDt", xmlNamespace );
            LateDeliveryDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateChangeDate is DateAndDateTimeChoice_ RateChangeDateValue)
        {
            writer.WriteStartElement(null, "RateChngDt", xmlNamespace );
            RateChangeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesFincgTxTp", xmlNamespace );
        writer.WriteValue(SecuritiesFinancingTransactionType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        if (SettlementParameters is SettlementDetails98 SettlementParametersValue)
        {
            writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
            SettlementParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateType is RateType35Choice_ RateTypeValue)
        {
            writer.WriteStartElement(null, "RateTp", xmlNamespace );
            RateTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VariableRateSupport is RateName1 VariableRateSupportValue)
        {
            writer.WriteStartElement(null, "VarblRateSpprt", xmlNamespace );
            VariableRateSupportValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepurchaseRate is Rate2 RepurchaseRateValue)
        {
            writer.WriteStartElement(null, "RpRate", xmlNamespace );
            RepurchaseRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StockLoanMargin is Rate2 StockLoanMarginValue)
        {
            writer.WriteStartElement(null, "StockLnMrgn", xmlNamespace );
            StockLoanMarginValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesHaircut is Rate2 SecuritiesHaircutValue)
        {
            writer.WriteStartElement(null, "SctiesHrcut", xmlNamespace );
            SecuritiesHaircutValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PricingRate is RateOrName1Choice_ PricingRateValue)
        {
            writer.WriteStartElement(null, "PricgRate", xmlNamespace );
            PricingRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Spread is Rate2 SpreadValue)
        {
            writer.WriteStartElement(null, "Sprd", xmlNamespace );
            SpreadValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
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
        if (Investor is PartyIdentification99 InvestorValue)
        {
            writer.WriteStartElement(null, "Invstr", xmlNamespace );
            InvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementInstructionProcessingAdditionalDetails is IsoMax350Text SettlementInstructionProcessingAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmInstrPrcgAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(SettlementInstructionProcessingAdditionalDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static SecuritiesFinancingTransactionDetails26 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
