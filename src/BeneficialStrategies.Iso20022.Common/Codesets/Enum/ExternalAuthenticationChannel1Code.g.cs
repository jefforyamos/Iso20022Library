﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalAuthenticationChannel1Code.  ISO2002 ID# _5C8hAZdfEea1K6JAcAwoVg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction authentication channel, as published in an external authentication channel code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5C8hAZdfEea1K6JAcAwoVg")]
[Description(@"Specifies the transaction authentication channel, as published in an external authentication channel code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalAuthenticationChannelCode))]
public enum ExternalAuthenticationChannel1Code
{
    /// <summary>
    /// Authentication provided through ATM
    /// Encoded/decoded by serializers as "ATMA".
    /// </summary>
    [EnumMember(Value = "ATMA")]
    [IsoId("_uZHtovRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through ATM")]
    ATM = ExternalAuthenticationChannelCode.ATM, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication provided through Card
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_uZHtpfRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Card")]
    Card = ExternalAuthenticationChannelCode.Card, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication provided through Internet Banking
    /// Encoded/decoded by serializers as "INBA".
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_uZHtqPRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Internet Banking")]
    InternetBanking = ExternalAuthenticationChannelCode.InternetBanking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication provided through Mobile
    /// Encoded/decoded by serializers as "MOBI".
    /// </summary>
    [EnumMember(Value = "MOBI")]
    [IsoId("_uZReovRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Mobile")]
    Mobile = ExternalAuthenticationChannelCode.Mobile, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalAuthenticationChannel1CodeMetadataExtensions
{
    private static readonly ExternalAuthenticationChannel1CodeDropdownSource _dropdownSource = new ExternalAuthenticationChannel1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalAuthenticationChannel1CodeDropdownRow GetMetadata(this ExternalAuthenticationChannel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


