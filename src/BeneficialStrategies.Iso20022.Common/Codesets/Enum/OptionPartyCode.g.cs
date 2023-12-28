﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionPartyCode.  ISO2002 ID# _aP_AFdp-Ed-ak6NoX_4Aeg_1203136897.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if a trade party is a buyer or a seller.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aP_AFdp-Ed-ak6NoX_4Aeg_1203136897")]
[Description(@"Specifies if a trade party is a buyer or a seller.")]
[Derivations(typeof(OptionParty1Code),typeof(OptionParty3Code))]
// External derivations that should be provided by the proper interface are: 
public enum OptionPartyCode
{
    /// <summary>
    /// Seller in a trade.
    /// Encoded/decoded by serializers as "SLLR".
    /// </summary>
    [EnumMember(Value = "SLLR")]
    [IsoId("_aP_AFtp-Ed-ak6NoX_4Aeg_1933638709")]
    [Description(@"Seller in a trade.")]
    Seller,
    
    /// <summary>
    /// Buyer in a trade.
    /// Encoded/decoded by serializers as "BYER".
    /// </summary>
    [EnumMember(Value = "BYER")]
    [IsoId("_aP_AF9p-Ed-ak6NoX_4Aeg_1865301081")]
    [Description(@"Buyer in a trade.")]
    Buyer,
    
    /// <summary>
    /// Indicates the initiator of the trade.
    /// Encoded/decoded by serializers as "TAKE".
    /// </summary>
    [EnumMember(Value = "TAKE")]
    [IsoId("_GvogoDxIEeWZTovCemTvqg")]
    [Description(@"Indicates the initiator of the trade.")]
    Taker,
    
    /// <summary>
    /// Indicates the receiver of the trade.
    /// Encoded/decoded by serializers as "MAKE".
    /// </summary>
    [EnumMember(Value = "MAKE")]
    [IsoId("_KBoc4DxIEeWZTovCemTvqg")]
    [Description(@"Indicates the receiver of the trade.")]
    Maker,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionPartyCodeMetadataExtensions
{
    private static readonly OptionPartyCodeDropdownSource _dropdownSource = new OptionPartyCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionPartyCodeDropdownRow GetMetadata(this OptionPartyCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


