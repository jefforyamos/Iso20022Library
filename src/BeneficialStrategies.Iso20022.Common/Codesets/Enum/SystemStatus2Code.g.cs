﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SystemStatus2Code.  ISO2002 ID# _ZSJe09p-Ed-ak6NoX_4Aeg_-619414979.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSJe09p-Ed-ak6NoX_4Aeg_-619414979")]
[Description(@"Specifies the status of a system.")]
[DerivedFrom(typeof(SystemStatusCode))]
public enum SystemStatus2Code
{
    /// <summary>
    /// System is suspended, that is, not operational.
    /// Encoded/decoded by serializers as "Suspended".
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_ZSJe1Np-Ed-ak6NoX_4Aeg_-246312211")]
    [Description(@"System is suspended, that is, not operational.")]
    Suspended,
    
    /// <summary>
    /// System is functioning normally, that is, operational.
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZSJe1dp-Ed-ak6NoX_4Aeg_-237078229")]
    [Description(@"System is functioning normally, that is, operational.")]
    Active,
    
    /// <summary>
    /// System is closed (eg. normal closure of an RTGS).
    /// Encoded/decoded by serializers as "Closed".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_ZSJe1tp-Ed-ak6NoX_4Aeg_-234308163")]
    [Description(@"System is closed (eg. normal closure of an RTGS).")]
    Closed,
    
    /// <summary>
    /// System needs to wait for completion of intermediate internal activities before going to a status Closed.
    /// Encoded/decoded by serializers as "Closing".
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_ZSJe19p-Ed-ak6NoX_4Aeg_-225070272")]
    [Description(@"System needs to wait for completion of intermediate internal activities before going to a status Closed.")]
    Closing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SystemStatus2CodeMetadataExtensions
{
    private static readonly SystemStatus2CodeDropdownSource _dropdownSource = new SystemStatus2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISystemStatus2CodeDropdownRow GetMetadata(this SystemStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


