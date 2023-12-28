﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GracePeriodUnitType1Code.  ISO2002 ID# _tjpgUDEpEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tjpgUDEpEemzCpWiCwK4aQ")]
[Description(@"Contains the details of the grace period applicable to the instalment.")]
[DerivedFrom(typeof(GracePeriodUnitTypeCode))]
public enum GracePeriodUnitType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Weeks".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xb7ZcTEpEemzCpWiCwK4aQ")]
    [Description(@"??")]
    Weeks,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Payments".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xwpFMTEpEemzCpWiCwK4aQ")]
    [Description(@"??")]
    Payments,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yFqS8TEpEemzCpWiCwK4aQ")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yaONsTEpEemzCpWiCwK4aQ")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Months".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yuo-gTEpEemzCpWiCwK4aQ")]
    [Description(@"??")]
    Months,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Days".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zDWqQTEpEemzCpWiCwK4aQ")]
    [Description(@"??")]
    Days,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GracePeriodUnitType1CodeMetadataExtensions
{
    private static readonly GracePeriodUnitType1CodeDropdownSource _dropdownSource = new GracePeriodUnitType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGracePeriodUnitType1CodeDropdownRow GetMetadata(this GracePeriodUnitType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


