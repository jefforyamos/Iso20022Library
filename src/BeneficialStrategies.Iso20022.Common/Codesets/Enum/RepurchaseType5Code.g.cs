﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepurchaseType5Code.  ISO2002 ID# _P6sH4duJEd-RF5yaMAVhAw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of repurchase process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_P6sH4duJEd-RF5yaMAVhAw")]
[Description(@"Specifies the type of repurchase process.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
public enum RepurchaseType5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepurchaseCall".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5t_IWtdEeCY4-KZ9JEyUQ_-410922395")]
    [Description(@"??")]
    RepurchaseCall,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepoRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5t_ImtdEeCY4-KZ9JEyUQ_114905717")]
    [Description(@"??")]
    RepoRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rollover".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5t_I2tdEeCY4-KZ9JEyUQ_-882166636")]
    [Description(@"??")]
    Rollover,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrincipalExposureAdjustment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5t_JGtdEeCY4-KZ9JEyUQ_568992986")]
    [Description(@"??")]
    PrincipalExposureAdjustment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepurchaseType5CodeMetadataExtensions
{
    private static readonly RepurchaseType5CodeDropdownSource _dropdownSource = new RepurchaseType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepurchaseType5CodeDropdownRow GetMetadata(this RepurchaseType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


