﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageProtectionCode.  ISO2002 ID# _5Id0YIrfEeSvuOJS0mmL0g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Mechanism used to protect the message of the ATM protocol.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5Id0YIrfEeSvuOJS0mmL0g")]
[Description(@"Mechanism used to protect the message of the ATM protocol.")]
[Derivations(typeof(MessageProtection1Code))]
public enum MessageProtectionCode
{
    /// <summary>
    /// Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption).
    /// Encoded/decoded by serializers as "EVLP".
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_8CumEIrfEeSvuOJS0mmL0g")]
    [Description(@"Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption).")]
    EnvelopedMessage,
    
    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the body only.
    /// Encoded/decoded by serializers as "MACB".
    /// </summary>
    [EnumMember(Value = "MACB")]
    [IsoId("__NiVMIrfEeSvuOJS0mmL0g")]
    [Description(@"Messages contain a MAC or a digital signature computed on the body only.")]
    MACBody,
    
    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the complete message (header plus body).
    /// Encoded/decoded by serializers as "MACM".
    /// </summary>
    [EnumMember(Value = "MACM")]
    [IsoId("_B1oY0IrgEeSvuOJS0mmL0g")]
    [Description(@"Messages contain a MAC or a digital signature computed on the complete message (header plus body).")]
    MACMessage,
    
    /// <summary>
    /// Messages are not protected, no encryption and no MAC or digital signature.
    /// Encoded/decoded by serializers as "UNPR".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_EaI88IrgEeSvuOJS0mmL0g")]
    [Description(@"Messages are not protected, no encryption and no MAC or digital signature.")]
    NoProtection,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageProtectionCodeMetadataExtensions
{
    private static readonly MessageProtectionCodeDropdownSource _dropdownSource = new MessageProtectionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageProtectionCodeDropdownRow GetMetadata(this MessageProtectionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


