﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferReasonCode.  ISO2002 ID# _le2Gw_r4EeCu2Z1WwxJVWA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the assets transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_le2Gw_r4EeCu2Z1WwxJVWA")]
[Description(@"Specifies the reason for the assets transfer.")]
public enum TransferReasonCode
{
    /// <summary>
    /// Transfer is ordinary.
    /// Encoded/decoded by serializers as "TRAO".
    /// </summary>
    [EnumMember(Value = "TRAO")]
    [IsoId("_mFSbt_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is ordinary.")]
    OrdinaryTransfer,
    
    /// <summary>
    /// Transfer is between spouses.
    /// Encoded/decoded by serializers as "TRAC".
    /// </summary>
    [EnumMember(Value = "TRAC")]
    [IsoId("_sGzSN_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is between spouses.")]
    TransferBetweenSpouses,
    
    /// <summary>
    /// Transfer is the result of a demerger or division.
    /// Encoded/decoded by serializers as "TRAF".
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_xr2PJ_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is the result of a demerger or division.")]
    Demerger,
    
    /// <summary>
    /// Transfer is a gift.
    /// Encoded/decoded by serializers as "TRAG".
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_7PtyEfr4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is a gift.")]
    Gift,
    
    /// <summary>
    /// Transfer is a heritage.
    /// Encoded/decoded by serializers as "TRAI".
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_-BogF_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is a heritage.")]
    Heritage,
    
    /// <summary>
    /// Transfer is between own accounts.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_B9U5l_r5EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is between own accounts.")]
    BetweenOwnAccounts,
    
    /// <summary>
    /// Transfer is a trade.
    /// Encoded/decoded by serializers as "TRAT".
    /// </summary>
    [EnumMember(Value = "TRAT")]
    [IsoId("_GEpUR_r5EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is a trade.")]
    Trade,
    
    /// <summary>
    /// Transfer is an undivided possession.
    /// Encoded/decoded by serializers as "TRAU".
    /// </summary>
    [EnumMember(Value = "TRAU")]
    [IsoId("_Jncsp_r5EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is an undivided possession.")]
    UndividedPossession,
    
    /// <summary>
    /// Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police).
    /// Encoded/decoded by serializers as "TPLD".
    /// </summary>
    [EnumMember(Value = "TPLD")]
    [IsoId("_mv3UoP_YEeCq5NtzDTui4w")]
    [Description(@"Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police).")]
    PledgedAccountTransfer,
    
    /// <summary>
    /// Transfer between different beneficiaries with taxation to be applied (accounts with different owner).
    /// Encoded/decoded by serializers as "TRPE".
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_xSUmwP_YEeCq5NtzDTui4w")]
    [Description(@"Transfer between different beneficiaries with taxation to be applied (accounts with different owner).")]
    TransferBetweenDifferentBeneficiaries,
    
    /// <summary>
    /// Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process).
    /// Encoded/decoded by serializers as "TTDT".
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_4jZnsP_YEeCq5NtzDTui4w")]
    [Description(@"Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process).")]
    TDTFrameworkTransfer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferReasonCodeMetadataExtensions
{
    private static readonly TransferReasonCodeDropdownSource _dropdownSource = new TransferReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferReasonCodeDropdownRow GetMetadata(this TransferReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


