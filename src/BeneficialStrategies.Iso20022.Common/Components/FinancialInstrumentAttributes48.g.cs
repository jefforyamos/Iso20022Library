﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes48.  ISO2002 ID# _uq-qcSqiEeObprHJy8Zrxg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
public partial record FinancialInstrumentAttributes48
     : IIsoXmlSerilizable<FinancialInstrumentAttributes48>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    public ClassificationType2Choice_? ClassificationType { get; init; } 
    /// <summary>
    /// Specifies how an option can be exercised.
    /// </summary>
    public OptionStyle4Choice_? OptionStyle { get; init; } 
    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    public IsoISODate? NextCouponDate { get; init; } 
    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    public IsoISODate? ExpiryDate { get; init; } 
    /// <summary>
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Date on which the financial instrument is issued.
    /// </summary>
    public IsoISODate? IssueDate { get; init; } 
    /// <summary>
    /// Date on which a financial instrument is called away/redeemed before its scheduled maturity.
    /// </summary>
    public IsoISODate? NextCallableDate { get; init; } 
    /// <summary>
    /// Date on which a holder of a financial instrument has the right to request redemption of the principal amount prior to its scheduled maturity date.
    /// </summary>
    public IsoISODate? PutableDate { get; init; } 
    /// <summary>
    /// Date on which an interest bearing financial instrument begins to accrue interest.
    /// </summary>
    public IsoISODate? DatedDate { get; init; } 
    /// <summary>
    /// Deadline by which a convertible security must be converted, according to the terms of the issue.
    /// </summary>
    public IsoISODate? ConversionDate { get; init; } 
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    public RateFormat3Choice_? InterestRate { get; init; } 
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    public RateFormat3Choice_? NextInterestRate { get; init; } 
    /// <summary>
    /// Percentage of the underlying assets of a fund that represents a debt, for example, in the context of the EU Savings directive.
    /// </summary>
    public RateFormat3Choice_? PercentageOfDebtClaim { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    public RateFormat12Choice_? PreviousFactor { get; init; } 
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    public RateFormat12Choice_? NextFactor { get; init; } 
    /// <summary>
    /// Provides the ratio between the quantity of warrants and the quantity of underlying securities.
    /// </summary>
    public QuantityToQuantityRatio1? WarrantParity { get; init; } 
    /// <summary>
    /// Also known as Minimum Nominal Value. Minimum nominal quantity of financial instrument that must be purchased/sold.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; } 
    
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
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PlaceOfListing is MarketIdentification3Choice_ PlaceOfListingValue)
        {
            writer.WriteStartElement(null, "PlcOfListg", xmlNamespace );
            PlaceOfListingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DayCountBasis is InterestComputationMethodFormat1Choice_ DayCountBasisValue)
        {
            writer.WriteStartElement(null, "DayCntBsis", xmlNamespace );
            DayCountBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClassificationType is ClassificationType2Choice_ ClassificationTypeValue)
        {
            writer.WriteStartElement(null, "ClssfctnTp", xmlNamespace );
            ClassificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionStyle is OptionStyle4Choice_ OptionStyleValue)
        {
            writer.WriteStartElement(null, "OptnStyle", xmlNamespace );
            OptionStyleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DenominationCurrency is ActiveOrHistoricCurrencyCode DenominationCurrencyValue)
        {
            writer.WriteStartElement(null, "DnmtnCcy", xmlNamespace );
            writer.WriteValue(DenominationCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NextCouponDate is IsoISODate NextCouponDateValue)
        {
            writer.WriteStartElement(null, "NxtCpnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(NextCouponDateValue)); // data type ISODate System.DateOnly
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
        if (ConversionDate is IsoISODate ConversionDateValue)
        {
            writer.WriteStartElement(null, "ConvsDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ConversionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (InterestRate is RateFormat3Choice_ InterestRateValue)
        {
            writer.WriteStartElement(null, "IntrstRate", xmlNamespace );
            InterestRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NextInterestRate is RateFormat3Choice_ NextInterestRateValue)
        {
            writer.WriteStartElement(null, "NxtIntrstRate", xmlNamespace );
            NextInterestRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PercentageOfDebtClaim is RateFormat3Choice_ PercentageOfDebtClaimValue)
        {
            writer.WriteStartElement(null, "PctgOfDebtClm", xmlNamespace );
            PercentageOfDebtClaimValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousFactor is RateFormat12Choice_ PreviousFactorValue)
        {
            writer.WriteStartElement(null, "PrvsFctr", xmlNamespace );
            PreviousFactorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NextFactor is RateFormat12Choice_ NextFactorValue)
        {
            writer.WriteStartElement(null, "NxtFctr", xmlNamespace );
            NextFactorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WarrantParity is QuantityToQuantityRatio1 WarrantParityValue)
        {
            writer.WriteStartElement(null, "WarrtParity", xmlNamespace );
            WarrantParityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumNominalQuantity is FinancialInstrumentQuantity1Choice_ MinimumNominalQuantityValue)
        {
            writer.WriteStartElement(null, "MinNmnlQty", xmlNamespace );
            MinimumNominalQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumExercisableQuantity is FinancialInstrumentQuantity1Choice_ MinimumExercisableQuantityValue)
        {
            writer.WriteStartElement(null, "MinExrcblQty", xmlNamespace );
            MinimumExercisableQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumExercisableMultipleQuantity is FinancialInstrumentQuantity1Choice_ MinimumExercisableMultipleQuantityValue)
        {
            writer.WriteStartElement(null, "MinExrcblMltplQty", xmlNamespace );
            MinimumExercisableMultipleQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContractSize is FinancialInstrumentQuantity1Choice_ ContractSizeValue)
        {
            writer.WriteStartElement(null, "CtrctSz", xmlNamespace );
            ContractSizeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrumentAttributes48 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
