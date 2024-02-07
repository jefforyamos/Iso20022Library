﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionExecution3.  ISO2002 ID# _VUYBttp-Ed-ak6NoX_4Aeg_127522648.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
public partial record SubscriptionExecution3
     : IIsoXmlSerilizable<SubscriptionExecution3>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    public required IsoMax35Text DealReference { get; init; } 
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    public FundOrderType1? OrderType { get; init; } 
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Net amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    public required IsoActiveCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, including all charges, commissions, and tax, expressed in the currency requested by the investor.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossAmount { get; init; } 
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    public required UnitPrice5 PriceDetails { get; init; } 
    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer's actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    public IsoMax35Text? LetterIntentReference { get; init; } 
    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer's present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    public TotalCharges2? ChargeGeneralDetails { get; init; } 
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    public TotalCommissions2? CommissionGeneralDetails { get; init; } 
    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    public TotalTaxes2? TaxGeneralDetails { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the securities are to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Refund { get; init; } 
    /// <summary>
    /// Interest received when a subscription amount is paid in advance and then invested by the fund.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SubscriptionInterest { get; init; } 
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    public PaymentTransaction16? CashSettlementDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "DealRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(DealReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OrderType is FundOrderType1 OrderTypeValue)
        {
            writer.WriteStartElement(null, "OrdrTp", xmlNamespace );
            OrderTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InvstmtAcctDtls", xmlNamespace );
        InvestmentAccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BeneficiaryDetails is IndividualPerson2 BeneficiaryDetailsValue)
        {
            writer.WriteStartElement(null, "BnfcryDtls", xmlNamespace );
            BeneficiaryDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UnitsNb", xmlNamespace );
        UnitsNumber.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Rounding is RoundingDirection2Code RoundingValue)
        {
            writer.WriteStartElement(null, "Rndg", xmlNamespace );
            writer.WriteValue(RoundingValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NetAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NetAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (GrossAmount is IsoActiveCurrencyAndAmount GrossAmountValue)
        {
            writer.WriteStartElement(null, "GrssAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(GrossAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TradDtTm", xmlNamespace );
        TradeDateTime.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PricDtls", xmlNamespace );
        PriceDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrtlyExctdInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PartiallyExecutedIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CumDvddInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CumDividendIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (InterimProfitAmount is ProfitAndLoss1Choice_ InterimProfitAmountValue)
        {
            writer.WriteStartElement(null, "IntrmPrftAmt", xmlNamespace );
            InterimProfitAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms4 ForeignExchangeDetailsValue)
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
        if (LetterIntentReference is IsoMax35Text LetterIntentReferenceValue)
        {
            writer.WriteStartElement(null, "LttrInttRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LetterIntentReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccumulationRightReference is IsoMax35Text AccumulationRightReferenceValue)
        {
            writer.WriteStartElement(null, "AcmltnRghtRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccumulationRightReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ChargeGeneralDetails is TotalCharges2 ChargeGeneralDetailsValue)
        {
            writer.WriteStartElement(null, "ChrgGnlDtls", xmlNamespace );
            ChargeGeneralDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CommissionGeneralDetails is TotalCommissions2 CommissionGeneralDetailsValue)
        {
            writer.WriteStartElement(null, "ComssnGnlDtls", xmlNamespace );
            CommissionGeneralDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxGeneralDetails is TotalTaxes2 TaxGeneralDetailsValue)
        {
            writer.WriteStartElement(null, "TaxGnlDtls", xmlNamespace );
            TaxGeneralDetailsValue.Serialize(writer, xmlNamespace);
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
        if (Refund is IsoActiveCurrencyAndAmount RefundValue)
        {
            writer.WriteStartElement(null, "Rfnd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(RefundValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SubscriptionInterest is IsoActiveCurrencyAndAmount SubscriptionInterestValue)
        {
            writer.WriteStartElement(null, "SbcptIntrst", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SubscriptionInterestValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashSettlementDetails is PaymentTransaction16 CashSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "CshSttlmDtls", xmlNamespace );
            CashSettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubscriptionExecution3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
