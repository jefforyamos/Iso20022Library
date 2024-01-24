﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UserInterface6Code.  ISO2002 ID# _OZvlwE9HEeeg87n1YQSQ_A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Interface for the destination of a message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OZvlwE9HEeeg87n1YQSQ_A")]
[Description(@"Interface for the destination of a message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface6Code
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as "CDSP".
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_WEr4MU9HEeeg87n1YQSQ_A")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay = UserInterfaceCode.CardholderDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as "CRCP".
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_Wkv4UU9HEeeg87n1YQSQ_A")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt = UserInterfaceCode.CardholderReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant display or interface.
    /// Encoded/decoded by serializers as "MDSP".
    /// </summary>
    [EnumMember(Value = "MDSP")]
    [IsoId("_W4nPgU9HEeeg87n1YQSQ_A")]
    [Description(@"Merchant display or interface.")]
    MerchantDisplay = UserInterfaceCode.MerchantDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant receipt.
    /// Encoded/decoded by serializers as "MRCP".
    /// </summary>
    [EnumMember(Value = "MRCP")]
    [IsoId("_XfIc8U9HEeeg87n1YQSQ_A")]
    [Description(@"Merchant receipt.")]
    MerchantReceipt = UserInterfaceCode.MerchantReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other interface of the cardholder, for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as "CRDO".
    /// </summary>
    [EnumMember(Value = "CRDO")]
    [IsoId("_YDNaYU9HEeeg87n1YQSQ_A")]
    [Description(@"Other interface of the cardholder, for instance e-mail or smartphone message.")]
    OtherCardholderInterface = UserInterfaceCode.OtherCardholderInterface, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File used to store the message.
    /// Encoded/decoded by serializers as "FILE".
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_gu274U9HEeeg87n1YQSQ_A")]
    [Description(@"File used to store the message.")]
    File = UserInterfaceCode.File, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information dedicated to a software application related to a device belonging to the cardholder.
    /// Encoded/decoded by serializers as "CHAP".
    /// </summary>
    [EnumMember(Value = "CHAP")]
    [IsoId("_2k6pMU9HEeeg87n1YQSQ_A")]
    [Description(@"Information dedicated to a software application related to a device belonging to the cardholder.")]
    CardholderApplication = UserInterfaceCode.CardholderApplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information dedicated to a software application related to a device belonging to the merchant.
    /// Encoded/decoded by serializers as "MRAP".
    /// </summary>
    [EnumMember(Value = "MRAP")]
    [IsoId("_8Yc4oU9IEeeg87n1YQSQ_A")]
    [Description(@"Information dedicated to a software application related to a device belonging to the merchant.")]
    MerchantApplication = UserInterfaceCode.MerchantApplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other interface of the merchant for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as "MRIN".
    /// </summary>
    [EnumMember(Value = "MRIN")]
    [IsoId("_QDYyMU9JEeeg87n1YQSQ_A")]
    [Description(@"Other interface of the merchant for instance e-mail or smartphone message.")]
    OtherMerchantInterface = UserInterfaceCode.OtherMerchantInterface, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UserInterface6CodeMetadataExtensions
{
    private static readonly UserInterface6CodeDropdownSource _dropdownSource = new UserInterface6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUserInterface6CodeDropdownRow GetMetadata(this UserInterface6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


