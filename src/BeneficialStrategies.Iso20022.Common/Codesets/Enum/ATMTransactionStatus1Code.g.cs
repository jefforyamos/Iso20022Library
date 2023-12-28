﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMTransactionStatus1Code.  ISO2002 ID# _RAy34IqSEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Outcome of the financial ATM transaction for the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RAy34IqSEeSRT5rEzcAHEw")]
[Description(@"Outcome of the financial ATM transaction for the customer.")]
[DerivedFrom(typeof(ATMTransactionStatusCode))]
public enum ATMTransactionStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Doubt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VAzJoYqSEeSRT5rEzcAHEw")]
    [Description(@"??")]
    Doubt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Failure".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VE0uAYqSEeSRT5rEzcAHEw")]
    [Description(@"??")]
    Failure,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Success".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VMHo04qSEeSRT5rEzcAHEw")]
    [Description(@"??")]
    Success,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMTransactionStatus1CodeMetadataExtensions
{
    private static readonly ATMTransactionStatus1CodeDropdownSource _dropdownSource = new ATMTransactionStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMTransactionStatus1CodeDropdownRow GetMetadata(this ATMTransactionStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

