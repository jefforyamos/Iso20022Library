﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementReportType1Code.  ISO2002 ID# _RTGIgFdKEeeIAMBcVOw01w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of settlement report
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RTGIgFdKEeeIAMBcVOw01w")]
[Description(@"Type of settlement report")]
[DerivedFrom(typeof(SettlementReportTypeCode))]
public enum SettlementReportType1Code
{
    /// <summary>
    /// Final settlement position.
    /// Encoded/decoded by serializers as "FIPO".
    /// </summary>
    [EnumMember(Value = "FIPO")]
    [IsoId("_UfqLIVdKEeeIAMBcVOw01w")]
    [Description(@"Final settlement position.")]
    FinalPosition = SettlementReportTypeCode.FinalPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of settlement report defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_U01J4VdKEeeIAMBcVOw01w")]
    [Description(@"Other type of settlement report defined at national level.")]
    OtherNational = SettlementReportTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other settlement report defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_U_OcAVdKEeeIAMBcVOw01w")]
    [Description(@"Other settlement report defined at private level.")]
    OtherPrivate = SettlementReportTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interim settlement position.
    /// Encoded/decoded by serializers as "INPO".
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_VY-YwVdKEeeIAMBcVOw01w")]
    [Description(@"Interim settlement position.")]
    InterimPosition = SettlementReportTypeCode.InterimPosition, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementReportType1CodeMetadataExtensions
{
    private static readonly SettlementReportType1CodeDropdownSource _dropdownSource = new SettlementReportType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementReportType1CodeDropdownRow GetMetadata(this SettlementReportType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


