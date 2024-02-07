﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxEfficientProduct5.  ISO2002 ID# _aNbAIZNNEemQB_8XA98K0Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a tax efficient product.
/// </summary>
public partial record TaxEfficientProduct5
     : IIsoXmlSerilizable<TaxEfficientProduct5>
{
    #nullable enable
    
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    /// <summary>
    /// Indicates that all the current fiscal year’s products are included.
    /// </summary>
    public IsoYesNoIndicator? CurrentYear { get; init; } 
    /// <summary>
    /// Indicates whether, for the current year, the product contains a cash asset for transfer.
    /// </summary>
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    public PreviousYear4? PreviousYears { get; init; } 
    /// <summary>
    /// Subscriptions from the previous subscription year.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? PreviousYearSubscriptionAmount { get; init; } 
    /// <summary>
    /// Amount subscribed in all previous years.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? PreviousYearsSubscriptionAmount { get; init; } 
    /// <summary>
    /// Date the investment plan started.
    /// </summary>
    public IsoISODate? DateOfFirstSubscription { get; init; } 
    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    /// <summary>
    /// Bonus paid out or withdrawn.
    /// </summary>
    public BonusWithdrawal2? BonusOrWithdrawal { get; init; } 
    /// <summary>
    /// Alternative identification for the transferor (ceding party), for example, the 'ISA manager Z reference' in the UK. 
    /// </summary>
    public IsoMax35Text? TransferorAlternateIdentification { get; init; } 
    /// <summary>
    /// Total amount subscribed over the lifetime of the product.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    /// <summary>
    /// Another amount such as the total qualifying additions in the year of transfer, interest capitalised in the current year, total outstanding dividend and so on.
    /// </summary>
    public OtherAmount3? OtherAmount { get; init; } 
    /// <summary>
    /// Date the first qualifying additional amount was made to the product.  Qualifying additional amounts may be made to a Lifetime Individual Savings Account (LISA) product.
    /// </summary>
    public IsoISODate? DateFirstQualifyingAddition { get; init; } 
    /// <summary>
    /// Identification of the investor as assigned by a tax authority. 
    /// </summary>
    public TaxReference2? InvestorTaxReference { get; init; } 
    /// <summary>
    /// Value of the investments to follow.
    /// </summary>
    public DateAndAmount2? InvestmentsToFollowValue { get; init; } 
    /// <summary>
    /// Information about an innovative finance product.
    /// </summary>
    public InnovativeFinance1? InnovativeFinance { get; init; } 
    /// <summary>
    /// Lowest investment amount in the current year, used to calculate a tax deduction amount.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; init; } 
    /// <summary>
    /// Amount of money from which the tax deduction is calculated. 
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; init; } 
    /// <summary>
    /// Unused tax deduction amount.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; init; } 
    /// <summary>
    /// Amount of money invested.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
    /// <summary>
    /// Estimated value of the assets of the tax efficient product to be transferred.
    /// </summary>
    public DateAndAmount2? EstimatedValue { get; init; } 
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "TaxEffcntPdctTp", xmlNamespace );
        TaxEfficientProductType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CurrentYear is IsoYesNoIndicator CurrentYearValue)
        {
            writer.WriteStartElement(null, "CurYr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CurrentYearValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CashComponentIndicator is IsoYesNoIndicator CashComponentIndicatorValue)
        {
            writer.WriteStartElement(null, "CshCmpntInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CashComponentIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (PreviousYears is PreviousYear4 PreviousYearsValue)
        {
            writer.WriteStartElement(null, "PrvsYrs", xmlNamespace );
            PreviousYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousYearSubscriptionAmount is IsoActiveCurrencyAnd13DecimalAmount PreviousYearSubscriptionAmountValue)
        {
            writer.WriteStartElement(null, "PrvsYrSbcptAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(PreviousYearSubscriptionAmountValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PreviousYearsSubscriptionAmount is IsoActiveCurrencyAnd13DecimalAmount PreviousYearsSubscriptionAmountValue)
        {
            writer.WriteStartElement(null, "PrvsYrsSbcptAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(PreviousYearsSubscriptionAmountValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (DateOfFirstSubscription is IsoISODate DateOfFirstSubscriptionValue)
        {
            writer.WriteStartElement(null, "DtOfFrstSbcpt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateOfFirstSubscriptionValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (CurrentYearSubscriptionDetails is SubscriptionInformation2 CurrentYearSubscriptionDetailsValue)
        {
            writer.WriteStartElement(null, "CurYrSbcptDtls", xmlNamespace );
            CurrentYearSubscriptionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BonusOrWithdrawal is BonusWithdrawal2 BonusOrWithdrawalValue)
        {
            writer.WriteStartElement(null, "BnsOrWdrwl", xmlNamespace );
            BonusOrWithdrawalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransferorAlternateIdentification is IsoMax35Text TransferorAlternateIdentificationValue)
        {
            writer.WriteStartElement(null, "TrfrAltrnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferorAlternateIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TotalSubscriptionAmount is IsoActiveCurrencyAndAmount TotalSubscriptionAmountValue)
        {
            writer.WriteStartElement(null, "TtlSbcptAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalSubscriptionAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OtherAmount is OtherAmount3 OtherAmountValue)
        {
            writer.WriteStartElement(null, "OthrAmt", xmlNamespace );
            OtherAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DateFirstQualifyingAddition is IsoISODate DateFirstQualifyingAdditionValue)
        {
            writer.WriteStartElement(null, "DtFrstQlfygAddtn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateFirstQualifyingAdditionValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (InvestorTaxReference is TaxReference2 InvestorTaxReferenceValue)
        {
            writer.WriteStartElement(null, "InvstrTaxRef", xmlNamespace );
            InvestorTaxReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentsToFollowValue is DateAndAmount2 InvestmentsToFollowValueValue)
        {
            writer.WriteStartElement(null, "InvstmtsToFllwVal", xmlNamespace );
            InvestmentsToFollowValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InnovativeFinance is InnovativeFinance1 InnovativeFinanceValue)
        {
            writer.WriteStartElement(null, "InnvtvFinc", xmlNamespace );
            InnovativeFinanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LowestInvestedAmountCurrentYear is IsoActiveCurrencyAnd13DecimalAmount LowestInvestedAmountCurrentYearValue)
        {
            writer.WriteStartElement(null, "LwstInvstdAmtCurYr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(LowestInvestedAmountCurrentYearValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxCalculationBase is IsoActiveCurrencyAnd13DecimalAmount TaxCalculationBaseValue)
        {
            writer.WriteStartElement(null, "TaxClctnBase", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(TaxCalculationBaseValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (UnusedTaxDeduction is IsoActiveCurrencyAnd13DecimalAmount UnusedTaxDeductionValue)
        {
            writer.WriteStartElement(null, "UusdTaxDdctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(UnusedTaxDeductionValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CurrentInvestmentAmount is IsoActiveCurrencyAnd13DecimalAmount CurrentInvestmentAmountValue)
        {
            writer.WriteStartElement(null, "CurInvstmtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(CurrentInvestmentAmountValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (EstimatedValue is DateAndAmount2 EstimatedValueValue)
        {
            writer.WriteStartElement(null, "EstmtdVal", xmlNamespace );
            EstimatedValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TaxEfficientProduct5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
