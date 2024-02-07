﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes78.  ISO2002 ID# _5TG65ZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements characterising a financial instrument.
/// </summary>
public partial record FinancialInstrumentAttributes78
     : IIsoXmlSerilizable<FinancialInstrumentAttributes78>
{
    #nullable enable
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    public MarketIdentification4Choice_? PlaceOfListing { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; } 
    /// <summary>
    /// Specifies the form, this is, ownership, of the security.
    /// </summary>
    public FormOfSecurity7Choice_? RegistrationForm { get; init; } 
    /// <summary>
    /// Specifies the frequency of an interest payment.
    /// </summary>
    public Frequency27Choice_? PaymentFrequency { get; init; } 
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    public SecuritiesPaymentStatus6Choice_? PaymentStatus { get; init; } 
    /// <summary>
    /// Specifies the frequency of change to the variable rate of an interest bearing instrument.
    /// </summary>
    public Frequency27Choice_? VariableRateChangeFrequency { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    public OptionStyle9Choice_? OptionStyle { get; init; } 
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    public OptionType7Choice_? OptionType { get; init; } 
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    public IsoISODate? CouponDate { get; init; } 
    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    public IsoISODate? ExpiryDate { get; init; } 
    /// <summary>
    /// Date at which the interest rate of an interest bearing security will be calculated and reset, according to the terms of the issue.
    /// </summary>
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    public IsoISODate? IssueDate { get; init; } 
    /// <summary>
    /// Next date at which the issuer has the right to pay the security prior to maturity.
    /// </summary>
    public IsoISODate? NextCallableDate { get; init; } 
    /// <summary>
    /// Date at which the holder has the right to ask for redemption of the security prior to final maturity.
    /// </summary>
    public IsoISODate? PutableDate { get; init; } 
    /// <summary>
    /// First date at which a security begins to accrue interest.
    /// </summary>
    public IsoISODate? DatedDate { get; init; } 
    /// <summary>
    /// Date at which the first interest payment is due to holders of the security.
    /// </summary>
    public IsoISODate? FirstPaymentDate { get; init; } 
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that was applicable before the current factor and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    public IsoBaseOneRate? PreviousFactor { get; init; } 
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 defining the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    public IsoBaseOneRate? CurrentFactor { get; init; } 
    /// <summary>
    /// Rate expressed as a decimal between 0 and 1 that will be applicable as of the next factor date and defines the outstanding principal of the financial instrument (for factored securities).
    /// </summary>
    public IsoBaseOneRate? NextFactor { get; init; } 
    /// <summary>
    /// Per annum ratio of interest paid to the principal amount of the financial instrument for a specific period of time.
    /// </summary>
    public IsoPercentageRate? InterestRate { get; init; } 
    /// <summary>
    /// Rate of return anticipated on a bond when held until maturity date.
    /// </summary>
    public IsoPercentageRate? YieldToMaturityRate { get; init; } 
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    public IsoPercentageRate? NextInterestRate { get; init; } 
    /// <summary>
    /// Specifies the reference rate for fixed income instruments where the |price of the instrument is indexed to the price of an underlying benchmark.
    /// </summary>
    public IsoPercentageRate? IndexRateBasis { get; init; } 
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    public Number23Choice_? CouponAttachedNumber { get; init; } 
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    public GenericIdentification39? PoolNumber { get; init; } 
    /// <summary>
    /// Indicates whether the interest rate of an interest bearing instrument is reset periodically.
    /// </summary>
    public IsoYesNoIndicator? VariableRateIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value per unit or as a percentage.
    /// </summary>
    public PriceType2Choice_? MarketOrIndicativePrice { get; init; } 
    /// <summary>
    /// Predetermined price at which the holder of a derivative will buy or sell the underlying instrument.
    /// </summary>
    public Price3? ExercisePrice { get; init; } 
    /// <summary>
    /// Pre-determined price at which the holder of a right is entitled to buy the underlying instrument.
    /// </summary>
    public Price3? SubscriptionPrice { get; init; } 
    /// <summary>
    /// Price of one target security in the conversion.
    /// </summary>
    public Price3? ConversionPrice { get; init; } 
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    public Price3? StrikePrice { get; init; } 
    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; init; } 
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; init; } 
    /// <summary>
    /// Identification of the underlying security.
    /// </summary>
    public SecurityIdentification20? UnderlyingFinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides additional information about the financial instrument in narrative form.
    /// </summary>
    public IsoRestrictedFINXMax350Text? FinancialInstrumentAttributeAdditionalDetails { get; init; } 
    
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
        if (PlaceOfListing is MarketIdentification4Choice_ PlaceOfListingValue)
        {
            writer.WriteStartElement(null, "PlcOfListg", xmlNamespace );
            PlaceOfListingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DayCountBasis is InterestComputationMethodFormat5Choice_ DayCountBasisValue)
        {
            writer.WriteStartElement(null, "DayCntBsis", xmlNamespace );
            DayCountBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationForm is FormOfSecurity7Choice_ RegistrationFormValue)
        {
            writer.WriteStartElement(null, "RegnForm", xmlNamespace );
            RegistrationFormValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentFrequency is Frequency27Choice_ PaymentFrequencyValue)
        {
            writer.WriteStartElement(null, "PmtFrqcy", xmlNamespace );
            PaymentFrequencyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentStatus is SecuritiesPaymentStatus6Choice_ PaymentStatusValue)
        {
            writer.WriteStartElement(null, "PmtSts", xmlNamespace );
            PaymentStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VariableRateChangeFrequency is Frequency27Choice_ VariableRateChangeFrequencyValue)
        {
            writer.WriteStartElement(null, "VarblRateChngFrqcy", xmlNamespace );
            VariableRateChangeFrequencyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClassificationType is ClassificationType33Choice_ ClassificationTypeValue)
        {
            writer.WriteStartElement(null, "ClssfctnTp", xmlNamespace );
            ClassificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionStyle is OptionStyle9Choice_ OptionStyleValue)
        {
            writer.WriteStartElement(null, "OptnStyle", xmlNamespace );
            OptionStyleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionType is OptionType7Choice_ OptionTypeValue)
        {
            writer.WriteStartElement(null, "OptnTp", xmlNamespace );
            OptionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DenominationCurrency is ActiveOrHistoricCurrencyCode DenominationCurrencyValue)
        {
            writer.WriteStartElement(null, "DnmtnCcy", xmlNamespace );
            writer.WriteValue(DenominationCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CouponDate is IsoISODate CouponDateValue)
        {
            writer.WriteStartElement(null, "CpnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(CouponDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ExpiryDate is IsoISODate ExpiryDateValue)
        {
            writer.WriteStartElement(null, "XpryDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ExpiryDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FloatingRateFixingDate is IsoISODate FloatingRateFixingDateValue)
        {
            writer.WriteStartElement(null, "FltgRateFxgDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FloatingRateFixingDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (MaturityDate is IsoISODate MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (IssueDate is IsoISODate IssueDateValue)
        {
            writer.WriteStartElement(null, "IsseDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(IssueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (NextCallableDate is IsoISODate NextCallableDateValue)
        {
            writer.WriteStartElement(null, "NxtCllblDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(NextCallableDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (PutableDate is IsoISODate PutableDateValue)
        {
            writer.WriteStartElement(null, "PutblDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(PutableDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (DatedDate is IsoISODate DatedDateValue)
        {
            writer.WriteStartElement(null, "DtdDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DatedDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FirstPaymentDate is IsoISODate FirstPaymentDateValue)
        {
            writer.WriteStartElement(null, "FrstPmtDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FirstPaymentDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (PreviousFactor is IsoBaseOneRate PreviousFactorValue)
        {
            writer.WriteStartElement(null, "PrvsFctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(PreviousFactorValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (CurrentFactor is IsoBaseOneRate CurrentFactorValue)
        {
            writer.WriteStartElement(null, "CurFctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(CurrentFactorValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (NextFactor is IsoBaseOneRate NextFactorValue)
        {
            writer.WriteStartElement(null, "NxtFctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(NextFactorValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (InterestRate is IsoPercentageRate InterestRateValue)
        {
            writer.WriteStartElement(null, "IntrstRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(InterestRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (YieldToMaturityRate is IsoPercentageRate YieldToMaturityRateValue)
        {
            writer.WriteStartElement(null, "YldToMtrtyRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(YieldToMaturityRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (NextInterestRate is IsoPercentageRate NextInterestRateValue)
        {
            writer.WriteStartElement(null, "NxtIntrstRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(NextInterestRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (IndexRateBasis is IsoPercentageRate IndexRateBasisValue)
        {
            writer.WriteStartElement(null, "IndxRateBsis", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(IndexRateBasisValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (CouponAttachedNumber is Number23Choice_ CouponAttachedNumberValue)
        {
            writer.WriteStartElement(null, "CpnAttchdNb", xmlNamespace );
            CouponAttachedNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PoolNumber is GenericIdentification39 PoolNumberValue)
        {
            writer.WriteStartElement(null, "PoolNb", xmlNamespace );
            PoolNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VariableRateIndicator is IsoYesNoIndicator VariableRateIndicatorValue)
        {
            writer.WriteStartElement(null, "VarblRateInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(VariableRateIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CallableIndicator is IsoYesNoIndicator CallableIndicatorValue)
        {
            writer.WriteStartElement(null, "CllblInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CallableIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (PutableIndicator is IsoYesNoIndicator PutableIndicatorValue)
        {
            writer.WriteStartElement(null, "PutblInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PutableIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (MarketOrIndicativePrice is PriceType2Choice_ MarketOrIndicativePriceValue)
        {
            writer.WriteStartElement(null, "MktOrIndctvPric", xmlNamespace );
            MarketOrIndicativePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExercisePrice is Price3 ExercisePriceValue)
        {
            writer.WriteStartElement(null, "ExrcPric", xmlNamespace );
            ExercisePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubscriptionPrice is Price3 SubscriptionPriceValue)
        {
            writer.WriteStartElement(null, "SbcptPric", xmlNamespace );
            SubscriptionPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ConversionPrice is Price3 ConversionPriceValue)
        {
            writer.WriteStartElement(null, "ConvsPric", xmlNamespace );
            ConversionPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StrikePrice is Price3 StrikePriceValue)
        {
            writer.WriteStartElement(null, "StrkPric", xmlNamespace );
            StrikePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumNominalQuantity is FinancialInstrumentQuantity15Choice_ MinimumNominalQuantityValue)
        {
            writer.WriteStartElement(null, "MinNmnlQty", xmlNamespace );
            MinimumNominalQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContractSize is FinancialInstrumentQuantity15Choice_ ContractSizeValue)
        {
            writer.WriteStartElement(null, "CtrctSz", xmlNamespace );
            ContractSizeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingFinancialInstrumentIdentification is SecurityIdentification20 UnderlyingFinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "UndrlygFinInstrmId", xmlNamespace );
            UnderlyingFinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentAttributeAdditionalDetails is IsoRestrictedFINXMax350Text FinancialInstrumentAttributeAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(FinancialInstrumentAttributeAdditionalDetailsValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrumentAttributes78 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
