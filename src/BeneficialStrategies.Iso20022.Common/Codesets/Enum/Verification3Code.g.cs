﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Verification3Code.  ISO2002 ID# _soVKwCYDEeym0KcvJF9aDQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_soVKwCYDEeym0KcvJF9aDQ")]
[Description(@"Result of a verification.")]
[DerivedFrom(typeof(VerificationCode))]
public enum Verification3Code
{
    /// <summary>
    /// Verification failed.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_u1PuQSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification failed.")]
    Failed = VerificationCode.Failed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further action required.
    /// Encoded/decoded by serializers as "FUTA".
    /// </summary>
    [EnumMember(Value = "FUTA")]
    [IsoId("_u50FMSYDEeym0KcvJF9aDQ")]
    [Description(@"Further action required.")]
    FurtherAction = VerificationCode.FurtherAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information required to perform the verification was missing.
    /// Encoded/decoded by serializers as "MISS".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_u-LAwSYDEeym0KcvJF9aDQ")]
    [Description(@"Information required to perform the verification was missing.")]
    Missing = VerificationCode.Missing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not support the verification type
    /// Encoded/decoded by serializers as "NOSP".
    /// </summary>
    [EnumMember(Value = "NOSP")]
    [IsoId("_vCrtUSYDEeym0KcvJF9aDQ")]
    [Description(@"Not support the verification type")]
    NotSupported = VerificationCode.NotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification has not been performed.
    /// Encoded/decoded by serializers as "NOVF".
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_vGt4wSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification has not been performed.")]
    NotPerformed = VerificationCode.NotPerformed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other result of verification defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_vYRi0SYDEeym0KcvJF9aDQ")]
    [Description(@"Other result of verification defined at national level.")]
    OtherNational = VerificationCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other result of verification defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_vdmuwSYDEeym0KcvJF9aDQ")]
    [Description(@"Other result of verification defined at private level.")]
    OtherPrivate = VerificationCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification was partially successful.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_vhphQSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification was partially successful.")]
    PartialMatch = VerificationCode.PartialMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification was successful.
    /// Encoded/decoded by serializers as "SUCC".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_vmhaMSYDEeym0KcvJF9aDQ")]
    [Description(@"Verification was successful.")]
    Successful = VerificationCode.Successful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device or entity to perform the verification was unavailable.
    /// Encoded/decoded by serializers as "ERRR".
    /// </summary>
    [EnumMember(Value = "ERRR")]
    [IsoId("_vqukwSYDEeym0KcvJF9aDQ")]
    [Description(@"Device or entity to perform the verification was unavailable.")]
    TechnicalError = VerificationCode.TechnicalError, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Verification3CodeMetadataExtensions
{
    private static readonly Verification3CodeDropdownSource _dropdownSource = new Verification3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVerification3CodeDropdownRow GetMetadata(this Verification3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


