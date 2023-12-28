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
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-d9yUdHCEeaokquJJ-K6uA")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-0GaYtHCEeaokquJJ-K6uA")]
    [Description(@"??")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyAccepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-1bQEdHCEeaokquJJ-K6uA")]
    [Description(@"??")]
    PartiallyAccepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-2rNQdHCEeaokquJJ-K6uA")]
    [Description(@"??")]
    Received,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-8aB0dHCEeaokquJJ-K6uA")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reminder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__UTkctHCEeaokquJJ-K6uA")]
    [Description(@"??")]
    Reminder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Warning".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__rYnstHCEeaokquJJ-K6uA")]
    [Description(@"??")]
    Warning,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncorrectFilename".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UanZQevBEealxoQGKU9EVQ")]
    [Description(@"??")]
    IncorrectFilename,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorruptedFile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UeMRsevBEealxoQGKU9EVQ")]
    [Description(@"??")]
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


