﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason61Code.  ISO2002 ID# _4BgVEDDEEeunENYTWutRtQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specify the reason why the market claim cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4BgVEDDEEeunENYTWutRtQ")]
[Description(@"Specify the reason why the market claim cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason61Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BGUkgTDFEeunENYTWutRtQ")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DjSWMTDFEeunENYTWutRtQ")]
    [Description(@"??")]
    InvalidReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_FaTiMTDFEeunENYTWutRtQ")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Go3AATDFEeunENYTWutRtQ")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Iw1ZITDFEeunENYTWutRtQ")]
    [Description(@"??")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeniedSinceAlreadySettled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ny8BETDFEeunENYTWutRtQ")]
    [Description(@"??")]
    DeniedSinceAlreadySettled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PiXXUTDFEeunENYTWutRtQ")]
    [Description(@"??")]
    RejectedSinceInProgress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason61CodeMetadataExtensions
{
    private static readonly RejectionReason61CodeDropdownSource _dropdownSource = new RejectionReason61CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason61CodeDropdownRow GetMetadata(this RejectionReason61Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


