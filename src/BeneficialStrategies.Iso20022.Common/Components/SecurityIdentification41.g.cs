﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification41.  ISO2002 ID# _-tqH8dANEeuSBa1PsnseFg.
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
public partial record SecurityIdentification41
     : IIsoXmlSerilizable<SecurityIdentification41>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the security, typically by an ISIN.
    /// </summary>
    public required SecurityIdentification40 Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, 'Class A', 'Class 2'.
    /// </summary>
    public IsoMax35Text? ClassType { get; init; } 
    /// <summary>
    /// Name of the umbrella fund in which the financial instrument is contained.
    /// </summary>
    public IsoMax35Text? UmbrellaName { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is part of a new umbrella.
    /// </summary>
    public IsoYesNoIndicator? NewUmbrella { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    public SecurityClassificationType2Choice_? ClassificationType { get; init; } 
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    public ActiveCurrencyCode? BaseCurrency { get; init; } 
    /// <summary>
    /// Country where the fund has legal domicile.
    /// </summary>
    public CountryCode? CountryOfDomicile { get; init; } 
    /// <summary>
    /// Country where the fund is registered for distribution.
    /// </summary>
    public CountryCode? RegisteredDistributionCountry { get; init; } 
    /// <summary>
    /// Classification of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00060.
    /// </summary>
    public ProductStructure1Choice_? ProductType { get; init; } 
    /// <summary>
    /// Issuer of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00070.
    /// </summary>
    public ContactAttributes5? Issuer { get; init; } 
    /// <summary>
    /// Governance procedure that must be followed. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00075.
    /// </summary>
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; init; } 
    /// <summary>
    /// Designation of the product category or nature, for example, Pacific Equity, Equity Fund, Money Market Fund. If the product is a structured security product, the European Structured Investment Products Association (EUSIPA) code should be used as defined in the scope of European MiFID Template (EMT) reference 00095. 
    /// </summary>
    public IsoMax140Text? ProductCategory { get; init; } 
    /// <summary>
    /// Designation of the respective product category or nature for Germany.
    /// If the financial instrument is distributed in the German market, then the German classification of financial instruments code should be used. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00090.
    /// </summary>
    public IsoMax140Text? ProductCategoryGermany { get; init; } 
    /// <summary>
    /// Specifies whether the financial instrument is unit based or notional (nominal). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00085.
    /// </summary>
    public NotionalOrUnitBased1Choice_? NotionalOrUnitBased { get; init; } 
    /// <summary>
    /// When the financial instrument is a structured security, specifies if the ex-ante and ex-post costs and charges are specified as an absolute figure, that is, a currency and amount, or as a percentage rate, related to the specific reference value. 
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template reference 00096.
    /// </summary>
    public QuotationType1Choice_? QuotationType { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is leveraged or has contingent liability. This enables reporting on the depreciation of leveraged financial instruments or contingent liability transactions in accordance with Art. 62 of the MiFID II's Delegated Regulation as defined in the scope of European MiFID Template (EMT) reference 00100.
    /// </summary>
    public IsoYesNoIndicator? LeveragedOrContigentLiability { get; init; } 
    /// <summary>
    /// Indicates whether the share class does not pay retrocession fees and commissions. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00110.
    /// </summary>
    public IsoYesNoIndicator? NoRetrocessionIndicator { get; init; } 
    /// <summary>
    /// Specifies the basis for ex-post calculations. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00120.
    /// </summary>
    public ExPostCostCalculationBasis1Choice_? ExPostCostCalculationBasis { get; init; } 
    /// <summary>
    /// Additional information about the security.
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(Name)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (ShortName is IsoMax35Text ShortNameValue)
        {
            writer.WriteStartElement(null, "ShrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ShortNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClassType is IsoMax35Text ClassTypeValue)
        {
            writer.WriteStartElement(null, "ClssTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClassTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (UmbrellaName is IsoMax35Text UmbrellaNameValue)
        {
            writer.WriteStartElement(null, "UmbrllNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(UmbrellaNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (NewUmbrella is IsoYesNoIndicator NewUmbrellaValue)
        {
            writer.WriteStartElement(null, "NewUmbrll", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(NewUmbrellaValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ClassificationType is SecurityClassificationType2Choice_ ClassificationTypeValue)
        {
            writer.WriteStartElement(null, "ClssfctnTp", xmlNamespace );
            ClassificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BaseCurrency is ActiveCurrencyCode BaseCurrencyValue)
        {
            writer.WriteStartElement(null, "BaseCcy", xmlNamespace );
            writer.WriteValue(BaseCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CountryOfDomicile is CountryCode CountryOfDomicileValue)
        {
            writer.WriteStartElement(null, "CtryOfDmcl", xmlNamespace );
            writer.WriteValue(CountryOfDomicileValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RegisteredDistributionCountry is CountryCode RegisteredDistributionCountryValue)
        {
            writer.WriteStartElement(null, "RegdDstrbtnCtry", xmlNamespace );
            writer.WriteValue(RegisteredDistributionCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ProductType is ProductStructure1Choice_ ProductTypeValue)
        {
            writer.WriteStartElement(null, "PdctTp", xmlNamespace );
            ProductTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Issuer is ContactAttributes5 IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            IssuerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerProductGovernanceProcess is GovernanceProcess1Choice_ IssuerProductGovernanceProcessValue)
        {
            writer.WriteStartElement(null, "IssrPdctGovncPrc", xmlNamespace );
            IssuerProductGovernanceProcessValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProductCategory is IsoMax140Text ProductCategoryValue)
        {
            writer.WriteStartElement(null, "PdctCtgy", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ProductCategoryValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (ProductCategoryGermany is IsoMax140Text ProductCategoryGermanyValue)
        {
            writer.WriteStartElement(null, "PdctCtgyDE", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ProductCategoryGermanyValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (NotionalOrUnitBased is NotionalOrUnitBased1Choice_ NotionalOrUnitBasedValue)
        {
            writer.WriteStartElement(null, "NtnlOrUnitBased", xmlNamespace );
            NotionalOrUnitBasedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuotationType is QuotationType1Choice_ QuotationTypeValue)
        {
            writer.WriteStartElement(null, "QtnTp", xmlNamespace );
            QuotationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LeveragedOrContigentLiability is IsoYesNoIndicator LeveragedOrContigentLiabilityValue)
        {
            writer.WriteStartElement(null, "LvrgdOrCntgntLblty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(LeveragedOrContigentLiabilityValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (NoRetrocessionIndicator is IsoYesNoIndicator NoRetrocessionIndicatorValue)
        {
            writer.WriteStartElement(null, "NoRtrcssnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(NoRetrocessionIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ExPostCostCalculationBasis is ExPostCostCalculationBasis1Choice_ ExPostCostCalculationBasisValue)
        {
            writer.WriteStartElement(null, "ExPstCostClctnBsis", xmlNamespace );
            ExPostCostCalculationBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecurityIdentification41 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
