﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UserInterface5Code.  ISO2002 ID# _7Gewga13EeWMg5rOByfExw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Destination of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7Gewga13EeWMg5rOByfExw")]
[Description(@"Destination of the message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface5Code
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as "CardholderDisplay".
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_7SQisa13EeWMg5rOByfExw")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay,
    
    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as "CardholderReceipt".
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_7SQis613EeWMg5rOByfExw")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt,
    
    /// <summary>
    /// Other interface of the cardholder, for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as "OtherCardholderInterface".
    /// </summary>
    [EnumMember(Value = "CRDO")]
    [IsoId("_7SQiua13EeWMg5rOByfExw")]
    [Description(@"Other interface of the cardholder, for instance e-mail or smartphone message.")]
    OtherCardholderInterface,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UserInterface5CodeMetadataExtensions
{
    private static readonly UserInterface5CodeDropdownSource _dropdownSource = new UserInterface5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUserInterface5CodeDropdownRow GetMetadata(this UserInterface5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


