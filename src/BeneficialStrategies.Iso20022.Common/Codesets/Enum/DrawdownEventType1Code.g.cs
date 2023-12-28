﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DrawdownEventType1Code.  ISO2002 ID# _c--OoFNiEeijdq8ilaxyOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of drawdown event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c--OoFNiEeijdq8ilaxyOA")]
[Description(@"Specifies a type of drawdown event.")]
[DerivedFrom(typeof(DrawdownEventTypeCode))]
public enum DrawdownEventType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Drawdown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eBVDgVNiEeijdq8ilaxyOA")]
    [Description(@"??")]
    Drawdown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UncrystallisedFundsPensionLumpSum".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eGiToVNiEeijdq8ilaxyOA")]
    [Description(@"??")]
    UncrystallisedFundsPensionLumpSum,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DrawdownEventType1CodeMetadataExtensions
{
    private static readonly DrawdownEventType1CodeDropdownSource _dropdownSource = new DrawdownEventType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDrawdownEventType1CodeDropdownRow GetMetadata(this DrawdownEventType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

