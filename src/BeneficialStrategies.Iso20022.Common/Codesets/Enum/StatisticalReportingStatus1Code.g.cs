﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatisticalReportingStatus1Code.  ISO2002 ID# _8W46ANjEEeSdIOSPwTkydQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of statistical reporting transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8W46ANjEEeSdIOSPwTkydQ")]
[Description(@"Specifies the status of a group of statistical reporting transactions.")]
[DerivedFrom(typeof(StatisticalReportingStatusCode))]
public enum StatisticalReportingStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iNhH8djFEeSD0e0ybx5L5Q")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptedTechnicalValidation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iUXW0djFEeSD0e0ybx5L5Q")]
    [Description(@"??")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyAccepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iaw5wdjFEeSD0e0ybx5L5Q")]
    [Description(@"??")]
    PartiallyAccepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ijYqQdjFEeSD0e0ybx5L5Q")]
    [Description(@"??")]
    Pending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Received".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ipfSQdjFEeSD0e0ybx5L5Q")]
    [Description(@"??")]
    Received,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ixYC8djFEeSD0e0ybx5L5Q")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reminder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2_4jUe2wEeS-SNPe_7uMwA")]
    [Description(@"??")]
    Reminder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncorrectFilename".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c9R3Ye8AEeSo-uJuUW33Ew")]
    [Description(@"??")]
    IncorrectFilename,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorruptedFile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_urYQ0e8AEeSo-uJuUW33Ew")]
    [Description(@"??")]
    CorruptedFile,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatisticalReportingStatus1CodeMetadataExtensions
{
    private static readonly StatisticalReportingStatus1CodeDropdownSource _dropdownSource = new StatisticalReportingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatisticalReportingStatus1CodeDropdownRow GetMetadata(this StatisticalReportingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

