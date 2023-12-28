﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Validation1Code.  ISO2002 ID# _8982sMmKEeWAGphE2LvqeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "ValidationSuccessful".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-T5V8smKEeWAGphE2LvqeA")]
    [Description(@"??")]
    ValidationSuccessful,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ValidationUnkonwn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-VFBscmKEeWAGphE2LvqeA")]
    [Description(@"??")]
    ValidationUnkonwn,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ValidationFailed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UqKgocnIEeWI4cSIO9foRA")]
    [Description(@"??")]
    ValidationFailed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Validation1CodeMetadataExtensions
{
    private static readonly Validation1CodeDropdownSource _dropdownSource = new Validation1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidation1CodeDropdownRow GetMetadata(this Validation1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


