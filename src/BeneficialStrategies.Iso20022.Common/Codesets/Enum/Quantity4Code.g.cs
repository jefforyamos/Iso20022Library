﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Quantity4Code.  ISO2002 ID# _mxo5YQCgEeGqP72A5EmwKQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies quantity of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mxo5YQCgEeGqP72A5EmwKQ")]
[Description(@"Specifies quantity of a financial instrument.")]
[DerivedFrom(typeof(QuantityCode))]
public enum Quantity4Code
{
    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_mxyqZQCgEeGqP72A5EmwKQ")]
    [Description(@"Quantity is unknown by the sender or has not been established.")]
    UnknownQuantity = QuantityCode.UnknownQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as "ANYA".
    /// </summary>
    [EnumMember(Value = "ANYA")]
    [IsoId("_n0ZW7gCgEeGqP72A5EmwKQ")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AnyAndAll = QuantityCode.AnyAndAll, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Quantity4CodeMetadataExtensions
{
    private static readonly Quantity4CodeDropdownSource _dropdownSource = new Quantity4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQuantity4CodeDropdownRow GetMetadata(this Quantity4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


