﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ScenarioType1Code.  ISO2002 ID# _UgCXYKssEeayv9XxdmMwKQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Classification of the methodology used to derive a stress testing scenario.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UgCXYKssEeayv9XxdmMwKQ")]
[Description(@"Classification of the methodology used to derive a stress testing scenario.")]
[DerivedFrom(typeof(ScenarioTypeCode))]
public enum ScenarioType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Historical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WJzxkassEeayv9XxdmMwKQ")]
    [Description(@"??")]
    Historical,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Hypothetical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WN-f4assEeayv9XxdmMwKQ")]
    [Description(@"??")]
    Hypothetical,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ScenarioType1CodeMetadataExtensions
{
    private static readonly ScenarioType1CodeDropdownSource _dropdownSource = new ScenarioType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IScenarioType1CodeDropdownRow GetMetadata(this ScenarioType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


