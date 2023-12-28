﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardIdentificationTypeCode.  ISO2002 ID# _bEGccNthEeipuvJHTHIw9A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of account identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEGccNthEeipuvJHTHIw9A")]
[Description(@"Type of account identification.")]
public enum CardIdentificationTypeCode
{
    /// <summary>
    /// Standard card identification (card number).
    /// Encoded/decoded by serializers as "CPAN".
    /// </summary>
    [EnumMember(Value = "CPAN")]
    [IsoId("_hi4dwNthEeipuvJHTHIw9A")]
    [Description(@"Standard card identification (card number).")]
    PrimaryAccountNumber,
    
    /// <summary>
    /// ISO Track 2 including identification.
    /// Encoded/decoded by serializers as "ISO2".
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_l8QRwNthEeipuvJHTHIw9A")]
    [Description(@"ISO Track 2 including identification.")]
    ISOTrack2,
    
    /// <summary>
    /// Bar-code with a specific form of identification.
    /// Encoded/decoded by serializers as "BARC".
    /// </summary>
    [EnumMember(Value = "BARC")]
    [IsoId("_pbMd0NthEeipuvJHTHIw9A")]
    [Description(@"Bar-code with a specific form of identification.")]
    BarCode,
    
    /// <summary>
    /// Account identification.
    /// Encoded/decoded by serializers as "ACCT".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_sVH4UNthEeipuvJHTHIw9A")]
    [Description(@"Account identification.")]
    AccountNumber,
    
    /// <summary>
    /// A phone number identifies the account on which the phone card is assigned.
    /// Encoded/decoded by serializers as "PHON".
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_vOcO0NthEeipuvJHTHIw9A")]
    [Description(@"A phone number identifies the account on which the phone card is assigned.")]
    PhoneNumber,
    
    /// <summary>
    /// A Universal Unique Identification code is set for identification.
    /// Encoded/decoded by serializers as "UUID".
    /// </summary>
    [EnumMember(Value = "UUID")]
    [IsoId("_yacQwNthEeipuvJHTHIw9A")]
    [Description(@"A Universal Unique Identification code is set for identification.")]
    UniversalUniqueIdentification,
    
    /// <summary>
    /// An identification set by a privative application.
    /// Encoded/decoded by serializers as "PRIV".
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_9ra1wNthEeipuvJHTHIw9A")]
    [Description(@"An identification set by a privative application.")]
    PrivativeNumbering,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardIdentificationTypeCodeMetadataExtensions
{
    private static readonly CardIdentificationTypeCodeDropdownSource _dropdownSource = new CardIdentificationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardIdentificationTypeCodeDropdownRow GetMetadata(this CardIdentificationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


