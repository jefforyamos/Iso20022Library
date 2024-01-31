﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceStatus2Code.  ISO2002 ID# _6j0dcAbBEeqrW7Meu5r3kQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of the price of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6j0dcAbBEeqrW7Meu5r3kQ")]
[Description(@"Status of the price of a financial instrument.")]
[DerivedFrom(typeof(PriceStatusCode))]
public enum PriceStatus2Code
{
    /// <summary>
    /// Price is pending.
    /// Encoded/decoded by serializers as "PNDG".
    /// </summary>
    [EnumMember(Value = "PNDG")]
    [IsoId("_DfTKsQbCEeqrW7Meu5r3kQ")]
    [Description(@"Price is pending.")]
    Pending = PriceStatusCode.Pending, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceStatus2CodeMetadataExtensions
{
    private static readonly PriceStatus2CodeDropdownSource _dropdownSource = new PriceStatus2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceStatus2CodeDropdownRow GetMetadata(this PriceStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


