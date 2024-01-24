﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMMediaType1Code.  ISO2002 ID# _-L27wIqdEeS4a4abTJTSSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of media inside an ATM cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-L27wIqdEeS4a4abTJTSSw")]
[Description(@"Type of media inside an ATM cassette.")]
[DerivedFrom(typeof(ATMMediaTypeCode))]
public enum ATMMediaType1Code
{
    /// <summary>
    /// Card media.
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_JV2vAYqeEeS4a4abTJTSSw")]
    [Description(@"Card media.")]
    Cards = ATMMediaTypeCode.Cards, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Coin media.
    /// Encoded/decoded by serializers as "COIN".
    /// </summary>
    [EnumMember(Value = "COIN")]
    [IsoId("_Jcs94YqeEeS4a4abTJTSSw")]
    [Description(@"Coin media.")]
    Coins = ATMMediaTypeCode.Coins, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non fixed value of the media, for instance gold, silver.
    /// Encoded/decoded by serializers as "CMDT".
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_Jiqb8YqeEeS4a4abTJTSSw")]
    [Description(@"Non fixed value of the media, for instance gold, silver.")]
    Commodity = ATMMediaTypeCode.Commodity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Coupon media.
    /// Encoded/decoded by serializers as "CPNS".
    /// </summary>
    [EnumMember(Value = "CPNS")]
    [IsoId("_JnvJMYqeEeS4a4abTJTSSw")]
    [Description(@"Coupon media.")]
    Coupons = ATMMediaTypeCode.Coupons, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank note media.
    /// Encoded/decoded by serializers as "NOTE".
    /// </summary>
    [EnumMember(Value = "NOTE")]
    [IsoId("_J9VlwYqeEeS4a4abTJTSSw")]
    [Description(@"Bank note media.")]
    Notes = ATMMediaTypeCode.Notes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stamp media.
    /// Encoded/decoded by serializers as "STMP".
    /// </summary>
    [EnumMember(Value = "STMP")]
    [IsoId("_KFrpcYqeEeS4a4abTJTSSw")]
    [Description(@"Stamp media.")]
    Stamps = ATMMediaTypeCode.Stamps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undetermined medias.
    /// Encoded/decoded by serializers as "UDTM".
    /// </summary>
    [EnumMember(Value = "UDTM")]
    [IsoId("_KMFzcYqeEeS4a4abTJTSSw")]
    [Description(@"Undetermined medias.")]
    Undetermined = ATMMediaTypeCode.Undetermined, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMMediaType1CodeMetadataExtensions
{
    private static readonly ATMMediaType1CodeDropdownSource _dropdownSource = new ATMMediaType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMMediaType1CodeDropdownRow GetMetadata(this ATMMediaType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


