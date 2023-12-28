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
    /// ??
    /// Encoded/decoded by serializers as "FailedValidation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZgdAl9p-Ed-ak6NoX_4Aeg_-698385107")]
    [Description(@"??")]
    FailedValidation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZgdAmNp-Ed-ak6NoX_4Aeg_-698385076")]
    [Description(@"??")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZgdAmdp-Ed-ak6NoX_4Aeg_-698385045")]
    [Description(@"??")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidCAIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZgmKgNp-Ed-ak6NoX_4Aeg_-698385015")]
    [Description(@"??")]
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


