﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionOrder6.  ISO2002 ID# _SDKvrdp-Ed-ak6NoX_4Aeg_-97453543.
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
public partial record RedemptionOrder6
     : IIsoXmlSerilizable<RedemptionOrder6>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    public ValueList<FundOrderType2> OrderType { get; init; } = [];
    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Subdivision of an account used to segregate specific holdings.
    /// </summary>
    public SubAccount1? SubAccountForHolding { get; init; } 
    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold, before deduction of charges, commissions, and taxes.|[Quantity * Price].
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; } 
    /// <summary>
    /// Amount of money to be received following redemption after deduction of charges, commissions and taxes and used to derive the quantity of investment fund units to be sold.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Portion of the investor's holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    public required IsoPercentageRate HoldingsRedemptionRate { get; init; } 
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
    /// </summary>
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    public Charge17? ChargeDetails { get; init; } 
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    public Commission10? CommissionDetails { get; init; } 
    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    public Tax16? TaxDetails { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to physical delivery of the securities.
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
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction21? CashSettlementDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];
    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    
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
        if (CancellationReference is IsoMax35Text CancellationReferenceValue)
        {
            writer.WriteStartElement(null, "CxlRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CancellationReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrdrTp", xmlNamespace );
        OrderType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SubAccountForHolding is SubAccount1 SubAccountForHoldingValue)
        {
            writer.WriteStartElement(null, "SubAcctForHldg", xmlNamespace );
            SubAccountForHoldingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UnitsNb", xmlNamespace );
        UnitsNumber.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "GrssAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(GrossAmount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NetAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(NetAmount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "HldgsRedRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(HoldingsRedemptionRate)); // data type PercentageRate System.Decimal
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
        if (ForeignExchangeDetails is ForeignExchangeTerms6 ForeignExchangeDetailsValue)
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
        if (Group1Or2Units is UKTaxGroupUnitCode Group1Or2UnitsValue)
        {
            writer.WriteStartElement(null, "Grp1Or2Units", xmlNamespace );
            writer.WriteValue(Group1Or2UnitsValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChargeDetails is Charge17 ChargeDetailsValue)
        {
            writer.WriteStartElement(null, "ChrgDtls", xmlNamespace );
            ChargeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CommissionDetails is Commission10 CommissionDetailsValue)
        {
            writer.WriteStartElement(null, "ComssnDtls", xmlNamespace );
            CommissionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxDetails is Tax16 TaxDetailsValue)
        {
            writer.WriteStartElement(null, "TaxDtls", xmlNamespace );
            TaxDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAndCustodyDetails is FundSettlementParameters3 SettlementAndCustodyDetailsValue)
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
        if (CashSettlementDetails is PaymentTransaction21 CashSettlementDetailsValue)
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
    }
    public static RedemptionOrder6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
