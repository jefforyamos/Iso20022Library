﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ErrorSeverity1Code.  ISO2002 ID# _q_x78A3EEeWH49U6bkyMaA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the severity of the related error.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q_x78A3EEeWH49U6bkyMaA")]
[Description(@"Indicates the severity of the related error.")]
[DerivedFrom(typeof(ErrorSeverityCode))]
public enum ErrorSeverity1Code
{
    /// <summary>
    /// The error is considered fatal.
    /// Encoded/decoded by serializers as "FATL".
    /// </summary>
    [EnumMember(Value = "FATL")]
    [IsoId("_sXHiUQ3EEeWH49U6bkyMaA")]
    [Description(@"The error is considered fatal.")]
    Fatal = ErrorSeverityCode.Fatal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The error is considered transient.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_sdgeMw3EEeWH49U6bkyMaA")]
    [Description(@"The error is considered transient.")]
    Transient = ErrorSeverityCode.Transient, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ErrorSeverity1CodeMetadataExtensions
{
    private static readonly ErrorSeverity1CodeDropdownSource _dropdownSource = new ErrorSeverity1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IErrorSeverity1CodeDropdownRow GetMetadata(this ErrorSeverity1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


