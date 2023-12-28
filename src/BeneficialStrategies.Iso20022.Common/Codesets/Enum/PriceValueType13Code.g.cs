﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType13Code.  ISO2002 ID# _K3qasA-zEeuE0Pnt-OcNOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of price is unspecified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K3qasA-zEeuE0Pnt-OcNOA")]
[Description(@"Type of price is unspecified.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType13Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unspecified".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_M2HEYQ-zEeuE0Pnt-OcNOA")]
    [Description(@"??")]
    Unspecified,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType13CodeMetadataExtensions
{
    private static readonly PriceValueType13CodeDropdownSource _dropdownSource = new PriceValueType13CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType13CodeDropdownRow GetMetadata(this PriceValueType13Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

