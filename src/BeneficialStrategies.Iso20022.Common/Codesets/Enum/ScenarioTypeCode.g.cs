﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ScenarioTypeCode.  ISO2002 ID# _Bd4VEKssEeayv9XxdmMwKQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of scenario based on how the risk factors moves for that scenario were conceived.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bd4VEKssEeayv9XxdmMwKQ")]
[Description(@"Type of scenario based on how the risk factors moves for that scenario were conceived.")]
public enum ScenarioTypeCode
{
    /// <summary>
    /// Scenario that replays an event that occurred in the past, including antithetic historical scenarios.
    /// Encoded/decoded by serializers as "HIST".
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_FdeXIKssEeayv9XxdmMwKQ")]
    [Description(@"Scenario that replays an event that occurred in the past, including antithetic historical scenarios.")]
    Historical,
    
    /// <summary>
    /// Scenario that is defined by a hypothetical or theoretical event that may happen in the future.
    /// Encoded/decoded by serializers as "HYPT".
    /// </summary>
    [EnumMember(Value = "HYPT")]
    [IsoId("_Hp6ZgKssEeayv9XxdmMwKQ")]
    [Description(@"Scenario that is defined by a hypothetical or theoretical event that may happen in the future.")]
    Hypothetical,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ScenarioTypeCodeMetadataExtensions
{
    private static readonly ScenarioTypeCodeDropdownSource _dropdownSource = new ScenarioTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IScenarioTypeCodeDropdownRow GetMetadata(this ScenarioTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


