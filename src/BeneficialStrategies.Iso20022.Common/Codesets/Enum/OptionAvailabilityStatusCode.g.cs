﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionAvailabilityStatusCode.  ISO2002 ID# _aPYjINp-Ed-ak6NoX_4Aeg_2038667803.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the option availability.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPYjINp-Ed-ak6NoX_4Aeg_2038667803")]
[Description(@"Specifies the status of the option availability.")]
public enum OptionAvailabilityStatusCode
{
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as "INTV".
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_aPYjIdp-Ed-ak6NoX_4Aeg_-1403888943")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    Inactive,
    
    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_aPYjItp-Ed-ak6NoX_4Aeg_-1374336318")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    Cancelled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionAvailabilityStatusCodeMetadataExtensions
{
    private static readonly OptionAvailabilityStatusCodeDropdownSource _dropdownSource = new OptionAvailabilityStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionAvailabilityStatusCodeDropdownRow GetMetadata(this OptionAvailabilityStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


