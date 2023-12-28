﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountOwnerType1Code.  ISO2002 ID# _VreTFtp-Ed-ak6NoX_4Aeg_-894819562.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account owner.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VreTFtp-Ed-ak6NoX_4Aeg_-894819562")]
[Description(@"Specifies the type of account owner.")]
[DerivedFrom(typeof(AccountOwnerTypeCode))]
public enum AccountOwnerType1Code
{
    /// <summary>
    /// Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.
    /// Encoded/decoded by serializers as "PrimaryOwner".
    /// </summary>
    [EnumMember(Value = "POWN")]
    [IsoId("_VreTF9p-Ed-ak6NoX_4Aeg_-894819554")]
    [Description(@"Owner of the property. The ownership can be split among several owners, and the primary owner is the one giving its address and account details for the registration.")]
    PrimaryOwner,
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// Encoded/decoded by serializers as "Trustee".
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_VreTGNp-Ed-ak6NoX_4Aeg_-894819553")]
    [Description(@"Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.")]
    Trustee,
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// Encoded/decoded by serializers as "CustodianForMinor".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_VreTGdp-Ed-ak6NoX_4Aeg_-894819552")]
    [Description(@"Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.")]
    CustodianForMinor,
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// Encoded/decoded by serializers as "Nominee".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_VroEENp-Ed-ak6NoX_4Aeg_-894819551")]
    [Description(@"Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.")]
    Nominee,
    
    /// <summary>
    /// One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.
    /// Encoded/decoded by serializers as "SecondaryOwner".
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_VroEEdp-Ed-ak6NoX_4Aeg_-894819550")]
    [Description(@"One of the owners of the property. The ownership can be split among several owners, and only the primary owner gives its address and account details for the registration.")]
    SecondaryOwner,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountOwnerType1CodeMetadataExtensions
{
    private static readonly AccountOwnerType1CodeDropdownSource _dropdownSource = new AccountOwnerType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountOwnerType1CodeDropdownRow GetMetadata(this AccountOwnerType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


