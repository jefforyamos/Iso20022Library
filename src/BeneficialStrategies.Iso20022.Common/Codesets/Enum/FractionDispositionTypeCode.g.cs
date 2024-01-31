﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionDispositionTypeCode.  ISO2002 ID# _arsrs9p-Ed-ak6NoX_4Aeg_1799265079.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that fractional value should be retained; no rounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arsrs9p-Ed-ak6NoX_4Aeg_1799265079")]
[Description(@"Indicates that fractional value should be retained; no rounding.")]
[Derivations(typeof(FractionDispositionType3Code),typeof(FractionDispositionType7Code),typeof(FractionDispositionType1Code),typeof(FractionDispositionType12Code),typeof(FractionDispositionType2Code),typeof(FractionDispositionType5Code),typeof(FractionDispositionType6Code),typeof(FractionDispositionType4Code))]
public enum FractionDispositionTypeCode
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as "BUYU".
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_arsrtNp-Ed-ak6NoX_4Aeg_1809424364")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp,
    
    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as "CINL".
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_arsrtdp-Ed-ak6NoX_4Aeg_-1469668539")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction,
    
    /// <summary>
    /// Pre-allocate shares only if fully dealt.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_arsrttp-Ed-ak6NoX_4Aeg_-2052994838")]
    [Description(@"Pre-allocate shares only if fully dealt.")]
    Full,
    
    /// <summary>
    /// No fractional shares are allowed.
    /// Encoded/decoded by serializers as "NOFR".
    /// </summary>
    [EnumMember(Value = "NOFR")]
    [IsoId("_ar2csNp-Ed-ak6NoX_4Aeg_-2052994807")]
    [Description(@"No fractional shares are allowed.")]
    NoFraction,
    
    /// <summary>
    /// In case of a partial fill, pro-rate the allocations.
    /// Encoded/decoded by serializers as "PROR".
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_ar2csdp-Ed-ak6NoX_4Aeg_-2052994746")]
    [Description(@"In case of a partial fill, pro-rate the allocations.")]
    ProRate,
    
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as "RDUP".
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_ar2cstp-Ed-ak6NoX_4Aeg_-2052994684")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp,
    
    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as "RDDN".
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_ar2cs9p-Ed-ak6NoX_4Aeg_-2052994623")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown,
    
    /// <summary>
    /// If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.
    /// Encoded/decoded by serializers as "STAN".
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_ar2ctNp-Ed-ak6NoX_4Aeg_-2052994345")]
    [Description(@"If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.")]
    RoundToNearest,
    
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as "DIST".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_ar2ctdp-Ed-ak6NoX_4Aeg_-2052994314")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction,
    
    /// <summary>
    /// Do not pro-rate; discuss first.
    /// Encoded/decoded by serializers as "TALK".
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_ar2cttp-Ed-ak6NoX_4Aeg_-2052994253")]
    [Description(@"Do not pro-rate; discuss first.")]
    DiscussFirst,
    
    /// <summary>
    /// Pre-allocate according to the amounts shown in a linked allocation instruction.
    /// Encoded/decoded by serializers as "SPEC".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_ar2ct9p-Ed-ak6NoX_4Aeg_-2052994200")]
    [Description(@"Pre-allocate according to the amounts shown in a linked allocation instruction.")]
    Specific,
    
    /// <summary>
    /// Indicates that if the fraction is greater than or equal to 0.5 of the value should be rounded up; otherwise rounded down.
    /// Encoded/decoded by serializers as "SSTD".
    /// </summary>
    [EnumMember(Value = "SSTD")]
    [IsoId("_ar2cuNp-Ed-ak6NoX_4Aeg_-1405726779")]
    [Description(@"Indicates that if the fraction is greater than or equal to 0.5 of the value should be rounded up; otherwise rounded down.")]
    Standard,
    
    /// <summary>
    /// Indicates that fractional value should be retained; no rounding.
    /// Encoded/decoded by serializers as "RETA".
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_ar2cudp-Ed-ak6NoX_4Aeg_-1405726719")]
    [Description(@"Indicates that fractional value should be retained; no rounding.")]
    Retain,
    
    /// <summary>
    /// Let fractions expire worthless.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_ar2cutp-Ed-ak6NoX_4Aeg_-1309540572")]
    [Description(@"Let fractions expire worthless.")]
    Expire,
    
    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ar_moNp-Ed-ak6NoX_4Aeg_-831003678")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionDispositionTypeCodeMetadataExtensions
{
    private static readonly FractionDispositionTypeCodeDropdownSource _dropdownSource = new FractionDispositionTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionDispositionTypeCodeDropdownRow GetMetadata(this FractionDispositionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


