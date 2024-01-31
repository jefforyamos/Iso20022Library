﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceStatus1Code.  ISO2002 ID# _NtDrcOzYEeSBf_ghFpb9rQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the price of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NtDrcOzYEeSBf_ghFpb9rQ")]
[Description(@"Specifies the status of the price of a financial instrument.")]
[DerivedFrom(typeof(PriceStatusCode))]
public enum PriceStatus1Code
{
    /// <summary>
    /// Price is pending.
    /// Encoded/decoded by serializers as "PNDG".
    /// </summary>
    [EnumMember(Value = "PNDG")]
    [IsoId("_O0HaIezYEeSBf_ghFpb9rQ")]
    [Description(@"Price is pending.")]
    Pending = PriceStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No price for transaction (e.g. transfer between accounts).
    /// Encoded/decoded by serializers as "NOAP".
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_Cc6kEI-TEeWtN7rsKJRs8Q")]
    [Description(@"No price for transaction (e.g. transfer between accounts).")]
    NotApplicable = PriceStatusCode.NotApplicable, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceStatus1CodeMetadataExtensions
{
    private static readonly PriceStatus1CodeDropdownSource _dropdownSource = new PriceStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceStatus1CodeDropdownRow GetMetadata(this PriceStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


