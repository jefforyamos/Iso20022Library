﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProtectionMethodCode.  ISO2002 ID# _ar5eoJyAEeuo7tDc4CDHXg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to protect the sensitive data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ar5eoJyAEeuo7tDc4CDHXg")]
[Description(@"Method used to protect the sensitive data.")]
[Derivations(typeof(ProtectionMethod1Code))]
public enum ProtectionMethodCode
{
    /// <summary>
    /// Software protection method.
    /// Encoded/decoded by serializers as "SOFT".
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_ihY0MJyAEeuo7tDc4CDHXg")]
    [Description(@"Software protection method.")]
    Software,
    
    /// <summary>
    /// Trusted execution environment method.
    /// Encoded/decoded by serializers as "TEEN".
    /// </summary>
    [EnumMember(Value = "TEEN")]
    [IsoId("_nIdtAJyAEeuo7tDc4CDHXg")]
    [Description(@"Trusted execution environment method.")]
    TrustedExectutionEnvironment,
    
    /// <summary>
    /// Secure element method.
    /// Encoded/decoded by serializers as "SELM".
    /// </summary>
    [EnumMember(Value = "SELM")]
    [IsoId("_v09jEJyAEeuo7tDc4CDHXg")]
    [Description(@"Secure element method.")]
    SecureElement,
    
    /// <summary>
    /// Secure enclave method.
    /// Encoded/decoded by serializers as "SNCL".
    /// </summary>
    [EnumMember(Value = "SNCL")]
    [IsoId("_2HHdoJyAEeuo7tDc4CDHXg")]
    [Description(@"Secure enclave method.")]
    SecureEnclave,
    
    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6kwtoJyAEeuo7tDc4CDHXg")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate,
    
    /// <summary>
    /// Other code assigned by national organisation.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_KZ-S0JyBEeuo7tDc4CDHXg")]
    [Description(@"Other code assigned by national organisation.")]
    OtherNational,
    
    /// <summary>
    /// Trusted Platform Module (TPM).
    /// Encoded/decoded by serializers as "TPMD".
    /// </summary>
    [EnumMember(Value = "TPMD")]
    [IsoId("_P8l5gKH1EeuiuNcvKhXmNQ")]
    [Description(@"Trusted Platform Module (TPM).")]
    TrustedPlatformModule,
    
    /// <summary>
    /// Virtual trusted execution environment	
    /// Encoded/decoded by serializers as "VTEE".
    /// </summary>
    [EnumMember(Value = "VTEE")]
    [IsoId("_fMd9AKH1EeuiuNcvKhXmNQ")]
    [Description(@"Virtual trusted execution environment	")]
    VirtualTrustedExecutionEnvironment,
    
}
