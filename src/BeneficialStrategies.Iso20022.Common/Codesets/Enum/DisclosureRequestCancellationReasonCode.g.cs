﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisclosureRequestCancellationReasonCode.  ISO2002 ID# _IZJRIEV4EemRx7jyevcLwg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the cancellation of the disclosure request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IZJRIEV4EemRx7jyevcLwg")]
[Description(@"Specifies the reason for the cancellation of the disclosure request.")]
public enum DisclosureRequestCancellationReasonCode
{
    /// <summary>
    /// The cancellation of the disclosure request is due to a processsing error.
    /// Encoded/decoded by serializers as "PROC".
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_ZKixwEV4EemRx7jyevcLwg")]
    [Description(@"The cancellation of the disclosure request is due to a processsing error.")]
    Processing,
    
    /// <summary>
    /// The cancellation of the discolure request is due to the withdrawal of the request  by the issuer.
    /// Encoded/decoded by serializers as "WITH".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_30joAEV4EemRx7jyevcLwg")]
    [Description(@"The cancellation of the discolure request is due to the withdrawal of the request  by the issuer.")]
    Withdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisclosureRequestCancellationReasonCodeMetadataExtensions
{
    private static readonly DisclosureRequestCancellationReasonCodeDropdownSource _dropdownSource = new DisclosureRequestCancellationReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisclosureRequestCancellationReasonCodeDropdownRow GetMetadata(this DisclosureRequestCancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

