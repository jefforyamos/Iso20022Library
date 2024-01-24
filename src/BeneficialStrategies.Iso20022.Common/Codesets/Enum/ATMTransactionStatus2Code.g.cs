﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMTransactionStatus2Code.  ISO2002 ID# _6bELsIqSEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status of the amount presented to the customer in the last bundle.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6bELsIqSEeSRT5rEzcAHEw")]
[Description(@"Status of the amount presented to the customer in the last bundle.")]
[DerivedFrom(typeof(ATMTransactionStatusCode))]
public enum ATMTransactionStatus2Code
{
    /// <summary>
    /// Total presented amount is equal to the amount to dispense.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_-SIj4YqSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is equal to the amount to dispense.")]
    Full = ATMTransactionStatusCode.Full, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total presented amount is lower than the amount to dispense.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_-fsew4qSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is lower than the amount to dispense.")]
    Partial = ATMTransactionStatusCode.Partial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total presented amount is equal to zero.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_-szts4qSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is equal to zero.")]
    None = ATMTransactionStatusCode.None, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMTransactionStatus2CodeMetadataExtensions
{
    private static readonly ATMTransactionStatus2CodeDropdownSource _dropdownSource = new ATMTransactionStatus2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMTransactionStatus2CodeDropdownRow GetMetadata(this ATMTransactionStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


