﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountOwnerTypeCode.  ISO2002 ID# _r1Jf8I8mEeeBmcwCTnMfBg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account owner.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r1Jf8I8mEeeBmcwCTnMfBg")]
[Description(@"Specifies the type of account owner.")]
public enum AccountOwnerTypeCode
{
    /// <summary>
    /// Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [EnumMember(Value = "POWN")]
    [IsoId("_u0xSwY8mEeeBmcwCTnMfBg")]
    [Description(@"Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.")]
    POWN,
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_u_et8Y8mEeeBmcwCTnMfBg")]
    [Description(@"Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.")]
    TRUS,
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_up6GkY8mEeeBmcwCTnMfBg")]
    [Description(@"Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.")]
    CUST,
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_uv29kY8mEeeBmcwCTnMfBg")]
    [Description(@"Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.")]
    NOMI,
    
    /// <summary>
    /// One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_u6IT4Y8mEeeBmcwCTnMfBg")]
    [Description(@"One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.")]
    SECO,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountOwnerTypeCodeMetadataExtensions
{
    private static readonly AccountOwnerTypeCodeDropdownSource _dropdownSource = new AccountOwnerTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountOwnerTypeCodeDropdownRow GetMetadata(this AccountOwnerTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


