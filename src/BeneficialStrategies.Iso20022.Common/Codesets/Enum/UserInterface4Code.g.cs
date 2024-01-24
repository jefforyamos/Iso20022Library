﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UserInterface4Code.  ISO2002 ID# _xKxc4IO_EeSWSLYdc10LRg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Destination of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xKxc4IO_EeSWSLYdc10LRg")]
[Description(@"Destination of the message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface4Code
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as "CDSP".
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_y9Xb4YO_EeSWSLYdc10LRg")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay = UserInterfaceCode.CardholderDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as "CRCP".
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_zakVQYO_EeSWSLYdc10LRg")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt = UserInterfaceCode.CardholderReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant display or interface.
    /// Encoded/decoded by serializers as "MDSP".
    /// </summary>
    [EnumMember(Value = "MDSP")]
    [IsoId("_zpBoAYO_EeSWSLYdc10LRg")]
    [Description(@"Merchant display or interface.")]
    MerchantDisplay = UserInterfaceCode.MerchantDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant receipt.
    /// Encoded/decoded by serializers as "MRCP".
    /// </summary>
    [EnumMember(Value = "MRCP")]
    [IsoId("_zwx10YO_EeSWSLYdc10LRg")]
    [Description(@"Merchant receipt.")]
    MerchantReceipt = UserInterfaceCode.MerchantReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other interface of the cardholder, for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as "CRDO".
    /// </summary>
    [EnumMember(Value = "CRDO")]
    [IsoId("_0DQF4YO_EeSWSLYdc10LRg")]
    [Description(@"Other interface of the cardholder, for instance e-mail or smartphone message.")]
    OtherCardholderInterface = UserInterfaceCode.OtherCardholderInterface, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UserInterface4CodeMetadataExtensions
{
    private static readonly UserInterface4CodeDropdownSource _dropdownSource = new UserInterface4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUserInterface4CodeDropdownRow GetMetadata(this UserInterface4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


