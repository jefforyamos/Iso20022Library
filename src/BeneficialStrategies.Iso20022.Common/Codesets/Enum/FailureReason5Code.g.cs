﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailureReason5Code.  ISO2002 ID# _zsPEIIr-EeSvuOJS0mmL0g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Incident occurring on a device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zsPEIIr-EeSvuOJS0mmL0g")]
[Description(@"Incident occurring on a device.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason5Code
{
    /// <summary>
    /// General security error.
    /// Encoded/decoded by serializers as "SECR".
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_4Y2kQYr-EeSvuOJS0mmL0g")]
    [Description(@"General security error.")]
    Security = FailureReasonCode.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hardware error on the device.
    /// Encoded/decoded by serializers as "HRDW".
    /// </summary>
    [EnumMember(Value = "HRDW")]
    [IsoId("_-lfssYr-EeSvuOJS0mmL0g")]
    [Description(@"Hardware error on the device.")]
    Hardware = FailureReasonCode.Hardware, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FailureReason5CodeMetadataExtensions
{
    private static readonly FailureReason5CodeDropdownSource _dropdownSource = new FailureReason5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFailureReason5CodeDropdownRow GetMetadata(this FailureReason5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


