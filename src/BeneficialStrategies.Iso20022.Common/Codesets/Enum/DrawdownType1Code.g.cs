﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DrawdownType1Code.  ISO2002 ID# _tHXn0FNdEeijdq8ilaxyOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of drawdown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tHXn0FNdEeijdq8ilaxyOA")]
[Description(@"Specifies a type of drawdown.")]
[DerivedFrom(typeof(DrawdownTypeCode))]
public enum DrawdownType1Code
{
    /// <summary>
    /// Drawdown type is capped.
    /// Encoded/decoded by serializers as "CAPP".
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_uQaTgVNdEeijdq8ilaxyOA")]
    [Description(@"Drawdown type is capped.")]
    CappedIncomeDrawdown = DrawdownTypeCode.CappedIncomeDrawdown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Drawdown type is flexi-access.
    /// Encoded/decoded by serializers as "FLEX".
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_uVnjoVNdEeijdq8ilaxyOA")]
    [Description(@"Drawdown type is flexi-access.")]
    FlexibleAccessDrawdown = DrawdownTypeCode.FlexibleAccessDrawdown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DrawdownType1CodeMetadataExtensions
{
    private static readonly DrawdownType1CodeDropdownSource _dropdownSource = new DrawdownType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDrawdownType1CodeDropdownRow GetMetadata(this DrawdownType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


