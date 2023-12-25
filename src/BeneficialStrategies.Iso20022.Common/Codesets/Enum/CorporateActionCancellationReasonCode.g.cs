﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionCancellationReasonCode.  ISO2002 ID# _bCpMFtp-Ed-ak6NoX_4Aeg_-484210840.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies reasons for cancellation of a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCpMFtp-Ed-ak6NoX_4Aeg_-484210840")]
[Description(@"Specifies reasons for cancellation of a corporate action event.")]
public enum CorporateActionCancellationReasonCode
{
    /// <summary>
    /// Cancellation due to a processing error.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_bCpMF9p-Ed-ak6NoX_4Aeg_401443465")]
    [Description(@"Cancellation due to a processing error.")]
    PROC,
    
    /// <summary>
    /// Cancellation due to the corporate action event being cancelled by the issuer.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bCpMGNp-Ed-ak6NoX_4Aeg_779163570")]
    [Description(@"Cancellation due to the corporate action event being cancelled by the issuer.")]
    WITH,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionCancellationReasonCodeMetadataExtensions
{
    private static readonly CorporateActionCancellationReasonCodeDropdownSource _dropdownSource = new CorporateActionCancellationReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionCancellationReasonCodeDropdownRow GetMetadata(this CorporateActionCancellationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


