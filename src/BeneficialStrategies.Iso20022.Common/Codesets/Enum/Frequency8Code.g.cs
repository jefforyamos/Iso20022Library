﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Frequency8Code.  ISO2002 ID# _q5d88A3iEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q5d88A3iEeWc7_0KPiuk6w")]
[Description(@"Specifies the regularity of an event.")]
[DerivedFrom(typeof(FrequencyCode))]
public enum Frequency8Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Annual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sPwacQ3iEeWc7_0KPiuk6w")]
    [Description(@"??")]
    Annual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SemiAnnual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_socnQQ3iEeWc7_0KPiuk6w")]
    [Description(@"??")]
    SemiAnnual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Monthly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uYoLcQ3iEeWc7_0KPiuk6w")]
    [Description(@"??")]
    Monthly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quarterly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uz_40Q3iEeWc7_0KPiuk6w")]
    [Description(@"??")]
    Quarterly,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Frequency8CodeMetadataExtensions
{
    private static readonly Frequency8CodeDropdownSource _dropdownSource = new Frequency8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFrequency8CodeDropdownRow GetMetadata(this Frequency8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

