﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionParty1Code.  ISO2002 ID# _aP_AEtp-Ed-ak6NoX_4Aeg_2105414994.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if a trade party is a buyer or a seller.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aP_AEtp-Ed-ak6NoX_4Aeg_2105414994")]
[Description(@"Specifies if a trade party is a buyer or a seller.")]
[DerivedFrom(typeof(OptionPartyCode))]
public enum OptionParty1Code
{
    /// <summary>
    /// Seller in a trade.
    /// Encoded/decoded by serializers as "Seller".
    /// </summary>
    [EnumMember(Value = "SLLR")]
    [IsoId("_aP_AE9p-Ed-ak6NoX_4Aeg_-1870012986")]
    [Description(@"Seller in a trade.")]
    Seller,
    
    /// <summary>
    /// Buyer in a trade.
    /// Encoded/decoded by serializers as "Buyer".
    /// </summary>
    [EnumMember(Value = "BYER")]
    [IsoId("_aP_AFNp-Ed-ak6NoX_4Aeg_-1870012969")]
    [Description(@"Buyer in a trade.")]
    Buyer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionParty1CodeMetadataExtensions
{
    private static readonly OptionParty1CodeDropdownSource _dropdownSource = new OptionParty1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionParty1CodeDropdownRow GetMetadata(this OptionParty1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


