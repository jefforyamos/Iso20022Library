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
    /// ??
    /// Encoded/decoded by serializers as "RejectedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXW319p-Ed-ak6NoX_4Aeg_349830132")]
    [Description(@"??")]
    RejectedCancellationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXgo0Np-Ed-ak6NoX_4Aeg_349830162")]
    [Description(@"??")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingCancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bXgo0dp-Ed-ak6NoX_4Aeg_349830163")]
    [Description(@"??")]
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

