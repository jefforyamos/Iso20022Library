﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationProcess2Code.  ISO2002 ID# _wZ0M8Qu2Eeq4I6UJxZQ2Qw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Configuration of the exchanges to perform the cancellation of a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wZ0M8Qu2Eeq4I6UJxZQ2Qw")]
[Description(@"Configuration of the exchanges to perform the cancellation of a payment transaction.")]
[DerivedFrom(typeof(CancellationProcessCode))]
public enum CancellationProcess2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Advice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wlXVoQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    Advice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotAllowed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wlXVowu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    NotAllowed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Request".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wlXVpQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    Request,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ApplicationLevel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EFxigQxtEeqdx6buGpCCQw")]
    [Description(@"??")]
    ApplicationLevel,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationProcess2CodeMetadataExtensions
{
    private static readonly CancellationProcess2CodeDropdownSource _dropdownSource = new CancellationProcess2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationProcess2CodeDropdownRow GetMetadata(this CancellationProcess2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


