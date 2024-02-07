﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument66.  ISO2002 ID# _SOTuYTf4Eei6RvewLQWEqw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
public partial record FinancialInstrument66
     : IIsoXmlSerilizable<FinancialInstrument66>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in this class in certified form.
    /// </summary>
    public IsoYesNoIndicator? PhysicalBearerSecurities { get; init; } 
    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in paperless form.
    /// </summary>
    public IsoYesNoIndicator? DematerialisedBearerSecurities { get; init; } 
    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    public IsoYesNoIndicator? PhysicalRegisteredSecurities { get; init; } 
    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    public IsoYesNoIndicator? DematerialisedRegisteredSecurities { get; init; } 
    /// <summary>
    /// Income policy relating to the class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    /// <summary>
    /// Dividend policy of the fund, for example, cash, units.
    /// </summary>
    public DividendPolicy1Code? DividendPolicy { get; init; } 
    /// <summary>
    /// Frequency with which the income is allocated to investors.
    /// </summary>
    public EventFrequency5Code? DividendFrequency { get; init; } 
    /// <summary>
    /// Frequency with which the reinvestment takes place, this is the same or less than the dividend frequency.
    /// </summary>
    public EventFrequency5Code? ReinvestmentFrequency { get; init; } 
    /// <summary>
    /// Indicates whether a front end charge on subscription orders for this class can be applied.
    /// </summary>
    public IsoYesNoIndicator? FrontEndLoad { get; init; } 
    /// <summary>
    /// Indicates whether an exit charge (for example, CDSC) on redemption orders for this class can be applied.
    /// </summary>
    public IsoYesNoIndicator? BackEndLoad { get; init; } 
    /// <summary>
    /// Indicates whether a separate fee for switching between sub-funds of the same umbrella can be applied.
    /// </summary>
    public IsoYesNoIndicator? SwitchFee { get; init; } 
    /// <summary>
    /// Indicates whether the investment fund class is subject to the European Union Saving Directive.
    /// </summary>
    public EUSavingsDirective1Code? EUSavingsDirective { get; init; } 
    /// <summary>
    /// Date on which the fund is open for investment.
    /// </summary>
    public IsoISODate? LaunchDate { get; init; } 
    /// <summary>
    /// Date on which the fund is closed to investment.
    /// </summary>
    public IsoISODate? FundEndDate { get; init; } 
    /// <summary>
    /// Date the fund closes.
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    /// <summary>
    /// Date on which the discount period of the newly launched investment fund ends.
    /// </summary>
    public IsoISODate? InitialOfferEndDate { get; init; } 
    /// <summary>
    /// Date on which valuation of the investment fund class is suspended.
    /// </summary>
    public IsoISODate? SuspensionStartDate { get; init; } 
    /// <summary>
    /// Date on which valuation of the investment fund class is unsuspended.
    /// </summary>
    public IsoISODate? SuspensionEndDate { get; init; } 
    /// <summary>
    /// Maturity date of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00065. In EMT v1, the element Maturity Date is reference 05090.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates whether the fund is close-ended.
    /// </summary>
    public IsoYesNoIndicator? ClosedEndFund { get; init; } 
    /// <summary>
    /// Indicates whether equalisation is applied.
    /// </summary>
    public IsoYesNoIndicator? Equalisation { get; init; } 
    /// <summary>
    /// Indicates whether the fund is eligible for a tax efficient product.
    /// </summary>
    public IsoYesNoIndicator? TaxEfficientProductEligible { get; init; } 
    /// <summary>
    /// Indicates whether the fund is authorised by the regulatory compliance authority.
    /// </summary>
    public IsoYesNoIndicator? Authorised { get; init; } 
    /// <summary>
    /// Indicates whether the fund is compliant with the Retail Distribution Review (RDR).
    /// </summary>
    public IsoYesNoIndicator? RDRCompliant { get; init; } 
    /// <summary>
    /// Specifies from where the management fee is taken.
    /// </summary>
    public AnnualChargePaymentType1Code? ManagementFeeSource { get; init; } 
    /// <summary>
    /// Indicates whether there is a performance fee feature. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00045.
    /// </summary>
    public IsoYesNoIndicator? PerformanceFee { get; init; } 
    /// <summary>
    /// Additional information about the fund.
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
        if (PhysicalBearerSecurities is IsoYesNoIndicator PhysicalBearerSecuritiesValue)
        {
            writer.WriteStartElement(null, "PhysBrScties", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PhysicalBearerSecuritiesValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (DematerialisedBearerSecurities is IsoYesNoIndicator DematerialisedBearerSecuritiesValue)
        {
            writer.WriteStartElement(null, "DmtrlsdBrScties", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(DematerialisedBearerSecuritiesValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (PhysicalRegisteredSecurities is IsoYesNoIndicator PhysicalRegisteredSecuritiesValue)
        {
            writer.WriteStartElement(null, "PhysRegdScties", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PhysicalRegisteredSecuritiesValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (DematerialisedRegisteredSecurities is IsoYesNoIndicator DematerialisedRegisteredSecuritiesValue)
        {
            writer.WriteStartElement(null, "DmtrlsdRegdScties", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(DematerialisedRegisteredSecuritiesValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (DistributionPolicy is DistributionPolicy1Code DistributionPolicyValue)
        {
            writer.WriteStartElement(null, "DstrbtnPlcy", xmlNamespace );
            writer.WriteValue(DistributionPolicyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DividendPolicy is DividendPolicy1Code DividendPolicyValue)
        {
            writer.WriteStartElement(null, "DvddPlcy", xmlNamespace );
            writer.WriteValue(DividendPolicyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DividendFrequency is EventFrequency5Code DividendFrequencyValue)
        {
            writer.WriteStartElement(null, "DvddFrqcy", xmlNamespace );
            writer.WriteValue(DividendFrequencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ReinvestmentFrequency is EventFrequency5Code ReinvestmentFrequencyValue)
        {
            writer.WriteStartElement(null, "RinvstmtFrqcy", xmlNamespace );
            writer.WriteValue(ReinvestmentFrequencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (FrontEndLoad is IsoYesNoIndicator FrontEndLoadValue)
        {
            writer.WriteStartElement(null, "FrntEndLd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(FrontEndLoadValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (BackEndLoad is IsoYesNoIndicator BackEndLoadValue)
        {
            writer.WriteStartElement(null, "BckEndLd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(BackEndLoadValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (SwitchFee is IsoYesNoIndicator SwitchFeeValue)
        {
            writer.WriteStartElement(null, "SwtchFee", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SwitchFeeValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (EUSavingsDirective is EUSavingsDirective1Code EUSavingsDirectiveValue)
        {
            writer.WriteStartElement(null, "EUSvgsDrctv", xmlNamespace );
            writer.WriteValue(EUSavingsDirectiveValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (LaunchDate is IsoISODate LaunchDateValue)
        {
            writer.WriteStartElement(null, "LnchDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(LaunchDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FundEndDate is IsoISODate FundEndDateValue)
        {
            writer.WriteStartElement(null, "FndEndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FundEndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TerminationDate is IsoISODate TerminationDateValue)
        {
            writer.WriteStartElement(null, "TermntnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TerminationDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (InitialOfferEndDate is IsoISODate InitialOfferEndDateValue)
        {
            writer.WriteStartElement(null, "InitlOfferEndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(InitialOfferEndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SuspensionStartDate is IsoISODate SuspensionStartDateValue)
        {
            writer.WriteStartElement(null, "SspnsnStartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(SuspensionStartDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SuspensionEndDate is IsoISODate SuspensionEndDateValue)
        {
            writer.WriteStartElement(null, "SspnsnEndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(SuspensionEndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (MaturityDate is IsoISODate MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ClosedEndFund is IsoYesNoIndicator ClosedEndFundValue)
        {
            writer.WriteStartElement(null, "ClsdEndFnd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ClosedEndFundValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Equalisation is IsoYesNoIndicator EqualisationValue)
        {
            writer.WriteStartElement(null, "Equlstn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(EqualisationValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (TaxEfficientProductEligible is IsoYesNoIndicator TaxEfficientProductEligibleValue)
        {
            writer.WriteStartElement(null, "TaxEffcntPdctElgbl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(TaxEfficientProductEligibleValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Authorised is IsoYesNoIndicator AuthorisedValue)
        {
            writer.WriteStartElement(null, "Authrsd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(AuthorisedValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (RDRCompliant is IsoYesNoIndicator RDRCompliantValue)
        {
            writer.WriteStartElement(null, "RDRCmplnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(RDRCompliantValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ManagementFeeSource is AnnualChargePaymentType1Code ManagementFeeSourceValue)
        {
            writer.WriteStartElement(null, "MgmtFeeSrc", xmlNamespace );
            writer.WriteValue(ManagementFeeSourceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PerformanceFee is IsoYesNoIndicator PerformanceFeeValue)
        {
            writer.WriteStartElement(null, "PrfrmncFee", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PerformanceFeeValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrument66 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
