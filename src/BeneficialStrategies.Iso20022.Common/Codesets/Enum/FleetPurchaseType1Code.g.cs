﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FleetPurchaseType1Code.  ISO2002 ID# _hoJpkDEnEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of codes representing type of fleet purchases.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hoJpkDEnEemzCpWiCwK4aQ")]
[Description(@"List of codes representing type of fleet purchases.")]
[DerivedFrom(typeof(FleetPurchaseTypeCode))]
public enum FleetPurchaseType1Code
{
    /// <summary>
    /// Fuel
    /// Encoded/decoded by serializers as "FUEL".
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_knUwcTEnEemzCpWiCwK4aQ")]
    [Description(@"Fuel")]
    Fuel = FleetPurchaseTypeCode.Fuel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non fuel
    /// Encoded/decoded by serializers as "NONF".
    /// </summary>
    [EnumMember(Value = "NONF")]
    [IsoId("_lSZGsTEnEemzCpWiCwK4aQ")]
    [Description(@"Non fuel")]
    NonFuel = FleetPurchaseTypeCode.NonFuel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fuel and non fuel
    /// Encoded/decoded by serializers as "FANF".
    /// </summary>
    [EnumMember(Value = "FANF")]
    [IsoId("_lomAMTEnEemzCpWiCwK4aQ")]
    [Description(@"Fuel and non fuel")]
    FuelAndNonFuel = FleetPurchaseTypeCode.FuelAndNonFuel, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FleetPurchaseType1CodeMetadataExtensions
{
    private static readonly FleetPurchaseType1CodeDropdownSource _dropdownSource = new FleetPurchaseType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFleetPurchaseType1CodeDropdownRow GetMetadata(this FleetPurchaseType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


