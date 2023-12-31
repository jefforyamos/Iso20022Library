﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationCode.  ISO2002 ID# _tUnxYMmKEeWAGphE2LvqeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the validation of a signature used to sign the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tUnxYMmKEeWAGphE2LvqeA")]
[Description(@"Specifies the validation of a signature used to sign the file.")]
[Derivations(typeof(Validation1Code),typeof(Validation2Code))]
// External derivations that should be provided by the proper interface are: 
public enum ValidationCode
{
    /// <summary>
    /// Validation of the signature is successful.
    /// Encoded/decoded by serializers as "OKAY".
    /// </summary>
    [EnumMember(Value = "OKAY")]
    [IsoId("_xJi0gMmKEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature is successful.")]
    ValidationSuccessful,
    
    /// <summary>
    /// Validation of the signature is unknown or not yet executed.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_zWdYAMmKEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature is unknown or not yet executed.")]
    ValidationUnkonwn,
    
    /// <summary>
    /// Validation of the signature has failed.
    /// Encoded/decoded by serializers as "NTOK".
    /// </summary>
    [EnumMember(Value = "NTOK")]
    [IsoId("_vPTVYMmKEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature has failed.")]
    ValidationFailed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationCodeMetadataExtensions
{
    private static readonly ValidationCodeDropdownSource _dropdownSource = new ValidationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationCodeDropdownRow GetMetadata(this ValidationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


