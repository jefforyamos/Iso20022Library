﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FleetServiceTypeCode.  ISO2002 ID# _9zEEI_jUEeiM7KpzmLtmTQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the list of fleet service type codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9zEEI_jUEeiM7KpzmLtmTQ")]
[Description(@"Contains the list of fleet service type codes.")]
[Derivations(typeof(FleetServiceType1Code))]
public enum FleetServiceTypeCode
{
    /// <summary>
    /// Full service
    /// Encoded/decoded by serializers as "FLSV".
    /// </summary>
    [EnumMember(Value = "FLSV")]
    [IsoId("_9zEEJfjUEeiM7KpzmLtmTQ")]
    [Description(@"Full service")]
    FullService,
    
    /// <summary>
    /// Self service
    /// Encoded/decoded by serializers as "SLSV".
    /// </summary>
    [EnumMember(Value = "SLSV")]
    [IsoId("_9zEEJPjUEeiM7KpzmLtmTQ")]
    [Description(@"Self service")]
    SelfService,
    
    /// <summary>
    /// High speed dispenser that may or may not support varying flow rates. 
    /// Encoded/decoded by serializers as "HSDI".
    /// </summary>
    [EnumMember(Value = "HSDI")]
    [IsoId("_itg-sP2sEeiS2rs-hXBB5Q")]
    [Description(@"High speed dispenser that may or may not support varying flow rates. ")]
    HighSpeedDispenser,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FleetServiceTypeCodeMetadataExtensions
{
    private static readonly FleetServiceTypeCodeDropdownSource _dropdownSource = new FleetServiceTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFleetServiceTypeCodeDropdownRow GetMetadata(this FleetServiceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


