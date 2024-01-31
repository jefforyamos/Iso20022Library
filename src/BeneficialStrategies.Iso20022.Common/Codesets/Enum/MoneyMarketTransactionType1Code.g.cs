﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MoneyMarketTransactionType1Code.  ISO2002 ID# _AaCp4JfsEeSfnc-VXAEapg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction type used in the money market statistical reporting for the secured market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AaCp4JfsEeSfnc-VXAEapg")]
[Description(@"Specifies the transaction type used in the money market statistical reporting for the secured market.")]
[DerivedFrom(typeof(MoneyMarketTransactionTypeCode))]
public enum MoneyMarketTransactionType1Code
{
    /// <summary>
    /// Transaction is a borrowing.
    /// Encoded/decoded by serializers as "BORR".
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_IwD5oZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction is a borrowing.")]
    CashBorrowing = MoneyMarketTransactionTypeCode.CashBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a lending.
    /// Encoded/decoded by serializers as "LEND".
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("_I4gD8ZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction is a lending.")]
    CashLending = MoneyMarketTransactionTypeCode.CashLending, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MoneyMarketTransactionType1CodeMetadataExtensions
{
    private static readonly MoneyMarketTransactionType1CodeDropdownSource _dropdownSource = new MoneyMarketTransactionType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMoneyMarketTransactionType1CodeDropdownRow GetMetadata(this MoneyMarketTransactionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


