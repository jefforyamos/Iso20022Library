﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxReportingStatus1Code.  ISO2002 ID# _rHMhkWueEeaRcazd7EYKFQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of tax reporting transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rHMhkWueEeaRcazd7EYKFQ")]
[Description(@"Specifies the status of a group of tax reporting transactions.")]
[DerivedFrom(typeof(StatisticalReportingStatusCode))]
public enum TaxReportingStatus1Code
{
    /// <summary>
    /// Transaction or report has been accepted.
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_rP-DEWueEeaRcazd7EYKFQ")]
    [Description(@"Transaction or report has been accepted.")]
    Accepted,
    
    /// <summary>
    /// Report has been received.
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_rP-DGWueEeaRcazd7EYKFQ")]
    [Description(@"Report has been received.")]
    Received,
    
    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_rP-DG2ueEeaRcazd7EYKFQ")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected,
    
    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as "IncorrectFilename".
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_rP-DH2ueEeaRcazd7EYKFQ")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename,
    
    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as "CorruptedFile".
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_rP-DIWueEeaRcazd7EYKFQ")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile,
    
    /// <summary>
    /// Transaction has been accepted with warnings.
    /// Encoded/decoded by serializers as "Warning".
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_aOAhcWufEeaRcazd7EYKFQ")]
    [Description(@"Transaction has been accepted with warnings.")]
    Warning,
    
    /// <summary>
    /// Transaction or report has passed syntactical and semantical validation.
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_g3zf8WufEeaRcazd7EYKFQ")]
    [Description(@"Transaction or report has passed syntactical and semantical validation.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.
    /// Encoded/decoded by serializers as "PartiallyAccepted".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_kACcMWufEeaRcazd7EYKFQ")]
    [Description(@"Report has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.")]
    PartiallyAccepted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxReportingStatus1CodeMetadataExtensions
{
    private static readonly TaxReportingStatus1CodeDropdownSource _dropdownSource = new TaxReportingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxReportingStatus1CodeDropdownRow GetMetadata(this TaxReportingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


