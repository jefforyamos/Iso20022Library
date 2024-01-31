﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountManagementTypeCode.  ISO2002 ID# _bqvG1tp-Ed-ak6NoX_4Aeg_-941371103.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Refers to an account management instruction, that is, either an account opening instruction or an account modification instruction or a get account details message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqvG1tp-Ed-ak6NoX_4Aeg_-941371103")]
[Description(@"Refers to an account management instruction, that is, either an account opening instruction or an account modification instruction or a get account details message.")]
[Derivations(typeof(AccountManagementType2Code),typeof(AccountManagementType1Code),typeof(AccountManagementType3Code))]
public enum AccountManagementTypeCode
{
    /// <summary>
    /// Refers to an account opening instruction message.
    /// Encoded/decoded by serializers as "ACCO".
    /// </summary>
    [EnumMember(Value = "ACCO")]
    [IsoId("_bqvG19p-Ed-ak6NoX_4Aeg_-521166332")]
    [Description(@"Refers to an account opening instruction message.")]
    AccountOpening,
    
    /// <summary>
    /// Refers to an account modification instruction message.
    /// Encoded/decoded by serializers as "ACCM".
    /// </summary>
    [EnumMember(Value = "ACCM")]
    [IsoId("_bqvG2Np-Ed-ak6NoX_4Aeg_-521166290")]
    [Description(@"Refers to an account modification instruction message.")]
    AccountModification,
    
    /// <summary>
    /// Refers to a get account details message.
    /// Encoded/decoded by serializers as "GACC".
    /// </summary>
    [EnumMember(Value = "GACC")]
    [IsoId("_bq4QwNp-Ed-ak6NoX_4Aeg_-1703346432")]
    [Description(@"Refers to a get account details message.")]
    GetAccountDetails,
    
    /// <summary>
    /// Refers to an account closure instruction message.
    /// Encoded/decoded by serializers as "CLOS".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_zMhlcFSeEeatgN-VQ0eFlQ")]
    [Description(@"Refers to an account closure instruction message.")]
    AccountClosure,
    
    /// <summary>
    /// Refers to the account status.
    /// Encoded/decoded by serializers as "ACST".
    /// </summary>
    [EnumMember(Value = "ACST")]
    [IsoId("_1p7XcKTsEeamspXrHzHkQw")]
    [Description(@"Refers to the account status.")]
    AccountStatus,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountManagementTypeCodeMetadataExtensions
{
    private static readonly AccountManagementTypeCodeDropdownSource _dropdownSource = new AccountManagementTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountManagementTypeCodeDropdownRow GetMetadata(this AccountManagementTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


