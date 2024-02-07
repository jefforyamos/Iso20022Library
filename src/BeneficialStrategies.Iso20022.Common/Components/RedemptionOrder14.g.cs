﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionOrder14.  ISO2002 ID# _7rQ81zbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
public partial record RedemptionOrder14
     : IIsoXmlSerilizable<RedemptionOrder14>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = [];
    /// <summary>
    /// Investment fund class related to the order.
    /// </summary>
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Subdivision of the account used to segregate specific holdings.
    /// </summary>
    public SubAccount6? SubAccountForHolding { get; init; } 
    /// <summary>
    /// Amount of money or the number of units or percentage to be redeemed for the redemption order.
    /// </summary>
    public required FinancialInstrumentQuantity28Choice_ AmountOrUnitsOrPercentage { get; init; } 
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public IsoISODate? CashSettlementDate { get; init; } 
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1 
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    public ForeignExchangeTerms32? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the gross amount.
    /// </summary>
    public FeeAndTax1? TransactionOverhead { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters12? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction72? CashSettlementDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    public ValueList<Intermediary40> RelatedPartyDetails { get; init; } = [];
    /// <summary>
    /// Part of an investor's retained subscription amount that is returned by the fund in order to reimburse preliminary incentive/performance fees.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 
    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    /// <summary>
    /// Type of signature.
    /// </summary>
    public SignatureType1Choice_? SignatureType { get; init; } 
    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    public OrderWaiver1? OrderWaiverDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "OrdrRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OrderReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrdrTp", xmlNamespace );
        OrderType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SubAccountForHolding is SubAccount6 SubAccountForHoldingValue)
        {
            writer.WriteStartElement(null, "SubAcctForHldg", xmlNamespace );
            SubAccountForHoldingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AmtOrUnitsOrPctg", xmlNamespace );
        AmountOrUnitsOrPercentage.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Rounding is RoundingDirection2Code RoundingValue)
        {
            writer.WriteStartElement(null, "Rndg", xmlNamespace );
            writer.WriteValue(RoundingValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SettlementAmount is IsoActiveCurrencyAndAmount SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SettlementAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashSettlementDate is IsoISODate CashSettlementDateValue)
        {
            writer.WriteStartElement(null, "CshSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(CashSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SettlementMethod is DeliveryReceiptType2Code SettlementMethodValue)
        {
            writer.WriteStartElement(null, "SttlmMtd", xmlNamespace );
            writer.WriteValue(SettlementMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms32 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IncomePreference is IncomePreference1Code IncomePreferenceValue)
        {
            writer.WriteStartElement(null, "IncmPref", xmlNamespace );
            writer.WriteValue(IncomePreferenceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Group1Or2Units is UKTaxGroupUnit1Code Group1Or2UnitsValue)
        {
            writer.WriteStartElement(null, "Grp1Or2Units", xmlNamespace );
            writer.WriteValue(Group1Or2UnitsValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionOverhead is FeeAndTax1 TransactionOverheadValue)
        {
            writer.WriteStartElement(null, "TxOvrhd", xmlNamespace );
            TransactionOverheadValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAndCustodyDetails is FundSettlementParameters12 SettlementAndCustodyDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmAndCtdyDtls", xmlNamespace );
            SettlementAndCustodyDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PhysDlvryInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PhysicalDeliveryIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (PhysicalDeliveryDetails is DeliveryParameters3 PhysicalDeliveryDetailsValue)
        {
            writer.WriteStartElement(null, "PhysDlvryDtls", xmlNamespace );
            PhysicalDeliveryDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedSettlementCurrency is ActiveCurrencyCode RequestedSettlementCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdSttlmCcy", xmlNamespace );
            writer.WriteValue(RequestedSettlementCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RequestedNAVCurrency is ActiveOrHistoricCurrencyCode RequestedNAVCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdNAVCcy", xmlNamespace );
            writer.WriteValue(RequestedNAVCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CashSettlementDetails is PaymentTransaction72 CashSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "CshSttlmDtls", xmlNamespace );
            CashSettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NonStandardSettlementInformation is IsoMax350Text NonStandardSettlementInformationValue)
        {
            writer.WriteStartElement(null, "NonStdSttlmInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NonStandardSettlementInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "StffClntBrkdwn", xmlNamespace );
        StaffClientBreakdown.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialAdvice is FinancialAdvice1Code FinancialAdviceValue)
        {
            writer.WriteStartElement(null, "FinAdvc", xmlNamespace );
            writer.WriteValue(FinancialAdviceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NegotiatedTrade is NegotiatedTrade1Code NegotiatedTradeValue)
        {
            writer.WriteStartElement(null, "NgtdTrad", xmlNamespace );
            writer.WriteValue(NegotiatedTradeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RltdPtyDtls", xmlNamespace );
        RelatedPartyDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Equalisation is Equalisation1 EqualisationValue)
        {
            writer.WriteStartElement(null, "Equlstn", xmlNamespace );
            EqualisationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CustomerConductClassification is CustomerConductClassification1Choice_ CustomerConductClassificationValue)
        {
            writer.WriteStartElement(null, "CstmrCndctClssfctn", xmlNamespace );
            CustomerConductClassificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionChannelType is TransactionChannelType1Choice_ TransactionChannelTypeValue)
        {
            writer.WriteStartElement(null, "TxChanlTp", xmlNamespace );
            TransactionChannelTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SignatureType is SignatureType1Choice_ SignatureTypeValue)
        {
            writer.WriteStartElement(null, "SgntrTp", xmlNamespace );
            SignatureTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OrderWaiverDetails is OrderWaiver1 OrderWaiverDetailsValue)
        {
            writer.WriteStartElement(null, "OrdrWvrDtls", xmlNamespace );
            OrderWaiverDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RedemptionOrder14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
