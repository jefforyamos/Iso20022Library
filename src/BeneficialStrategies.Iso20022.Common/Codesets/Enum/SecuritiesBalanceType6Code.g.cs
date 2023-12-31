﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesBalanceType6Code.  ISO2002 ID# _ZCf5Q9p-Ed-ak6NoX_4Aeg_-1599060186.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZCf5Q9p-Ed-ak6NoX_4Aeg_-1599060186")]
[Description(@"Specifies the type of securities balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum SecuritiesBalanceType6Code
{
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "Available".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_ZCf5RNp-Ed-ak6NoX_4Aeg_-1599060177")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available,
    
    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the "escrow balance" or "sequestered balance".
    /// Encoded/decoded by serializers as "Restricted".
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ZCf5Rdp-Ed-ak6NoX_4Aeg_-1598140176")]
    [Description(@"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance"".")]
    Restricted,
    
    /// <summary>
    /// Total quantity of financial instruments entitled to the account owner based on the terms of the corporate action event.
    /// Encoded/decoded by serializers as "TotalEntitled".
    /// </summary>
    [EnumMember(Value = "TENT")]
    [IsoId("_ZCf5Rtp-Ed-ak6NoX_4Aeg_-1598140175")]
    [Description(@"Total quantity of financial instruments entitled to the account owner based on the terms of the corporate action event.")]
    TotalEntitled,
    
    /// <summary>
    /// Balance of financial instruments that are reserved for the distribution of the proceeds.
    /// Encoded/decoded by serializers as "ReservedForDistribution".
    /// </summary>
    [EnumMember(Value = "RDIS")]
    [IsoId("_ZCf5R9p-Ed-ak6NoX_4Aeg_-1598140154")]
    [Description(@"Balance of financial instruments that are reserved for the distribution of the proceeds.")]
    ReservedForDistribution,
    
    /// <summary>
    /// Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged.
    /// Encoded/decoded by serializers as "ReservedForRemoval".
    /// </summary>
    [EnumMember(Value = "RREM")]
    [IsoId("_ZCf5SNp-Ed-ak6NoX_4Aeg_-1598140145")]
    [Description(@"Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged.")]
    ReservedForRemoval,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesBalanceType6CodeMetadataExtensions
{
    private static readonly SecuritiesBalanceType6CodeDropdownSource _dropdownSource = new SecuritiesBalanceType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesBalanceType6CodeDropdownRow GetMetadata(this SecuritiesBalanceType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


