﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountStatus4Code.  ISO2002 ID# _VfjYECF1EeW9XJWqfgXIIA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VfjYECF1EeW9XJWqfgXIIA")]
[Description(@"Specifies the status of an account.")]
[DerivedFrom(typeof(AccountStatusCode))]
public enum AccountStatus4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Enabled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZRLPkSF1EeW9XJWqfgXIIA")]
    [Description(@"??")]
    Enabled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Disabled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z6_BkSF1EeW9XJWqfgXIIA")]
    [Description(@"??")]
    Disabled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aHU0cSF1EeW9XJWqfgXIIA")]
    [Description(@"??")]
    Pending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProForma".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aXZQwSF1EeW9XJWqfgXIIA")]
    [Description(@"??")]
    ProForma,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountStatus4CodeMetadataExtensions
{
    private static readonly AccountStatus4CodeDropdownSource _dropdownSource = new AccountStatus4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountStatus4CodeDropdownRow GetMetadata(this AccountStatus4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

