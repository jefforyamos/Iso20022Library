﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalFinancialInstrumentIdentificationType1Code.  ISO2002 ID# _Yajvhtp-Ed-ak6NoX_4Aeg_-705317158.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external financial instrument identification type scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yajvhtp-Ed-ak6NoX_4Aeg_-705317158")]
[Description(@"Specifies the external financial instrument identification type scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalFinancialInstrumentIdentificationTypeCode))]
public enum ExternalFinancialInstrumentIdentificationType1Code
{
    /// <summary>
    /// National securities identification number for BE issued by the National Numbering Association SIX Telekurs Belgium.
    /// Encoded/decoded by serializers as "BELC".
    /// </summary>
    [EnumMember(Value = "BELC")]
    [IsoId("_uI4SM_RYEeuLhpyIdtJzwg")]
    [Description(@"National securities identification number for BE issued by the National Numbering Association SIX Telekurs Belgium.")]
    CodeSRWSecretariaatVoorRoerendeWaardenOrSVMSecrétariatDesValeursMobilières = ExternalFinancialInstrumentIdentificationTypeCode.CodeSRWSecretariaatVoorRoerendeWaardenOrSVMSecrétariatDesValeursMobilières, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by Bloomberg to identify financial instruments.
    /// Encoded/decoded by serializers as "BLOM".
    /// </summary>
    [EnumMember(Value = "BLOM")]
    [IsoId("_uI4SN_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by Bloomberg to identify financial instruments.")]
    Bloomberg = ExternalFinancialInstrumentIdentificationTypeCode.Bloomberg, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National Securities Identification Number issued by the National Numbering Association for a country for which no specific financial instrument identification type code already yet. The first two letters of the code represents the country code (for example, EGDC for Egyptian NSIN). To be used only until the code is added to the ISO ExternalFinancialInstrumentIdentificationType1Code list.
    /// Encoded/decoded by serializers as "CCCD".
    /// </summary>
    [EnumMember(Value = "CCCD")]
    [IsoId("_uI4SO_RYEeuLhpyIdtJzwg")]
    [Description(@"National Securities Identification Number issued by the National Numbering Association for a country for which no specific financial instrument identification type code already yet. The first two letters of the code represents the country code (for example, EGDC for Egyptian NSIN). To be used only until the code is added to the ISO ExternalFinancialInstrumentIdentificationType1Code list.")]
    OtherNationalSecuritiesIdentificationNumber = ExternalFinancialInstrumentIdentificationTypeCode.OtherNationalSecuritiesIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by the Chicago Mercantile Exchange to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as "CMED".
    /// </summary>
    [EnumMember(Value = "CMED")]
    [IsoId("_uJCDM_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by the Chicago Mercantile Exchange to identify listed-derivatives instruments.")]
    ChicagoMercantileExchangeCME = ExternalFinancialInstrumentIdentificationTypeCode.ChicagoMercantileExchangeCME, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National securities identification number for ICSDs issued by the National Numbering Association Clearstream and Euroclear.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uJCDN_RYEeuLhpyIdtJzwg")]
    [Description(@"National securities identification number for ICSDs issued by the National Numbering Association Clearstream and Euroclear.")]
    CommonCode = ExternalFinancialInstrumentIdentificationTypeCode.CommonCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by the Consolidated Tape Association to identify financial instruments.
    /// Encoded/decoded by serializers as "CTAC".
    /// </summary>
    [EnumMember(Value = "CTAC")]
    [IsoId("_uJCDO_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by the Consolidated Tape Association to identify financial instruments.")]
    ConsolidatedTapeAssociationCTA = ExternalFinancialInstrumentIdentificationTypeCode.ConsolidatedTapeAssociationCTA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National securities identification number for US and CA issued by the National Numbering Association Standard & Poor´s - CUSIP Global Services.
    /// Encoded/decoded by serializers as "CUSP".
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_uJLNI_RYEeuLhpyIdtJzwg")]
    [Description(@"National securities identification number for US and CA issued by the National Numbering Association Standard & Poor´s - CUSIP Global Services.")]
    CommitteeOnUniformSecurityIdentificationProceduresCUSIP = ExternalFinancialInstrumentIdentificationTypeCode.CommitteeOnUniformSecurityIdentificationProceduresCUSIP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A Financial Instrument Global Identifier Composite (FIGC) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the composite level, is associated with one or more FIGI venue level ID’s and a single Share Class level ID.
    /// Encoded/decoded by serializers as "FIGC".
    /// </summary>
    [EnumMember(Value = "FIGC")]
    [IsoId("_uJLNJ_RYEeuLhpyIdtJzwg")]
    [Description(@"A Financial Instrument Global Identifier Composite (FIGC) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the composite level, is associated with one or more FIGI venue level ID’s and a single Share Class level ID.")]
    FinancialInstrumentGlobalIdentifierComposite = ExternalFinancialInstrumentIdentificationTypeCode.FinancialInstrumentGlobalIdentifierComposite, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A Financial Instrument Global Identifier Share Class (FIGG) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the global share class level, and is associated with one or more Composite level ID’s.
    /// Encoded/decoded by serializers as "FIGG".
    /// </summary>
    [EnumMember(Value = "FIGG")]
    [IsoId("_uJLNK_RYEeuLhpyIdtJzwg")]
    [Description(@"A Financial Instrument Global Identifier Share Class (FIGG) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the global share class level, and is associated with one or more Composite level ID’s.")]
    FinancialInstrumentGlobalIdentifierShareClass = ExternalFinancialInstrumentIdentificationTypeCode.FinancialInstrumentGlobalIdentifierShareClass, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A Financial Instrument Global Identifier (FIGI) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the venue level. It is associated with one Composite ID.
    /// Encoded/decoded by serializers as "FIGI".
    /// </summary>
    [EnumMember(Value = "FIGI")]
    [IsoId("_uJLNL_RYEeuLhpyIdtJzwg")]
    [Description(@"A Financial Instrument Global Identifier (FIGI) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the venue level. It is associated with one Composite ID.")]
    FinancialInstrumentGlobalIdentifier = ExternalFinancialInstrumentIdentificationTypeCode.FinancialInstrumentGlobalIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// URL in Description to identify OTC derivatives instruments.
    /// Encoded/decoded by serializers as "ISDU".
    /// </summary>
    [EnumMember(Value = "ISDU")]
    [IsoId("_uJU-I_RYEeuLhpyIdtJzwg")]
    [Description(@"URL in Description to identify OTC derivatives instruments.")]
    ISDAAndFpMLProductURLInSecurityID = ExternalFinancialInstrumentIdentificationTypeCode.ISDAAndFpMLProductURLInSecurityID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// XML in Description to identify OTC derivatives instruments.
    /// Encoded/decoded by serializers as "ISDX".
    /// </summary>
    [EnumMember(Value = "ISDX")]
    [IsoId("_uJU-J_RYEeuLhpyIdtJzwg")]
    [Description(@"XML in Description to identify OTC derivatives instruments.")]
    ISDAAndFpMLProductSpecificationXMLInEncodedSecurityDesc = ExternalFinancialInstrumentIdentificationTypeCode.ISDAAndFpMLProductSpecificationXMLInEncodedSecurityDesc, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by LCH to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as "LCHD".
    /// </summary>
    [EnumMember(Value = "LCHD")]
    [IsoId("_uJU-K_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by LCH to identify listed-derivatives instruments.")]
    LCHClearnet = ExternalFinancialInstrumentIdentificationTypeCode.LCHClearnet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by the Options Clearing Corporation to identify financial instruments.
    /// Encoded/decoded by serializers as "OCCS".
    /// </summary>
    [EnumMember(Value = "OCCS")]
    [IsoId("_uJU-L_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by the Options Clearing Corporation to identify financial instruments.")]
    OptionsClearingCorpOCC = ExternalFinancialInstrumentIdentificationTypeCode.OptionsClearingCorpOCC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by the Options Price Reporting Authority to identify financial instruments.
    /// Encoded/decoded by serializers as "OPRA".
    /// </summary>
    [EnumMember(Value = "OPRA")]
    [IsoId("_uJU-M_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by the Options Price Reporting Authority to identify financial instruments.")]
    OptionsPriceReportingAuthorityOPRA = ExternalFinancialInstrumentIdentificationTypeCode.OptionsPriceReportingAuthorityOPRA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by Markit to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as "RCMD".
    /// </summary>
    [EnumMember(Value = "RCMD")]
    [IsoId("_uJeIE_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by Markit to identify listed-derivatives instruments.")]
    MarkitRedCode = ExternalFinancialInstrumentIdentificationTypeCode.MarkitRedCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker-like code assigned by Thomson Reuters to identify financial instruments.
    /// Encoded/decoded by serializers as "RICC".
    /// </summary>
    [EnumMember(Value = "RICC")]
    [IsoId("_uJeIF_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker-like code assigned by Thomson Reuters to identify financial instruments.")]
    ReutersInstrumentCodeRIC = ExternalFinancialInstrumentIdentificationTypeCode.ReutersInstrumentCodeRIC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National securities identification number for GB issued by the National Numbering Association London Stock Exchange.
    /// Encoded/decoded by serializers as "SEDL".
    /// </summary>
    [EnumMember(Value = "SEDL")]
    [IsoId("_uJeIG_RYEeuLhpyIdtJzwg")]
    [Description(@"National securities identification number for GB issued by the National Numbering Association London Stock Exchange.")]
    StockExchangeDailyOfficialListSEDOL = ExternalFinancialInstrumentIdentificationTypeCode.StockExchangeDailyOfficialListSEDOL, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National securities identification number for JP issued by the National Numbering Association 6 Stock Exchanges and JASDEC (Securities Identification Ticker-like code Committee)
    /// Encoded/decoded by serializers as "SICC".
    /// </summary>
    [EnumMember(Value = "SICC")]
    [IsoId("_uJeIH_RYEeuLhpyIdtJzwg")]
    [Description(@"National securities identification number for JP issued by the National Numbering Association 6 Stock Exchanges and JASDEC (Securities Identification Ticker-like code Committee)")]
    SecuritiesIdentificationCodeCommittee = ExternalFinancialInstrumentIdentificationTypeCode.SecuritiesIdentificationCodeCommittee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ticker Code assigned by an exchange to identify financial instruments.
    /// Encoded/decoded by serializers as "TIKR".
    /// </summary>
    [EnumMember(Value = "TIKR")]
    [IsoId("_uJn5E_RYEeuLhpyIdtJzwg")]
    [Description(@"Ticker Code assigned by an exchange to identify financial instruments.")]
    TickerSymbolTS = ExternalFinancialInstrumentIdentificationTypeCode.TickerSymbolTS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National securities identification number for CH and LI issued by the National Numbering Association SIX Telekurs Ltd.
    /// Encoded/decoded by serializers as "VALO".
    /// </summary>
    [EnumMember(Value = "VALO")]
    [IsoId("_uJn5F_RYEeuLhpyIdtJzwg")]
    [Description(@"National securities identification number for CH and LI issued by the National Numbering Association SIX Telekurs Ltd.")]
    VALOR = ExternalFinancialInstrumentIdentificationTypeCode.VALOR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National securities identification number for DE issued by the National Numbering Association WM Datenservice.
    /// Encoded/decoded by serializers as "WKNR".
    /// </summary>
    [EnumMember(Value = "WKNR")]
    [IsoId("_uJn5G_RYEeuLhpyIdtJzwg")]
    [Description(@"National securities identification number for DE issued by the National Numbering Association WM Datenservice.")]
    WertpapierkennummerWKN = ExternalFinancialInstrumentIdentificationTypeCode.WertpapierkennummerWKN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National Bond identification number for China issued by CHINA CENTRAL DEPOSITORY & CLEARING CO., Limited.
    /// Encoded/decoded by serializers as "CCDC".
    /// </summary>
    [EnumMember(Value = "CCDC")]
    [IsoId("_opiOcY5EEeyANo-d7JlQ1A")]
    [Description(@"National Bond identification number for China issued by CHINA CENTRAL DEPOSITORY & CLEARING CO., Limited.")]
    BondIdentificationCodeListChina = ExternalFinancialInstrumentIdentificationTypeCode.BondIdentificationCodeListChina, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Digital Token Identifier, as defined in ISO 24165.
    /// Encoded/decoded by serializers as "DTID".
    /// </summary>
    [EnumMember(Value = "DTID")]
    [IsoId("_8WZMImvWEe2F6NrIyOmXcA")]
    [Description(@"Digital Token Identifier, as defined in ISO 24165.")]
    DigitalTokenIdentifier = ExternalFinancialInstrumentIdentificationTypeCode.DigitalTokenIdentifier, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalFinancialInstrumentIdentificationType1CodeMetadataExtensions
{
    private static readonly ExternalFinancialInstrumentIdentificationType1CodeDropdownSource _dropdownSource = new ExternalFinancialInstrumentIdentificationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalFinancialInstrumentIdentificationType1CodeDropdownRow GetMetadata(this ExternalFinancialInstrumentIdentificationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


