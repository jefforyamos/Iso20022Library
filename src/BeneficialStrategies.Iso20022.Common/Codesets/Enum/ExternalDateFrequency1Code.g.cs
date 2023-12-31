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
[Description(@"Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDateFrequencyCode))]
public enum ExternalDateFrequency1Code
{
    /// <summary>
    /// Frequency is monthly.
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_uO_hRfRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is monthly.")]
    Monthly,
    
    /// <summary>
    /// Frequency is quarterly (every three months).
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_uO_hSPRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is quarterly (every three months).")]
    Quarterly,
    
    /// <summary>
    /// Frequency is semi-annual (every six months).
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_uO_hS_RYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is semi-annual (every six months).")]
    SemiAnnual,
    
    /// <summary>
    /// Frequency is two-monthly (every two months).
    /// Encoded/decoded by serializers as "TwoMonthly".
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_uO_hTvRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is two-monthly (every two months).")]
    TwoMonthly,
    
    /// <summary>
    /// Frequency is annual.
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_uPIrMvRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is annual.")]
    Annual,
    
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


