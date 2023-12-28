﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LotteryType1Code.  ISO2002 ID# _afolodp-Ed-ak6NoX_4Aeg_-1740647870.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of lottery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afolodp-Ed-ak6NoX_4Aeg_-1740647870")]
[Description(@"Specifies the type of lottery.")]
[DerivedFrom(typeof(LotteryTypeCode))]
public enum LotteryType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OriginalLotteryNotification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_afolotp-Ed-ak6NoX_4Aeg_-1740647868")]
    [Description(@"??")]
    OriginalLotteryNotification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SupplementalLotteryNotification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_afolo9p-Ed-ak6NoX_4Aeg_-1740647840")]
    [Description(@"??")]
    SupplementalLotteryNotification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LotteryType1CodeMetadataExtensions
{
    private static readonly LotteryType1CodeDropdownSource _dropdownSource = new LotteryType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILotteryType1CodeDropdownRow GetMetadata(this LotteryType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

