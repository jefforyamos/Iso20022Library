﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportIndicator1Code.  ISO2002 ID# _ZTCPotp-Ed-ak6NoX_4Aeg_1670165238.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the report, that is, standard or proprietary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTCPotp-Ed-ak6NoX_4Aeg_1670165238")]
[Description(@"Specifies the nature of the report, that is, standard or proprietary.")]
[DerivedFrom(typeof(ReportIndicatorCode))]
public enum ReportIndicator1Code
{
    /// <summary>
    /// Requested report must contain information in the format of a statement.
    /// Encoded/decoded by serializers as "Standard".
    /// </summary>
    [EnumMember(Value = "STND")]
    [IsoId("_ZTCPo9p-Ed-ak6NoX_4Aeg_1969382793")]
    [Description(@"Requested report must contain information in the format of a statement.")]
    Standard,
    
    /// <summary>
    /// Requested report must contain information in a bilaterally agreed format.
    /// Encoded/decoded by serializers as "Proprietary".
    /// </summary>
    [EnumMember(Value = "PRPR")]
    [IsoId("_ZTCPpNp-Ed-ak6NoX_4Aeg_2001706027")]
    [Description(@"Requested report must contain information in a bilaterally agreed format.")]
    Proprietary,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportIndicator1CodeMetadataExtensions
{
    private static readonly ReportIndicator1CodeDropdownSource _dropdownSource = new ReportIndicator1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportIndicator1CodeDropdownRow GetMetadata(this ReportIndicator1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


