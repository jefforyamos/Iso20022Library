﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationIndividualStatus1Code.  ISO2002 ID# _bXW31tp-Ed-ak6NoX_4Aeg_349830100.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXW31tp-Ed-ak6NoX_4Aeg_349830100")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum CancellationIndividualStatus1Code
{
    /// <summary>
    /// Cancellation request is rejected
    /// Encoded/decoded by serializers as "RejectedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_bXW319p-Ed-ak6NoX_4Aeg_349830132")]
    [Description(@"Cancellation request is rejected")]
    RejectedCancellationRequest,
    
    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as "AcceptedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_bXgo0Np-Ed-ak6NoX_4Aeg_349830162")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// Cancellation request is pending.
    /// Encoded/decoded by serializers as "PendingCancellationRequest".
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_bXgo0dp-Ed-ak6NoX_4Aeg_349830163")]
    [Description(@"Cancellation request is pending.")]
    PendingCancellationRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationIndividualStatus1CodeMetadataExtensions
{
    private static readonly CancellationIndividualStatus1CodeDropdownSource _dropdownSource = new CancellationIndividualStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationIndividualStatus1CodeDropdownRow GetMetadata(this CancellationIndividualStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


