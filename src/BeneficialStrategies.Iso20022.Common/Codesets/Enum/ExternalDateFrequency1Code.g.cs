﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDateFrequency1Code.  ISO2002 ID# _-MOeEW7iEeKo25nLKvGr8w_1230837438.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeEW7iEeKo25nLKvGr8w_1230837438")]
[Description(@"Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDateFrequencyCode))]
public enum ExternalDateFrequency1Code
{
    /// <summary>
    /// Frequency is monthly.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_uO_hRfRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is monthly.")]
    Monthly = ExternalDateFrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is quarterly (every three months).
    /// Encoded/decoded by serializers as "QUTR".
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_uO_hSPRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is quarterly (every three months).")]
    Quarterly = ExternalDateFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is semi-annual (every six months).
    /// Encoded/decoded by serializers as "SEMI".
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_uO_hS_RYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is semi-annual (every six months).")]
    SemiAnnual = ExternalDateFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is two-monthly (every two months).
    /// Encoded/decoded by serializers as "TOMN".
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_uO_hTvRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is two-monthly (every two months).")]
    TwoMonthly = ExternalDateFrequencyCode.TwoMonthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is annual.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_uPIrMvRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is annual.")]
    Annual = ExternalDateFrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDateFrequency1CodeMetadataExtensions
{
    private static readonly ExternalDateFrequency1CodeDropdownSource _dropdownSource = new ExternalDateFrequency1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDateFrequency1CodeDropdownRow GetMetadata(this ExternalDateFrequency1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


