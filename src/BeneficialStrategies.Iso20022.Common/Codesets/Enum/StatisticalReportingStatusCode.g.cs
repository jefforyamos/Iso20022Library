﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatisticalReportingStatusCode.  ISO2002 ID# _WxrMP9jEEeSdIOSPwTkydQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a single statistical reporting transaction or of a group of statistical reporting transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WxrMP9jEEeSdIOSPwTkydQ")]
[Description(@"Specifies the status of a single statistical reporting transaction or of a group of statistical reporting transactions.")]
public enum StatisticalReportingStatusCode
{
    /// <summary>
    /// Transaction or report has passed syntactical and semantical validation.
    /// Encoded/decoded by serializers as "ACTC".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_WxrMTNjEEeSdIOSPwTkydQ")]
    [Description(@"Transaction or report has passed syntactical and semantical validation.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Report has been received.
    /// Encoded/decoded by serializers as "RCVD".
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_WxrMRtjEEeSdIOSPwTkydQ")]
    [Description(@"Report has been received.")]
    Received,
    
    /// <summary>
    /// Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_WxrMSNjEEeSdIOSPwTkydQ")]
    [Description(@"Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.")]
    PartiallyAccepted,
    
    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_WxrMRdjEEeSdIOSPwTkydQ")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Processing of transaction or report is pending.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_WxrMQdjEEeSdIOSPwTkydQ")]
    [Description(@"Processing of transaction or report is pending.")]
    Pending,
    
    /// <summary>
    /// Transaction or report has been accepted.
    /// Encoded/decoded by serializers as "ACPT".
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_WxrMQNjEEeSdIOSPwTkydQ")]
    [Description(@"Transaction or report has been accepted.")]
    Accepted,
    
    /// <summary>
    /// Transaction has been accepted with warnings.
    /// Encoded/decoded by serializers as "WARN".
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_j11wUO2wEeS-SNPe_7uMwA")]
    [Description(@"Transaction has been accepted with warnings.")]
    Warning,
    
    /// <summary>
    /// Reminder of a non received report.
    /// Encoded/decoded by serializers as "RMDR".
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_s-hMEO2wEeS-SNPe_7uMwA")]
    [Description(@"Reminder of a non received report.")]
    Reminder,
    
    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as "CRPT".
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_PQjosO8AEeSo-uJuUW33Ew")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile,
    
    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as "INCF".
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_m-pOoe8AEeSo-uJuUW33Ew")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename,
    
    /// <summary>
    /// Transaction or report has been accepted, following a pending status.
    /// Encoded/decoded by serializers as "ACPD".
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_FI0VcLX6EeWOIMMXtF0SdQ")]
    [Description(@"Transaction or report has been accepted, following a pending status.")]
    AcceptedAfterPending,
    
    /// <summary>
    /// Transaction or report has been rejected, following a pending status.
    /// Encoded/decoded by serializers as "RJPD".
    /// </summary>
    [EnumMember(Value = "RJPD")]
    [IsoId("_J33egLX6EeWOIMMXtF0SdQ")]
    [Description(@"Transaction or report has been rejected, following a pending status.")]
    RejectedAfterPending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatisticalReportingStatusCodeMetadataExtensions
{
    private static readonly StatisticalReportingStatusCodeDropdownSource _dropdownSource = new StatisticalReportingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatisticalReportingStatusCodeDropdownRow GetMetadata(this StatisticalReportingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


