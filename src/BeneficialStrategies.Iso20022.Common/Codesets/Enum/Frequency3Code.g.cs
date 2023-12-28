﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency3Code.  ISO2002 ID# _Yajvh9p-Ed-ak6NoX_4Aeg_560112330.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yajvh9p-Ed-ak6NoX_4Aeg_560112330")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YajviNp-Ed-ak6NoX_4Aeg_-13891401")]
    [Description(@"??")]
    Annual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YatggNp-Ed-ak6NoX_4Aeg_1480230163")]
    [Description(@"??")]
    Monthly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yatggdp-Ed-ak6NoX_4Aeg_-363638826")]
    [Description(@"??")]
    Quarterly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yatggtp-Ed-ak6NoX_4Aeg_397126327")]
    [Description(@"??")]
    SemiAnnual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Weekly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yatgg9p-Ed-ak6NoX_4Aeg_79349666")]
    [Description(@"??")]
    Weekly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YatghNp-Ed-ak6NoX_4Aeg_-34489400")]
    [Description(@"??")]
    Daily,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TenDays".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yatghdp-Ed-ak6NoX_4Aeg_1685625308")]
    [Description(@"??")]
    TenDays,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency3CodeMetadataExtensions
{
    private static readonly Frequency3CodeDropdownSource _dropdownSource = new Frequency3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency3CodeDropdownRow GetMetadata(this Frequency3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

