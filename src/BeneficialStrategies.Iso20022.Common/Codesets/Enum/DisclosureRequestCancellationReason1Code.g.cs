﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisclosureRequestCancellationReason1Code.  ISO2002 ID# _MbblYEV5EemRx7jyevcLwg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the cancellation of the disclosure request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MbblYEV5EemRx7jyevcLwg")]
[Description(@"Specifies the reason for the cancellation of the disclosure request.")]
[DerivedFrom(typeof(DisclosureRequestCancellationReasonCode))]
public enum DisclosureRequestCancellationReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Processing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uyAM8UV5EemRx7jyevcLwg")]
    [Description(@"??")]
    Processing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Withdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_u4Zv4UV5EemRx7jyevcLwg")]
    [Description(@"??")]
    Withdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisclosureRequestCancellationReason1CodeMetadataExtensions
{
    private static readonly DisclosureRequestCancellationReason1CodeDropdownSource _dropdownSource = new DisclosureRequestCancellationReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisclosureRequestCancellationReason1CodeDropdownRow GetMetadata(this DisclosureRequestCancellationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

