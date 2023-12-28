﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FrequencyGranularityType1Code.  ISO2002 ID# __1CBwDy5EeS4E7Ac8_OV3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the granularity of the frequency used for the reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1CBwDy5EeS4E7Ac8_OV3g")]
[Description(@"Defines the granularity of the frequency used for the reporting.")]
[DerivedFrom(typeof(FrequencyGranularityTypeCode))]
public enum FrequencyGranularityType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfMonth".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Bh82kTy6EeS4E7Ac8_OV3g")]
    [Description(@"??")]
    EndOfMonth,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfWeek".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iKUaEUimEeSlHoYg_EudVQ")]
    [Description(@"??")]
    EndOfWeek,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfSemester".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iRnU4UimEeSlHoYg_EudVQ")]
    [Description(@"??")]
    EndOfSemester,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfQuarter".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iZzAgUimEeSlHoYg_EudVQ")]
    [Description(@"??")]
    EndOfQuarter,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfFortnight".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ih07IUimEeSlHoYg_EudVQ")]
    [Description(@"??")]
    EndOfFortnight,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfDay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iqnDsUimEeSlHoYg_EudVQ")]
    [Description(@"??")]
    EndOfDay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfYear".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qoAfQUrvEeSHP9pzU4nIpA")]
    [Description(@"??")]
    EndOfYear,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FrequencyGranularityType1CodeMetadataExtensions
{
    private static readonly FrequencyGranularityType1CodeDropdownSource _dropdownSource = new FrequencyGranularityType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequencyGranularityType1CodeDropdownRow GetMetadata(this FrequencyGranularityType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


