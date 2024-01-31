﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Verification1Code.  ISO2002 ID# _uTRSAGjpEeSDR-pyia6Xtg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uTRSAGjpEeSDR-pyia6Xtg")]
[Description(@"Result of the verification.")]
[DerivedFrom(typeof(VerificationCode))]
public enum Verification1Code
{
    /// <summary>
    /// Verification failed.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_xPkEAWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification failed.")]
    Failed = VerificationCode.Failed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information required to perform the verification was missing.
    /// Encoded/decoded by serializers as "MISS".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_xVtvUWjpEeSDR-pyia6Xtg")]
    [Description(@"Information required to perform the verification was missing.")]
    Missing = VerificationCode.Missing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification has not been performed.
    /// Encoded/decoded by serializers as "NOVF".
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_xdGwwWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification has not been performed.")]
    NotPerformed = VerificationCode.NotPerformed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification was partially successful.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_xib8sWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification was partially successful.")]
    PartialMatch = VerificationCode.PartialMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification was successful.
    /// Encoded/decoded by serializers as "SUCC".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_xpMsAWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification was successful.")]
    Successful = VerificationCode.Successful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device or entity to perform the verification was unavailable.
    /// Encoded/decoded by serializers as "ERRR".
    /// </summary>
    [EnumMember(Value = "ERRR")]
    [IsoId("_xwe_wWjpEeSDR-pyia6Xtg")]
    [Description(@"Device or entity to perform the verification was unavailable.")]
    TechnicalError = VerificationCode.TechnicalError, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Verification1CodeMetadataExtensions
{
    private static readonly Verification1CodeDropdownSource _dropdownSource = new Verification1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVerification1CodeDropdownRow GetMetadata(this Verification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


