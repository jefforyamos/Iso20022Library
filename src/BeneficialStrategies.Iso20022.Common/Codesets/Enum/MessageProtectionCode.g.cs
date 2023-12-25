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
public enum MessageProtectionCode
{
    /// <summary>
    /// Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption).
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_8CumEIrfEeSvuOJS0mmL0g")]
    [Description(@"Messages contain an encrypted body and a MAC or a digital signature computed on the complete message (header plus body after encryption).")]
    EVLP,
    
    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the body only.
    /// </summary>
    [EnumMember(Value = "MACB")]
    [IsoId("__NiVMIrfEeSvuOJS0mmL0g")]
    [Description(@"Messages contain a MAC or a digital signature computed on the body only.")]
    MACB,
    
    /// <summary>
    /// Messages contain a MAC or a digital signature computed on the complete message (header plus body).
    /// </summary>
    [EnumMember(Value = "MACM")]
    [IsoId("_B1oY0IrgEeSvuOJS0mmL0g")]
    [Description(@"Messages contain a MAC or a digital signature computed on the complete message (header plus body).")]
    MACM,
    
    /// <summary>
    /// Messages are not protected, no encryption and no MAC or digital signature.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_EaI88IrgEeSvuOJS0mmL0g")]
    [Description(@"Messages are not protected, no encryption and no MAC or digital signature.")]
    UNPR,
    
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


