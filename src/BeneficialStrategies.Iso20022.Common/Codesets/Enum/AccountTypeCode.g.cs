﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountTypeCode.  ISO2002 ID# _brxooNp-Ed-ak6NoX_4Aeg_-1139230209.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_brxooNp-Ed-ak6NoX_4Aeg_-1139230209")]
[Description(@"Specifies the type of account.")]
public enum AccountTypeCode
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_brxoodp-Ed-ak6NoX_4Aeg_-841858447")]
    [Description(@"Cash account.")]
    Cash,
    
    /// <summary>
    /// Securities account.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_brxootp-Ed-ak6NoX_4Aeg_-841858438")]
    [Description(@"Securities account.")]
    Securities,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountTypeCodeMetadataExtensions
{
    private static readonly AccountTypeCodeDropdownSource _dropdownSource = new AccountTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountTypeCodeDropdownRow GetMetadata(this AccountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


