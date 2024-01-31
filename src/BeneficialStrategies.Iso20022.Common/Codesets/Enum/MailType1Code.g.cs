﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MailType1Code.  ISO2002 ID# _gpYLECCXEeWJd9HF2tO7BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of mail service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gpYLECCXEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of mail service.")]
[DerivedFrom(typeof(MailTypeCode))]
public enum MailType1Code
{
    /// <summary>
    /// Air mail.
    /// Encoded/decoded by serializers as "AIRM".
    /// </summary>
    [EnumMember(Value = "AIRM")]
    [IsoId("_jWjjASCXEeWJd9HF2tO7BA")]
    [Description(@"Air mail.")]
    AirMail = MailTypeCode.AirMail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ordinary mail.
    /// Encoded/decoded by serializers as "ORDM".
    /// </summary>
    [EnumMember(Value = "ORDM")]
    [IsoId("_jdi70SCXEeWJd9HF2tO7BA")]
    [Description(@"Ordinary mail.")]
    OrdinaryMail = MailTypeCode.OrdinaryMail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Registered Mail.
    /// Encoded/decoded by serializers as "REGM".
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_jkZKsSCXEeWJd9HF2tO7BA")]
    [Description(@"Registered Mail.")]
    RegisteredMail = MailTypeCode.RegisteredMail, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MailType1CodeMetadataExtensions
{
    private static readonly MailType1CodeDropdownSource _dropdownSource = new MailType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMailType1CodeDropdownRow GetMetadata(this MailType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


