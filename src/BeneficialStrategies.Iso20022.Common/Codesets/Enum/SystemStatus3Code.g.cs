﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SystemStatus3Code.  ISO2002 ID# _rREogIpbEeiaB-4Hjqs8aw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rREogIpbEeiaB-4Hjqs8aw")]
[Description(@"Specifies the status of a system.")]
[DerivedFrom(typeof(SystemStatusCode))]
public enum SystemStatus3Code
{
    /// <summary>
    /// System is functioning normally, that is, operational.
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_wPvh8YpbEeiaB-4Hjqs8aw")]
    [Description(@"System is functioning normally, that is, operational.")]
    Active,
    
    /// <summary>
    /// System is closed (eg. normal closure of an RTGS).
    /// Encoded/decoded by serializers as "Closed".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_wYa80YpbEeiaB-4Hjqs8aw")]
    [Description(@"System is closed (eg. normal closure of an RTGS).")]
    Closed,
    
    /// <summary>
    /// System is starting a new maintenance period.
    /// Encoded/decoded by serializers as "ReserveMaintenancePeriodStart".
    /// </summary>
    [EnumMember(Value = "RMPS")]
    [IsoId("_YxOXIYpdEeiaB-4Hjqs8aw")]
    [Description(@"System is starting a new maintenance period.")]
    ReserveMaintenancePeriodStart,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SystemStatus3CodeMetadataExtensions
{
    private static readonly SystemStatus3CodeDropdownSource _dropdownSource = new SystemStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISystemStatus3CodeDropdownRow GetMetadata(this SystemStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


