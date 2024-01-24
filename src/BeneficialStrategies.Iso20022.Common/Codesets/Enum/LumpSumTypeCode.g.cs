﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LumpSumTypeCode.  ISO2002 ID# _SbbakLKdEeiXL6Ccd-oU8g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of lump sum.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SbbakLKdEeiXL6Ccd-oU8g")]
[Description(@"Specifies a type of lump sum.")]
[Derivations(typeof(LumpSumType1Code))]
public enum LumpSumTypeCode
{
    /// <summary>
    /// Lump sum is a death benefit lump sum.
    /// Encoded/decoded by serializers as "DEAB".
    /// </summary>
    [EnumMember(Value = "DEAB")]
    [IsoId("_V_DSULKdEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is a death benefit lump sum.")]
    DeathBenefit,
    
    /// <summary>
    /// Lump sum is a pension commencement lump sum.
    /// Encoded/decoded by serializers as "PCLS".
    /// </summary>
    [EnumMember(Value = "PCLS")]
    [IsoId("_10zi8LKdEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is a pension commencement lump sum.")]
    PensionCommencement,
    
    /// <summary>
    /// Lump sum is an uncrystallised fund pension lump sum.
    /// Encoded/decoded by serializers as "UFPL".
    /// </summary>
    [EnumMember(Value = "UFPL")]
    [IsoId("_E5dN4LKeEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is an uncrystallised fund pension lump sum.")]
    Uncrystallised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LumpSumTypeCodeMetadataExtensions
{
    private static readonly LumpSumTypeCodeDropdownSource _dropdownSource = new LumpSumTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILumpSumTypeCodeDropdownRow GetMetadata(this LumpSumTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


