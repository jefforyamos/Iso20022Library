﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EnergyQuantityUnit1Code.  ISO2002 ID# _agE0AA3fEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an energy quantity unit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_agE0AA3fEeWc7_0KPiuk6w")]
[Description(@"Specifies an energy quantity unit.")]
[DerivedFrom(typeof(EnergyQuantityUnitCode))]
public enum EnergyQuantityUnit1Code
{
    /// <summary>
    /// Therm per day.
    /// Encoded/decoded by serializers as "ThermPerDay".
    /// </summary>
    [EnumMember(Value = "THMD")]
    [IsoId("_1m7AcRYtEeWK8am9Oj92Tg")]
    [Description(@"Therm per day.")]
    ThermPerDay,
    
    /// <summary>
    /// Mega Watt hour per hour.
    /// Encoded/decoded by serializers as "MWhPerHour".
    /// </summary>
    [EnumMember(Value = "MWHH")]
    [IsoId("_1zjuQRYtEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt hour per hour.")]
    MWhPerHour,
    
    /// <summary>
    /// Mega Watt hour per day.
    /// Encoded/decoded by serializers as "MWhPerDay".
    /// </summary>
    [EnumMember(Value = "MWHD")]
    [IsoId("_13uckRYtEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt hour per day.")]
    MWhPerDay,
    
    /// <summary>
    /// Mega Watt.
    /// Encoded/decoded by serializers as "MW".
    /// </summary>
    [EnumMember(Value = "MWAT")]
    [IsoId("_2EXxcRYtEeWK8am9Oj92Tg")]
    [Description(@"Mega Watt.")]
    MW,
    
    /// <summary>
    /// MTherm per day.
    /// Encoded/decoded by serializers as "MThermPerDay".
    /// </summary>
    [EnumMember(Value = "MTMD")]
    [IsoId("_2IifwRYtEeWK8am9Oj92Tg")]
    [Description(@"MTherm per day.")]
    MThermPerDay,
    
    /// <summary>
    /// Mcm per day.
    /// Encoded/decoded by serializers as "MCMPerDay".
    /// </summary>
    [EnumMember(Value = "MCMD")]
    [IsoId("_2VLNkRYtEeWK8am9Oj92Tg")]
    [Description(@"Mcm per day.")]
    MCMPerDay,
    
    /// <summary>
    /// Kilo Watt hour per hour.
    /// Encoded/decoded by serializers as "KWhPerHour".
    /// </summary>
    [EnumMember(Value = "KWHH")]
    [IsoId("_2ZV74RYtEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt hour per hour.")]
    KWhPerHour,
    
    /// <summary>
    /// Kilo Watt hour per day.
    /// Encoded/decoded by serializers as "KWhPerDay".
    /// </summary>
    [EnumMember(Value = "KWHD")]
    [IsoId("_2l1fwRYtEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt hour per day.")]
    KWhPerDay,
    
    /// <summary>
    /// Kilo Watt.
    /// Encoded/decoded by serializers as "KW".
    /// </summary>
    [EnumMember(Value = "KWAT")]
    [IsoId("_2yL5sRYtEeWK8am9Oj92Tg")]
    [Description(@"Kilo Watt.")]
    KW,
    
    /// <summary>
    /// KTherm per day.
    /// Encoded/decoded by serializers as "KThermPerDay".
    /// </summary>
    [EnumMember(Value = "KTMD")]
    [IsoId("_22WoARYtEeWK8am9Oj92Tg")]
    [Description(@"KTherm per day.")]
    KThermPerDay,
    
    /// <summary>
    /// Giga Watt hour per hour.
    /// Encoded/decoded by serializers as "GWhPerHour".
    /// </summary>
    [EnumMember(Value = "GWHH")]
    [IsoId("_3DJG0RYtEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt hour per hour.")]
    GWhPerHour,
    
    /// <summary>
    /// Giga Watt hour per day.
    /// Encoded/decoded by serializers as "GWhPerDay".
    /// </summary>
    [EnumMember(Value = "GWHD")]
    [IsoId("_3HT1IRYtEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt hour per day.")]
    GWhPerDay,
    
    /// <summary>
    /// Giga Watt.
    /// Encoded/decoded by serializers as "GW".
    /// </summary>
    [EnumMember(Value = "GWAT")]
    [IsoId("_3TgeERYtEeWK8am9Oj92Tg")]
    [Description(@"Giga Watt.")]
    GW,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EnergyQuantityUnit1CodeMetadataExtensions
{
    private static readonly EnergyQuantityUnit1CodeDropdownSource _dropdownSource = new EnergyQuantityUnit1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEnergyQuantityUnit1CodeDropdownRow GetMetadata(this EnergyQuantityUnit1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


