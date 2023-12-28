﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeniedReason2Code.  ISO2002 ID# _az5ledp-Ed-ak6NoX_4Aeg_363272961.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_az5ledp-Ed-ak6NoX_4Aeg_363272961")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(DeniedReasonCode))]
public enum DeniedReason2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvYNp-Ed-ak6NoX_4Aeg_363272993")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CallDeniedSinceAlreadyApplied".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvYdp-Ed-ak6NoX_4Aeg_363273023")]
    [Description(@"??")]
    CallDeniedSinceAlreadyApplied,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvYtp-Ed-ak6NoX_4Aeg_364193017")]
    [Description(@"??")]
    DeniedSinceAlreadyCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceNotAllowed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvY9p-Ed-ak6NoX_4Aeg_364193018")]
    [Description(@"??")]
    DeniedSinceNotAllowed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvZNp-Ed-ak6NoX_4Aeg_364193048")]
    [Description(@"??")]
    DeniedSinceInProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceRepoEnded".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvZdp-Ed-ak6NoX_4Aeg_364193078")]
    [Description(@"??")]
    DeniedSinceRepoEnded,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceAlreadySettled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvZtp-Ed-ak6NoX_4Aeg_364193079")]
    [Description(@"??")]
    DeniedSinceAlreadySettled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0CvZ9p-Ed-ak6NoX_4Aeg_364193140")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeniedReason2CodeMetadataExtensions
{
    private static readonly DeniedReason2CodeDropdownSource _dropdownSource = new DeniedReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeniedReason2CodeDropdownRow GetMetadata(this DeniedReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

