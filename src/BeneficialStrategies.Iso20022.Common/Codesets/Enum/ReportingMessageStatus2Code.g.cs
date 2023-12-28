﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportingMessageStatus2Code.  ISO2002 ID# _WlAyQT5-Ee2Z1_pdMHu4SA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a whole message processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WlAyQT5-Ee2Z1_pdMHu4SA")]
[Description(@"Specifies the status of a whole message processing.")]
[DerivedFrom(typeof(MessageStatusCode))]
public enum ReportingMessageStatus2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Wl48AT5-Ee2Z1_pdMHu4SA")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Wl48CT5-Ee2Z1_pdMHu4SA")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncorrectFilename".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Wl48Dz5-Ee2Z1_pdMHu4SA")]
    [Description(@"??")]
    IncorrectFilename,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorruptedFile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Wl48ET5-Ee2Z1_pdMHu4SA")]
    [Description(@"??")]
    CorruptedFile,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotAuthorised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zlZYQT5-Ee2Z1_pdMHu4SA")]
    [Description(@"??")]
    NotAuthorised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportingMessageStatus2CodeMetadataExtensions
{
    private static readonly ReportingMessageStatus2CodeDropdownSource _dropdownSource = new ReportingMessageStatus2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportingMessageStatus2CodeDropdownRow GetMetadata(this ReportingMessageStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

