﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferReason1Code.  ISO2002 ID# _SGnRUPr5EeCu2Z1WwxJVWA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the assets transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SGnRUPr5EeCu2Z1WwxJVWA")]
[Description(@"Specifies the reason for the assets transfer.")]
[DerivedFrom(typeof(TransferReasonCode))]
public enum TransferReason1Code
{
    /// <summary>
    /// Transfer is an undivided possession.
    /// Encoded/decoded by serializers as "UndividedPossession".
    /// </summary>
    [EnumMember(Value = "TRAU")]
    [IsoId("_jmXjef8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is an undivided possession.")]
    UndividedPossession,
    
    /// <summary>
    /// Transfer is between spouses.
    /// Encoded/decoded by serializers as "TransferBetweenSpouses".
    /// </summary>
    [EnumMember(Value = "TRAC")]
    [IsoId("_jpfv_v8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is between spouses.")]
    TransferBetweenSpouses,
    
    /// <summary>
    /// Transfer is a trade.
    /// Encoded/decoded by serializers as "Trade".
    /// </summary>
    [EnumMember(Value = "TRAT")]
    [IsoId("_jt-ATv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is a trade.")]
    Trade,
    
    /// <summary>
    /// Transfer is ordinary.
    /// Encoded/decoded by serializers as "OrdinaryTransfer".
    /// </summary>
    [EnumMember(Value = "TRAO")]
    [IsoId("_jyIunv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is ordinary.")]
    OrdinaryTransfer,
    
    /// <summary>
    /// Transfer is a heritage.
    /// Encoded/decoded by serializers as "Heritage".
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_j1kdHv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is a heritage.")]
    Heritage,
    
    /// <summary>
    /// Transfer is a gift.
    /// Encoded/decoded by serializers as "Gift".
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_j5cQfv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is a gift.")]
    Gift,
    
    /// <summary>
    /// Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police).
    /// Encoded/decoded by serializers as "PledgedAccountTransfer".
    /// </summary>
    [EnumMember(Value = "TPLD")]
    [IsoId("_-i0zjv_YEeCq5NtzDTui4w")]
    [Description(@"Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police).")]
    PledgedAccountTransfer,
    
    /// <summary>
    /// Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process).
    /// Encoded/decoded by serializers as "TDTFrameworkTransfer".
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_-mZr9v_YEeCq5NtzDTui4w")]
    [Description(@"Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process).")]
    TDTFrameworkTransfer,
    
    /// <summary>
    /// Transfer between different beneficiaries with taxation to be applied (accounts with different owner).
    /// Encoded/decoded by serializers as "TransferBetweenDifferentBeneficiaries".
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_-q38Tv_YEeCq5NtzDTui4w")]
    [Description(@"Transfer between different beneficiaries with taxation to be applied (accounts with different owner).")]
    TransferBetweenDifferentBeneficiaries,
    
    /// <summary>
    /// Transfer is the result of a demerger or division.
    /// Encoded/decoded by serializers as "Demerger".
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_E7sZBgCoEeG3Ye2sV3fsog")]
    [Description(@"Transfer is the result of a demerger or division.")]
    Demerger,
    
    /// <summary>
    /// Transfer is between own accounts.
    /// Encoded/decoded by serializers as "BetweenOwnAccounts".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_-h3G4ENHEeGHJ_bHJRPaIQ_318694537")]
    [Description(@"Transfer is between own accounts.")]
    BetweenOwnAccounts,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferReason1CodeMetadataExtensions
{
    private static readonly TransferReason1CodeDropdownSource _dropdownSource = new TransferReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferReason1CodeDropdownRow GetMetadata(this TransferReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


