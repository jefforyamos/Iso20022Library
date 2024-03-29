﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Validation1Code.  ISO2002 ID# _8982sMmKEeWAGphE2LvqeA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the validation of a signature used to sign the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8982sMmKEeWAGphE2LvqeA")]
[Description(@"Specifies the validation of a signature used to sign the file.")]
[DerivedFrom(typeof(ValidationCode))]
public enum Validation1Code
{
    /// <summary>
    /// Validation of the signature is successful.
    /// Encoded/decoded by serializers as &quot;OKAY&quot;.
    /// </summary>
    [EnumMember(Value = "OKAY")]
    [IsoId("_-T5V8smKEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature is successful.")]
    ValidationSuccessful = ValidationCode.ValidationSuccessful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Validation of the signature is unknown or not yet executed.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_-VFBscmKEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature is unknown or not yet executed.")]
    ValidationUnkonwn = ValidationCode.ValidationUnkonwn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Validation of the signature has failed.
    /// Encoded/decoded by serializers as &quot;NTOK&quot;.
    /// </summary>
    [EnumMember(Value = "NTOK")]
    [IsoId("_UqKgocnIEeWI4cSIO9foRA")]
    [Description(@"Validation of the signature has failed.")]
    ValidationFailed = ValidationCode.ValidationFailed, // same ordinal as derivation source for type conversions
    
}
