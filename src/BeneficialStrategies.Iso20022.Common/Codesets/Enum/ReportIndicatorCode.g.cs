﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportIndicatorCode.  ISO2002 ID# _ZTCPpdp-Ed-ak6NoX_4Aeg_613407085.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the report, ie, standard or proprietary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTCPpdp-Ed-ak6NoX_4Aeg_613407085")]
[Description(@"Specifies the nature of the report, ie, standard or proprietary.")]
[Derivations(typeof(ReportIndicator1Code))]
public enum ReportIndicatorCode
{
    /// <summary>
    /// Requested report must contain information in the format of a statement.
    /// Encoded/decoded by serializers as "STND".
    /// </summary>
    [EnumMember(Value = "STND")]
    [IsoId("_ZTCPptp-Ed-ak6NoX_4Aeg_1052080555")]
    [Description(@"Requested report must contain information in the format of a statement.")]
    Standard,
    
    /// <summary>
    /// Requested report must contain information in a bilaterally agreed format.
    /// Encoded/decoded by serializers as "PRPR".
    /// </summary>
    [EnumMember(Value = "PRPR")]
    [IsoId("_ZTCPp9p-Ed-ak6NoX_4Aeg_1128730440")]
    [Description(@"Requested report must contain information in a bilaterally agreed format.")]
    Proprietary,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportIndicatorCodeMetadataExtensions
{
    private static readonly ReportIndicatorCodeDropdownSource _dropdownSource = new ReportIndicatorCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportIndicatorCodeDropdownRow GetMetadata(this ReportIndicatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


