﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CurrencyDesignation1Code.  ISO2002 ID# _Bru94Ad2EeSPHJIdUs1USg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a currency is settled offshore or onshore.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bru94Ad2EeSPHJIdUs1USg")]
[Description(@"Specifies whether a currency is settled offshore or onshore.")]
[DerivedFrom(typeof(CurrencyDesignationCode))]
public enum CurrencyDesignation1Code
{
    /// <summary>
    /// Onshore.
    /// Encoded/decoded by serializers as "Onshore".
    /// </summary>
    [EnumMember(Value = "ONSH")]
    [IsoId("_D0dk8Qd2EeSPHJIdUs1USg")]
    [Description(@"Onshore.")]
    Onshore,
    
    /// <summary>
    /// Offshore.
    /// Encoded/decoded by serializers as "Offshore".
    /// </summary>
    [EnumMember(Value = "OFFS")]
    [IsoId("_D8gGoQd2EeSPHJIdUs1USg")]
    [Description(@"Offshore.")]
    Offshore,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CurrencyDesignation1CodeMetadataExtensions
{
    private static readonly CurrencyDesignation1CodeDropdownSource _dropdownSource = new CurrencyDesignation1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICurrencyDesignation1CodeDropdownRow GetMetadata(this CurrencyDesignation1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


