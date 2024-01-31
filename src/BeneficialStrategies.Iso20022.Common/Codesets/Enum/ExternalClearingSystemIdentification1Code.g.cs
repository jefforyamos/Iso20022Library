﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalClearingSystemIdentification1Code.  ISO2002 ID# _amVqlNp-Ed-ak6NoX_4Aeg_319823369.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing system identification code, as published in an external clearing system identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amVqlNp-Ed-ak6NoX_4Aeg_319823369")]
[Description(@"Specifies the clearing system identification code, as published in an external clearing system identification code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalClearingSystemIdentificationCode))]
public enum ExternalClearingSystemIdentification1Code
{
    /// <summary>
    /// Bank Branch code used in Austria
    /// Encoded/decoded by serializers as "ATBLZ".
    /// </summary>
    [EnumMember(Value = "ATBLZ")]
    [IsoId("_tlQnxfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Austria")]
    AustrianBankleitzahl = ExternalClearingSystemIdentificationCode.AustrianBankleitzahl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Australia
    /// Encoded/decoded by serializers as "AUBSB".
    /// </summary>
    [EnumMember(Value = "AUBSB")]
    [IsoId("_tlQnyPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Australia")]
    AustralianBankStateBranchCodeBSB = ExternalClearingSystemIdentificationCode.AustralianBankStateBranchCodeBSB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Canada
    /// Encoded/decoded by serializers as "CACPA".
    /// </summary>
    [EnumMember(Value = "CACPA")]
    [IsoId("_tlQny_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Canada")]
    CanadianPaymentsAssociationPaymentRoutingNumber = ExternalClearingSystemIdentificationCode.CanadianPaymentsAssociationPaymentRoutingNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial Institution Identification (IID) used in Switzerland, without check digit
    /// Encoded/decoded by serializers as "CHBCC".
    /// </summary>
    [EnumMember(Value = "CHBCC")]
    [IsoId("_tlQnzvRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Institution Identification (IID) used in Switzerland, without check digit")]
    SwissFinancialInstitutionIdentificationShort = ExternalClearingSystemIdentificationCode.SwissFinancialInstitutionIdentificationShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial Institution Identification (IID) used in Switzerland, including check digit
    /// Encoded/decoded by serializers as "CHSIC".
    /// </summary>
    [EnumMember(Value = "CHSIC")]
    [IsoId("_tlQn0fRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Institution Identification (IID) used in Switzerland, including check digit")]
    SwissFinancialInstitutionIdentificationLong = ExternalClearingSystemIdentificationCode.SwissFinancialInstitutionIdentificationLong, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in China
    /// Encoded/decoded by serializers as "CNAPS".
    /// </summary>
    [EnumMember(Value = "CNAPS")]
    [IsoId("_tlaYwvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in China")]
    CNAPSIdentifier = ExternalClearingSystemIdentificationCode.CNAPSIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Germany
    /// Encoded/decoded by serializers as "DEBLZ".
    /// </summary>
    [EnumMember(Value = "DEBLZ")]
    [IsoId("_tlaYxfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Germany")]
    GermanBankleitzahl = ExternalClearingSystemIdentificationCode.GermanBankleitzahl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Spain
    /// Encoded/decoded by serializers as "ESNCC".
    /// </summary>
    [EnumMember(Value = "ESNCC")]
    [IsoId("_tlaYyPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Spain")]
    SpanishDomesticInterbankingCode = ExternalClearingSystemIdentificationCode.SpanishDomesticInterbankingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in the UK
    /// Encoded/decoded by serializers as "GBDSC".
    /// </summary>
    [EnumMember(Value = "GBDSC")]
    [IsoId("_tlaYy_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in the UK")]
    UKDomesticSortCode = ExternalClearingSystemIdentificationCode.UKDomesticSortCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Greece
    /// Encoded/decoded by serializers as "GRBIC".
    /// </summary>
    [EnumMember(Value = "GRBIC")]
    [IsoId("_tlkJwvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Greece")]
    HelenicBankIdentificationCode = ExternalClearingSystemIdentificationCode.HelenicBankIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Hong Kong
    /// Encoded/decoded by serializers as "HKNCC".
    /// </summary>
    [EnumMember(Value = "HKNCC")]
    [IsoId("_tlkJxfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Hong Kong")]
    HongKongBankCode = ExternalClearingSystemIdentificationCode.HongKongBankCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Ireland
    /// Encoded/decoded by serializers as "IENCC".
    /// </summary>
    [EnumMember(Value = "IENCC")]
    [IsoId("_tlkJyPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Ireland")]
    IrishNationalClearingCode = ExternalClearingSystemIdentificationCode.IrishNationalClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in India
    /// Encoded/decoded by serializers as "INFSC".
    /// </summary>
    [EnumMember(Value = "INFSC")]
    [IsoId("_tlkJy_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in India")]
    IndianFinancialSystemCode = ExternalClearingSystemIdentificationCode.IndianFinancialSystemCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Italy
    /// Encoded/decoded by serializers as "ITNCC".
    /// </summary>
    [EnumMember(Value = "ITNCC")]
    [IsoId("_tlkJzvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Italy")]
    ItalianDomesticIdentificationCode = ExternalClearingSystemIdentificationCode.ItalianDomesticIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Japan
    /// Encoded/decoded by serializers as "JPZGN".
    /// </summary>
    [EnumMember(Value = "JPZGN")]
    [IsoId("_tltTsvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Japan")]
    JapanZenginClearingCode = ExternalClearingSystemIdentificationCode.JapanZenginClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in New Zealand
    /// Encoded/decoded by serializers as "NZNCC".
    /// </summary>
    [EnumMember(Value = "NZNCC")]
    [IsoId("_tltTtfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in New Zealand")]
    NewZealandNationalClearingCode = ExternalClearingSystemIdentificationCode.NewZealandNationalClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Poland
    /// Encoded/decoded by serializers as "PLKNR".
    /// </summary>
    [EnumMember(Value = "PLKNR")]
    [IsoId("_tltTuPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Poland")]
    PolishNationalClearingCode = ExternalClearingSystemIdentificationCode.PolishNationalClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Portugal
    /// Encoded/decoded by serializers as "PTNCC".
    /// </summary>
    [EnumMember(Value = "PTNCC")]
    [IsoId("_tltTu_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Portugal")]
    PortugueseNationalClearingCode = ExternalClearingSystemIdentificationCode.PortugueseNationalClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Russia
    /// Encoded/decoded by serializers as "RUCBC".
    /// </summary>
    [EnumMember(Value = "RUCBC")]
    [IsoId("_tltTvvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Russia")]
    RussianCentralBankIdentificationCode = ExternalClearingSystemIdentificationCode.RussianCentralBankIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Sweden
    /// Encoded/decoded by serializers as "SESBA".
    /// </summary>
    [EnumMember(Value = "SESBA")]
    [IsoId("_tl3EsvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Sweden")]
    SwedenBankgiroClearingCode = ExternalClearingSystemIdentificationCode.SwedenBankgiroClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Singapore
    /// Encoded/decoded by serializers as "SGIBG".
    /// </summary>
    [EnumMember(Value = "SGIBG")]
    [IsoId("_tl3EtfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Singapore")]
    IBGSortCode = ExternalClearingSystemIdentificationCode.IBGSortCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Identification code used in Thailand
    /// Encoded/decoded by serializers as "THCBC".
    /// </summary>
    [EnumMember(Value = "THCBC")]
    [IsoId("_tl3EuPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Identification code used in Thailand")]
    ThaiCentralBankIdentificationCode = ExternalClearingSystemIdentificationCode.ThaiCentralBankIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in Taiwan
    /// Encoded/decoded by serializers as "TWNCC".
    /// </summary>
    [EnumMember(Value = "TWNCC")]
    [IsoId("_tl3Eu_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Taiwan")]
    FinancialInstitutionCode = ExternalClearingSystemIdentificationCode.FinancialInstitutionCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Routing Transit number assigned by the ABA for US financial institutons
    /// Encoded/decoded by serializers as "USABA".
    /// </summary>
    [EnumMember(Value = "USABA")]
    [IsoId("_tl3EvvRYEeuLhpyIdtJzwg")]
    [Description(@"Routing Transit number assigned by the ABA for US financial institutons")]
    UnitedStatesRoutingNumberFedwireNACHA = ExternalClearingSystemIdentificationCode.UnitedStatesRoutingNumberFedwireNACHA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank identifier used by CHIPs in the US
    /// Encoded/decoded by serializers as "USPID".
    /// </summary>
    [EnumMember(Value = "USPID")]
    [IsoId("_tmA1svRYEeuLhpyIdtJzwg")]
    [Description(@"Bank identifier used by CHIPs in the US")]
    CHIPSParticipantIdentifier = ExternalClearingSystemIdentificationCode.CHIPSParticipantIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Branch code used in South Africa
    /// Encoded/decoded by serializers as "ZANCC".
    /// </summary>
    [EnumMember(Value = "ZANCC")]
    [IsoId("_tmA1tfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in South Africa")]
    SouthAfricanNationalClearingCode = ExternalClearingSystemIdentificationCode.SouthAfricanNationalClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RTGS settlement account used in New Zealand.
    /// Encoded/decoded by serializers as "NZRSA".
    /// </summary>
    [EnumMember(Value = "NZRSA")]
    [IsoId("_c_XdsQTZEey95qpfbNuEwg")]
    [Description(@"RTGS settlement account used in New Zealand.")]
    NewZealandRTGSClearingCode = ExternalClearingSystemIdentificationCode.NewZealandRTGSClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Banco de Mocambique RTGS system.
    /// Encoded/decoded by serializers as "MZBMO".
    /// </summary>
    [EnumMember(Value = "MZBMO")]
    [IsoId("_v84qEmvcEe2F6NrIyOmXcA")]
    [Description(@"Banco de Mocambique RTGS system.")]
    BancoDeMocambiqueRTGS = ExternalClearingSystemIdentificationCode.BancoDeMocambiqueRTGS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Chinese Cross-border Interbank Payment System (CIPS) Identifier.
    /// Encoded/decoded by serializers as "CNCIP".
    /// </summary>
    [EnumMember(Value = "CNCIP")]
    [IsoId("_LNkXkmveEe2F6NrIyOmXcA")]
    [Description(@"Chinese Cross-border Interbank Payment System (CIPS) Identifier.")]
    CrossBorderInterbankPaymentSystem = ExternalClearingSystemIdentificationCode.CrossBorderInterbankPaymentSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant Institution code used by BOK-Wire+ in South Korea.
    /// Encoded/decoded by serializers as "KRBOK".
    /// </summary>
    [EnumMember(Value = "KRBOK")]
    [IsoId("_BwCmYv7MEe2ORYPQEd-Clg")]
    [Description(@"Participant Institution code used by BOK-Wire+ in South Korea.")]
    SouthKoreaCentralBankIdentificationCode = ExternalClearingSystemIdentificationCode.SouthKoreaCentralBankIdentificationCode, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalClearingSystemIdentification1CodeMetadataExtensions
{
    private static readonly ExternalClearingSystemIdentification1CodeDropdownSource _dropdownSource = new ExternalClearingSystemIdentification1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalClearingSystemIdentification1CodeDropdownRow GetMetadata(this ExternalClearingSystemIdentification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


