﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountStatus3Code.  ISO2002 ID# _Yajvgdp-Ed-ak6NoX_4Aeg_-2144762850.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies further the current state of an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yajvgdp-Ed-ak6NoX_4Aeg_-2144762850")]
[Description(@"Qualifies further the current state of an account.")]
[DerivedFrom(typeof(AccountStatusCode))]
public enum AccountStatus3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Enabled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yajvgtp-Ed-ak6NoX_4Aeg_-2072727728")]
    [Description(@"??")]
    Enabled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Disabled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yajvg9p-Ed-ak6NoX_4Aeg_-2045022067")]
    [Description(@"??")]
    Disabled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Deleted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YajvhNp-Ed-ak6NoX_4Aeg_-2017316036")]
    [Description(@"??")]
    Deleted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProForma".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yajvhdp-Ed-ak6NoX_4Aeg_-1757807861")]
    [Description(@"??")]
    ProForma,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountStatus3CodeMetadataExtensions
{
    private static readonly AccountStatus3CodeDropdownSource _dropdownSource = new AccountStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountStatus3CodeDropdownRow GetMetadata(this AccountStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


