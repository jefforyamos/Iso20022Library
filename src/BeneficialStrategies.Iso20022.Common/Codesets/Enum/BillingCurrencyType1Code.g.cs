﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BillingCurrencyType1Code.  ISO2002 ID# _6WXNs5qlEeGSON8vddiWzQ_-124984192.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of currency to be used for the billing of a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WXNs5qlEeGSON8vddiWzQ_-124984192")]
[Description(@"Defines the type of currency to be used for the billing of a service.")]
[DerivedFrom(typeof(BillingCurrencyTypeCode))]
public enum BillingCurrencyType1Code
{
    /// <summary>
    /// Currency type used for the billing is the account currency.
    /// Encoded/decoded by serializers as "ACCT".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_6WXNtJqlEeGSON8vddiWzQ_42035703")]
    [Description(@"Currency type used for the billing is the account currency.")]
    Account = BillingCurrencyTypeCode.Account, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency type used for the billing is the settlement currency.
    /// Encoded/decoded by serializers as "STLM".
    /// </summary>
    [EnumMember(Value = "STLM")]
    [IsoId("_6WXNtZqlEeGSON8vddiWzQ_-2111377502")]
    [Description(@"Currency type used for the billing is the settlement currency.")]
    Settlement = BillingCurrencyTypeCode.Settlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency type used for the billing is the pricing currency.
    /// Encoded/decoded by serializers as "PRCG".
    /// </summary>
    [EnumMember(Value = "PRCG")]
    [IsoId("_6WXNtpqlEeGSON8vddiWzQ_-644228739")]
    [Description(@"Currency type used for the billing is the pricing currency.")]
    Pricing = BillingCurrencyTypeCode.Pricing, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BillingCurrencyType1CodeMetadataExtensions
{
    private static readonly BillingCurrencyType1CodeDropdownSource _dropdownSource = new BillingCurrencyType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBillingCurrencyType1CodeDropdownRow GetMetadata(this BillingCurrencyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


