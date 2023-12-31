﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason11Code.  ISO2002 ID# _ZgdAltp-Ed-ak6NoX_4Aeg_1782111527.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a rejection of the notification cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZgdAltp-Ed-ak6NoX_4Aeg_1782111527")]
[Description(@"Specifies the reason of a rejection of the notification cancellation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason11Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as "FailedValidation".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZgdAl9p-Ed-ak6NoX_4Aeg_-698385107")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation,
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_ZgdAmNp-Ed-ak6NoX_4Aeg_-698385076")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_ZgdAmdp-Ed-ak6NoX_4Aeg_-698385045")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as "InvalidCAIdentification".
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_ZgmKgNp-Ed-ak6NoX_4Aeg_-698385015")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason11CodeMetadataExtensions
{
    private static readonly RejectionReason11CodeDropdownSource _dropdownSource = new RejectionReason11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason11CodeDropdownRow GetMetadata(this RejectionReason11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


