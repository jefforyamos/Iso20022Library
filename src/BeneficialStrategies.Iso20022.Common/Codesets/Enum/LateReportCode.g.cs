﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LateReportCode.  ISO2002 ID# _ad114Np-Ed-ak6NoX_4Aeg_-1931554281.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a transaction report is late.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad114Np-Ed-ak6NoX_4Aeg_-1931554281")]
[Description(@"Specifies whether a transaction report is late.")]
public enum LateReportCode
{
    /// <summary>
    /// The confirmation is late.
    /// </summary>
    [EnumMember(Value = "LAT1")]
    [IsoId("_ad114dp-Ed-ak6NoX_4Aeg_-1204743163")]
    [Description(@"The confirmation is late.")]
    LAT1,
    
    /// <summary>
    /// The confirmation is late because the trade was executed as a number of partials.
    /// </summary>
    [EnumMember(Value = "LAT2")]
    [IsoId("_ad114tp-Ed-ak6NoX_4Aeg_-1188118789")]
    [Description(@"The confirmation is late because the trade was executed as a number of partials.")]
    LAT2,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LateReportCodeMetadataExtensions
{
    private static readonly LateReportCodeDropdownSource _dropdownSource = new LateReportCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILateReportCodeDropdownRow GetMetadata(this LateReportCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


