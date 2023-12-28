﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportType2Code.  ISO2002 ID# _ZTVxptp-Ed-ak6NoX_4Aeg_-1196146765.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the baseline report is based on matching or pre-matching data sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTVxptp-Ed-ak6NoX_4Aeg_-1196146765")]
[Description(@"Specifies whether the baseline report is based on matching or pre-matching data sets.")]
[DerivedFrom(typeof(ReportTypeCode))]
public enum ReportType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Precalculated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZTVxp9p-Ed-ak6NoX_4Aeg_-1137964591")]
    [Description(@"??")]
    Precalculated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZTVxqNp-Ed-ak6NoX_4Aeg_-1137964548")]
    [Description(@"??")]
    Current,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportType2CodeMetadataExtensions
{
    private static readonly ReportType2CodeDropdownSource _dropdownSource = new ReportType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportType2CodeDropdownRow GetMetadata(this ReportType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

