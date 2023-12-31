﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportingMessageStatus1Code.  ISO2002 ID# _1YwhUNHCEeaokquJJ-K6uA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a whole message processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1YwhUNHCEeaokquJJ-K6uA")]
[Description(@"Specifies the status of a whole message processing.")]
[DerivedFrom(typeof(MessageStatusCode))]
public enum ReportingMessageStatus1Code
{
    /// <summary>
    /// Whole message has been accepted.
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_-d9yUdHCEeaokquJJ-K6uA")]
    [Description(@"Whole message has been accepted.")]
    Accepted,
    
    /// <summary>
    /// Message has passed syntactical validation but further validations have not been completed yet.
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_-0GaYtHCEeaokquJJ-K6uA")]
    [Description(@"Message has passed syntactical validation but further validations have not been completed yet.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Message has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.
    /// Encoded/decoded by serializers as "PartiallyAccepted".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_-1bQEdHCEeaokquJJ-K6uA")]
    [Description(@"Message has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.")]
    PartiallyAccepted,
    
    /// <summary>
    /// Message has been received but not processed yet.
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_-2rNQdHCEeaokquJJ-K6uA")]
    [Description(@"Message has been received but not processed yet.")]
    Received,
    
    /// <summary>
    /// Message has been rejected.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_-8aB0dHCEeaokquJJ-K6uA")]
    [Description(@"Message has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Reminder of a non received message.
    /// Encoded/decoded by serializers as "Reminder".
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("__UTkctHCEeaokquJJ-K6uA")]
    [Description(@"Reminder of a non received message.")]
    Reminder,
    
    /// <summary>
    /// Message has been accepted with warnings.
    /// Encoded/decoded by serializers as "Warning".
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("__rYnstHCEeaokquJJ-K6uA")]
    [Description(@"Message has been accepted with warnings.")]
    Warning,
    
    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as "IncorrectFilename".
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_UanZQevBEealxoQGKU9EVQ")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename,
    
    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as "CorruptedFile".
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_UeMRsevBEealxoQGKU9EVQ")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportingMessageStatus1CodeMetadataExtensions
{
    private static readonly ReportingMessageStatus1CodeDropdownSource _dropdownSource = new ReportingMessageStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportingMessageStatus1CodeDropdownRow GetMetadata(this ReportingMessageStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


