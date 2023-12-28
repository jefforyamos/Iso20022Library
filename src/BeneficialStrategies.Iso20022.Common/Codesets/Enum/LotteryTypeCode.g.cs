﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LotteryTypeCode.  ISO2002 ID# _afolpNp-Ed-ak6NoX_4Aeg_1755473361.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of lottery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afolpNp-Ed-ak6NoX_4Aeg_1755473361")]
[Description(@"Specifies the type of lottery.")]
public enum LotteryTypeCode
{
    /// <summary>
    /// Original lottery that has been announced for a specific amount and date.
    /// Encoded/decoded by serializers as "ORIG".
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_afolpdp-Ed-ak6NoX_4Aeg_2038993840")]
    [Description(@"Original lottery that has been announced for a specific amount and date.")]
    OriginalLotteryNotification,
    
    /// <summary>
    /// Supplemental or additional quantity called on a previously announced original lottery.
    /// Encoded/decoded by serializers as "SUPP".
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_afolptp-Ed-ak6NoX_4Aeg_2144275992")]
    [Description(@"Supplemental or additional quantity called on a previously announced original lottery.")]
    SupplementalLotteryNotification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LotteryTypeCodeMetadataExtensions
{
    private static readonly LotteryTypeCodeDropdownSource _dropdownSource = new LotteryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILotteryTypeCodeDropdownRow GetMetadata(this LotteryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

