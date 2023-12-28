﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MailTypeCode.  ISO2002 ID# _OrfCICCXEeWJd9HF2tO7BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of mail service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OrfCICCXEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of mail service.")]
[Derivations(typeof(MailType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum MailTypeCode
{
    /// <summary>
    /// Air mail.
    /// Encoded/decoded by serializers as "AIRM".
    /// </summary>
    [EnumMember(Value = "AIRM")]
    [IsoId("_TWh08CCXEeWJd9HF2tO7BA")]
    [Description(@"Air mail.")]
    AirMail,
    
    /// <summary>
    /// Ordinary mail.
    /// Encoded/decoded by serializers as "ORDM".
    /// </summary>
    [EnumMember(Value = "ORDM")]
    [IsoId("_WlBxQCCXEeWJd9HF2tO7BA")]
    [Description(@"Ordinary mail.")]
    OrdinaryMail,
    
    /// <summary>
    /// Registered Mail.
    /// Encoded/decoded by serializers as "REGM".
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_ZmldwCCXEeWJd9HF2tO7BA")]
    [Description(@"Registered Mail.")]
    RegisteredMail,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MailTypeCodeMetadataExtensions
{
    private static readonly MailTypeCodeDropdownSource _dropdownSource = new MailTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMailTypeCodeDropdownRow GetMetadata(this MailTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


