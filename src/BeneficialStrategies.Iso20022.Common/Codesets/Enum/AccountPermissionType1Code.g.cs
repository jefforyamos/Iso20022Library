﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountPermissionType1Code.  ISO2002 ID# _9snSQJiuEeO4o528ngEXuw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the permission to use the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9snSQJiuEeO4o528ngEXuw")]
[Description(@"Specifies the permission to use the account.")]
[DerivedFrom(typeof(AccountPermissionTypeCode))]
public enum AccountPermissionType1Code
{
    /// <summary>
    /// No right to use the account.
    /// Encoded/decoded by serializers as "NORI".
    /// </summary>
    [EnumMember(Value = "NORI")]
    [IsoId("_WMuDoZiyEeOuCKiE8vUpBQ")]
    [Description(@"No right to use the account.")]
    NoRight = AccountPermissionTypeCode.NoRight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Right to use the account alone.
    /// Encoded/decoded by serializers as "RIAL".
    /// </summary>
    [EnumMember(Value = "RIAL")]
    [IsoId("_WbHsAZiyEeOuCKiE8vUpBQ")]
    [Description(@"Right to use the account alone.")]
    RightToUseAlone = AccountPermissionTypeCode.RightToUseAlone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Right to use the account together with another person.
    /// Encoded/decoded by serializers as "RIWI".
    /// </summary>
    [EnumMember(Value = "RIWI")]
    [IsoId("_WoKCcZiyEeOuCKiE8vUpBQ")]
    [Description(@"Right to use the account together with another person.")]
    RightToUseWithOther = AccountPermissionTypeCode.RightToUseWithOther, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountPermissionType1CodeMetadataExtensions
{
    private static readonly AccountPermissionType1CodeDropdownSource _dropdownSource = new AccountPermissionType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountPermissionType1CodeDropdownRow GetMetadata(this AccountPermissionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


