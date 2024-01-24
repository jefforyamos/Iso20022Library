﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DrawdownTypeCode.  ISO2002 ID# _goS4AFNdEeijdq8ilaxyOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of drawdown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_goS4AFNdEeijdq8ilaxyOA")]
[Description(@"Specifies a type of drawdown.")]
[Derivations(typeof(DrawdownType1Code),typeof(DrawdownType2Code))]
public enum DrawdownTypeCode
{
    /// <summary>
    /// Drawdown type is flexi-access.
    /// Encoded/decoded by serializers as "FLEX".
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_kBqAgFNdEeijdq8ilaxyOA")]
    [Description(@"Drawdown type is flexi-access.")]
    FlexibleAccessDrawdown,
    
    /// <summary>
    /// Drawdown type is capped.
    /// Encoded/decoded by serializers as "CAPP".
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_oKCLIFNdEeijdq8ilaxyOA")]
    [Description(@"Drawdown type is capped.")]
    CappedIncomeDrawdown,
    
    /// <summary>
    /// Drawdown type is both flexi-access and capped.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_VwLq4JNwEembCsVG-3f_AA")]
    [Description(@"Drawdown type is both flexi-access and capped.")]
    Both,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DrawdownTypeCodeMetadataExtensions
{
    private static readonly DrawdownTypeCodeDropdownSource _dropdownSource = new DrawdownTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDrawdownTypeCodeDropdownRow GetMetadata(this DrawdownTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


