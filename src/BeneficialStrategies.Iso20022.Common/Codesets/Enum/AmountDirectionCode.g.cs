﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AmountDirectionCode.  ISO2002 ID# _boymFdp-Ed-ak6NoX_4Aeg_-1616551496.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if an operation is an increase or a decrease or the result of a reversal operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_boymFdp-Ed-ak6NoX_4Aeg_-1616551496")]
[Description(@"Specifies if an operation is an increase or a decrease or the result of a reversal operation.")]
[Derivations(typeof(CreditDebitCode),typeof(ReversalCode),typeof(CreditDebit3Code))]
// External derivations that should be provided by the proper interface are: 
public enum AmountDirectionCode
{
    /// <summary>
    /// Operation is a decrease.
    /// Encoded/decoded by serializers as "DBIT".
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_boymFtp-Ed-ak6NoX_4Aeg_-1454013233")]
    [Description(@"Operation is a decrease.")]
    Debit,
    
    /// <summary>
    /// Operation is an increase.
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_boymF9p-Ed-ak6NoX_4Aeg_-1454013216")]
    [Description(@"Operation is an increase.")]
    Credit,
    
    /// <summary>
    /// Credit entry used to reverse a previously booked debit entry.
    /// Encoded/decoded by serializers as "RVDB".
    /// </summary>
    [EnumMember(Value = "RVDB")]
    [IsoId("_boymGNp-Ed-ak6NoX_4Aeg_-1454013198")]
    [Description(@"Credit entry used to reverse a previously booked debit entry.")]
    ReversalDebit,
    
    /// <summary>
    /// Debit entry used to reverse a previously booked credit entry.
    /// Encoded/decoded by serializers as "RVCD".
    /// </summary>
    [EnumMember(Value = "RVCD")]
    [IsoId("_bo8XENp-Ed-ak6NoX_4Aeg_-1454013156")]
    [Description(@"Debit entry used to reverse a previously booked credit entry.")]
    ReversalCredit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AmountDirectionCodeMetadataExtensions
{
    private static readonly AmountDirectionCodeDropdownSource _dropdownSource = new AmountDirectionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAmountDirectionCodeDropdownRow GetMetadata(this AmountDirectionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


