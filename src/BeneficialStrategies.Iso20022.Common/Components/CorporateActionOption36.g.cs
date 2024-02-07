﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption36.  ISO2002 ID# _nmltofmUEeCcAY_zfcalaA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption36
     : IIsoXmlSerilizable<CorporateActionOption36>
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IsoExact3NumericText OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption10Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType1Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    public OfferTypeFormat1Choice_? OfferType { get; init; } 
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public OptionFeaturesFormat9Choice_? OptionFeatures { get; init; } 
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; init; } 
    /// <summary>
    /// Indicates the type of certification/breakdown.
    /// </summary>
    public BeneficiaryCertificationType5Choice_? CertificationBreakdownType { get; init; } 
    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    public CountryCode? NonDomicileCountry { get; init; } 
    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    public CountryCode? ValidDomicileCountry { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    /// <summary>
    /// Whether or not certification/breakdown is required from the account owner. 
    /// Yes: certification required 
    /// No: no certification required.
    /// </summary>
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; } 
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    public CorporateActionDate15? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    public CorporateActionPeriod7? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate25? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice28? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public SecuritiesOption23? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    public SecuritiesOption25? SecuritiesMovementDetails { get; init; } 
    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    public CashOption17? CashMovementDetails { get; init; } 
    /// <summary>
    /// Provides additional information.
    /// </summary>
    public CorporateActionNarrative20? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "OptnNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact3NumericText(OptionNumber)); // data type Exact3NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OptnTp", xmlNamespace );
        OptionType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FractionDisposition is FractionDispositionType1Choice_ FractionDispositionValue)
        {
            writer.WriteStartElement(null, "FrctnDspstn", xmlNamespace );
            FractionDispositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OfferType is OfferTypeFormat1Choice_ OfferTypeValue)
        {
            writer.WriteStartElement(null, "OfferTp", xmlNamespace );
            OfferTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionFeatures is OptionFeaturesFormat9Choice_ OptionFeaturesValue)
        {
            writer.WriteStartElement(null, "OptnFeatrs", xmlNamespace );
            OptionFeaturesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionAvailabilityStatus is OptionAvailabilityStatus1Choice_ OptionAvailabilityStatusValue)
        {
            writer.WriteStartElement(null, "OptnAvlbtySts", xmlNamespace );
            OptionAvailabilityStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CertificationBreakdownType is BeneficiaryCertificationType5Choice_ CertificationBreakdownTypeValue)
        {
            writer.WriteStartElement(null, "CertfctnBrkdwnTp", xmlNamespace );
            CertificationBreakdownTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NonDomicileCountry is CountryCode NonDomicileCountryValue)
        {
            writer.WriteStartElement(null, "NonDmclCtry", xmlNamespace );
            writer.WriteValue(NonDomicileCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ValidDomicileCountry is CountryCode ValidDomicileCountryValue)
        {
            writer.WriteStartElement(null, "VldDmclCtry", xmlNamespace );
            writer.WriteValue(ValidDomicileCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CurrencyOption is ActiveCurrencyCode CurrencyOptionValue)
        {
            writer.WriteStartElement(null, "CcyOptn", xmlNamespace );
            writer.WriteValue(CurrencyOptionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DfltPrcgOrStgInstr", xmlNamespace );
        DefaultProcessingOrStandingInstruction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ChargesAppliedIndicator is IsoYesNoIndicator ChargesAppliedIndicatorValue)
        {
            writer.WriteStartElement(null, "ChrgsApldInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ChargesAppliedIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CertificationBreakdownIndicator is IsoYesNoIndicator CertificationBreakdownIndicatorValue)
        {
            writer.WriteStartElement(null, "CertfctnBrkdwnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CertificationBreakdownIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (WithdrawalAllowedIndicator is IsoYesNoIndicator WithdrawalAllowedIndicatorValue)
        {
            writer.WriteStartElement(null, "WdrwlAllwdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(WithdrawalAllowedIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ChangeAllowedIndicator is IsoYesNoIndicator ChangeAllowedIndicatorValue)
        {
            writer.WriteStartElement(null, "ChngAllwdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ChangeAllowedIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (FinancialInstrumentIdentification is SecurityIdentification14 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DateDetails is CorporateActionDate15 DateDetailsValue)
        {
            writer.WriteStartElement(null, "DtDtls", xmlNamespace );
            DateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PeriodDetails is CorporateActionPeriod7 PeriodDetailsValue)
        {
            writer.WriteStartElement(null, "PrdDtls", xmlNamespace );
            PeriodDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateAndAmountDetails is CorporateActionRate25 RateAndAmountDetailsValue)
        {
            writer.WriteStartElement(null, "RateAndAmtDtls", xmlNamespace );
            RateAndAmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is CorporateActionPrice28 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesQuantity is SecuritiesOption23 SecuritiesQuantityValue)
        {
            writer.WriteStartElement(null, "SctiesQty", xmlNamespace );
            SecuritiesQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementDetails is SecuritiesOption25 SecuritiesMovementDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntDtls", xmlNamespace );
            SecuritiesMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashMovementDetails is CashOption17 CashMovementDetailsValue)
        {
            writer.WriteStartElement(null, "CshMvmntDtls", xmlNamespace );
            CashMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is CorporateActionNarrative20 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionOption36 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
