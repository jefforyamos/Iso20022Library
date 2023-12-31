﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QualityIndicationCode.  ISO2002 ID# _ZXWu8Np-Ed-ak6NoX_4Aeg_336258088.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the relative quality of the indication of interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXWu8Np-Ed-ak6NoX_4Aeg_336258088")]
[Description(@"Indicates the relative quality of the indication of interest.")]
[Derivations(typeof(QualityIndication1Code))]
// External derivations that should be provided by the proper interface are: 
public enum QualityIndicationCode
{
    /// <summary>
    /// Low quality.
    /// Encoded/decoded by serializers as "LOWE".
    /// </summary>
    [EnumMember(Value = "LOWE")]
    [IsoId("_ZXWu8dp-Ed-ak6NoX_4Aeg_336258089")]
    [Description(@"Low quality.")]
    Low,
    
    /// <summary>
    /// Medium quality.
    /// Encoded/decoded by serializers as "MEDI".
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_ZXWu8tp-Ed-ak6NoX_4Aeg_336258090")]
    [Description(@"Medium quality.")]
    Medium,
    
    /// <summary>
    /// High quality.
    /// Encoded/decoded by serializers as "HIGH".
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_ZXWu89p-Ed-ak6NoX_4Aeg_336258099")]
    [Description(@"High quality.")]
    High,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QualityIndicationCodeMetadataExtensions
{
    private static readonly QualityIndicationCodeDropdownSource _dropdownSource = new QualityIndicationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQualityIndicationCodeDropdownRow GetMetadata(this QualityIndicationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


