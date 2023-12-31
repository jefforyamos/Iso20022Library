﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionProcessedStatusCode.  ISO2002 ID# _bR2Fs9p-Ed-ak6NoX_4Aeg_-1178553458.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of a corporate action transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bR2Fs9p-Ed-ak6NoX_4Aeg_-1178553458")]
[Description(@"Specifies the processing status of a corporate action transaction.")]
[Derivations(typeof(ProcessedStatus2Code),typeof(ProcessedStatus1Code),typeof(ProcessedStatus3Code),typeof(ProcessedStatus5Code),typeof(ProcessedStatus4Code),typeof(ProcessedStatus6Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionProcessedStatusCode
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_bR2FtNp-Ed-ak6NoX_4Aeg_-720484994")]
    [Description(@"The instruction/request has been received.")]
    Received,
    
    /// <summary>
    /// The request is accepted.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bR2Ftdp-Ed-ak6NoX_4Aeg_-720484993")]
    [Description(@"The request is accepted.")]
    Accepted,
    
    /// <summary>
    /// The processing of the request is pending.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bR2Fttp-Ed-ak6NoX_4Aeg_-720484964")]
    [Description(@"The processing of the request is pending.")]
    Pending,
    
    /// <summary>
    /// The request has been completed.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bR2Ft9p-Ed-ak6NoX_4Aeg_-257800026")]
    [Description(@"The request has been completed.")]
    Completed,
    
    /// <summary>
    /// Awaiting the deactivation date.
    /// Encoded/decoded by serializers as "DEAC".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_bR2FuNp-Ed-ak6NoX_4Aeg_638012647")]
    [Description(@"Awaiting the deactivation date.")]
    WaitingDeactivationDate,
    
    /// <summary>
    /// The advice has been sent to the market.
    /// Encoded/decoded by serializers as "SENT".
    /// </summary>
    [EnumMember(Value = "SENT")]
    [IsoId("_bR_2sNp-Ed-ak6NoX_4Aeg_2107675327")]
    [Description(@"The advice has been sent to the market.")]
    SentToMarket,
    
    /// <summary>
    /// The announcement has been accepted but another source has provided different information.
    /// Encoded/decoded by serializers as "WARN".
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_bR_2sdp-Ed-ak6NoX_4Aeg_-2058923992")]
    [Description(@"The announcement has been accepted but another source has provided different information.")]
    AcceptedWithWarning,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionProcessedStatusCodeMetadataExtensions
{
    private static readonly CorporateActionProcessedStatusCodeDropdownSource _dropdownSource = new CorporateActionProcessedStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionProcessedStatusCodeDropdownRow GetMetadata(this CorporateActionProcessedStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


