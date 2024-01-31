﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationIndividualStatus2Code.  ISO2002 ID# _uylVsBylEeispO42NVVLrw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uylVsBylEeispO42NVVLrw")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum CancellationIndividualStatus2Code
{
    /// <summary>
    /// Payment is cancelled.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_835qkhylEeispO42NVVLrw")]
    [Description(@"Payment is cancelled.")]
    PaymentCancelled = PaymentStatusCode.PaymentCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is pending.
    /// Encoded/decoded by serializers as "PDCR".
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_-fhIohylEeispO42NVVLrw")]
    [Description(@"Cancellation request is pending.")]
    PendingCancellationRequest = PaymentStatusCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is rejected
    /// Encoded/decoded by serializers as "RJCR".
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_cSYZwYZ4EeiMm4lwapNmDA")]
    [Description(@"Cancellation request is rejected")]
    RejectedCancellationRequest = PaymentStatusCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationIndividualStatus2CodeMetadataExtensions
{
    private static readonly CancellationIndividualStatus2CodeDropdownSource _dropdownSource = new CancellationIndividualStatus2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationIndividualStatus2CodeDropdownRow GetMetadata(this CancellationIndividualStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


