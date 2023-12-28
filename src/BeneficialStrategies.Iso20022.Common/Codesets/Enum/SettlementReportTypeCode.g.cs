﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementReportTypeCode.  ISO2002 ID# _OiEAwFdJEeeIAMBcVOw01w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of settlement report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OiEAwFdJEeeIAMBcVOw01w")]
[Description(@"Type of settlement report.")]
public enum SettlementReportTypeCode
{
    /// <summary>
    /// Final settlement position.
    /// Encoded/decoded by serializers as "FIPO".
    /// </summary>
    [EnumMember(Value = "FIPO")]
    [IsoId("_cLDmAFdJEeeIAMBcVOw01w")]
    [Description(@"Final settlement position.")]
    FinalPosition,
    
    /// <summary>
    /// Interim settlement position.
    /// Encoded/decoded by serializers as "INPO".
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_jiREIFdJEeeIAMBcVOw01w")]
    [Description(@"Interim settlement position.")]
    InterimPosition,
    
    /// <summary>
    /// Other type of settlement report defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("__VWJgFdJEeeIAMBcVOw01w")]
    [Description(@"Other type of settlement report defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other settlement report defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_DqAcoFdKEeeIAMBcVOw01w")]
    [Description(@"Other settlement report defined at private level.")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementReportTypeCodeMetadataExtensions
{
    private static readonly SettlementReportTypeCodeDropdownSource _dropdownSource = new SettlementReportTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementReportTypeCodeDropdownRow GetMetadata(this SettlementReportTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

