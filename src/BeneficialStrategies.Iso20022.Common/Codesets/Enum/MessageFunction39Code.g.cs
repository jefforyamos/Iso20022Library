﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction39Code.  ISO2002 ID# _7NuDMcsZEeizUq4cFQ71-Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7NuDMcsZEeizUq4cFQ71-Q")]
[Description(@"Identifies the type of process related to the message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction39Code
{
    /// <summary>
    /// Notification of a rejected message.
    /// Encoded/decoded by serializers as "RENO".
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_XATzEPGrEeiGNursv3uE_g")]
    [Description(@"Notification of a rejected message.")]
    RejectNotification = MessageFunctionCode.RejectNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification of a message containing errors.
    /// Encoded/decoded by serializers as "ERNO".
    /// </summary>
    [EnumMember(Value = "ERNO")]
    [IsoId("_XF6r0fGrEeiGNursv3uE_g")]
    [Description(@"Notification of a message containing errors.")]
    ErrorNotification = MessageFunctionCode.ErrorNotification, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction39CodeMetadataExtensions
{
    private static readonly MessageFunction39CodeDropdownSource _dropdownSource = new MessageFunction39CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction39CodeDropdownRow GetMetadata(this MessageFunction39Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


