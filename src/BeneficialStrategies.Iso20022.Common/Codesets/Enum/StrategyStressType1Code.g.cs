﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StrategyStressType1Code.  ISO2002 ID# _GUa7UKsuEeayv9XxdmMwKQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Scenario type based on the type of portfolio the scenario is designed to stress.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GUa7UKsuEeayv9XxdmMwKQ")]
[Description(@"Scenario type based on the type of portfolio the scenario is designed to stress.")]
[DerivedFrom(typeof(StrategyStressTypeCode))]
public enum StrategyStressType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Flex".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_H9vpkasuEeayv9XxdmMwKQ")]
    [Description(@"??")]
    Flex,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Parallel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ICXD0asuEeayv9XxdmMwKQ")]
    [Description(@"??")]
    Parallel,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Spread".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tGJkMeonEeadseq5W5YLvQ")]
    [Description(@"??")]
    Spread,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StrategyStressType1CodeMetadataExtensions
{
    private static readonly StrategyStressType1CodeDropdownSource _dropdownSource = new StrategyStressType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStrategyStressType1CodeDropdownRow GetMetadata(this StrategyStressType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


