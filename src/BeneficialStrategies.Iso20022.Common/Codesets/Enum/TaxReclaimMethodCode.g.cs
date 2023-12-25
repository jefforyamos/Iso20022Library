﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxReclaimMethodCode.  ISO2002 ID# _Nff_g_M9Eei4qfiLgRIZBA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains Tax Reclaim options
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Nff_g_M9Eei4qfiLgRIZBA")]
[Description(@"Contains Tax Reclaim options")]
public enum TaxReclaimMethodCode
{
    /// <summary>
    /// Invoice printed but treated as supplemental because electronic copy is used for tax reclaim
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_Nff_hPM9Eei4qfiLgRIZBA")]
    [Description(@"Invoice printed but treated as supplemental because electronic copy is used for tax reclaim")]
    INPS,
    
    /// <summary>
    /// Printed invoice suppressed because electronic master version is used for tax reclaim
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_Nff_hfM9Eei4qfiLgRIZBA")]
    [Description(@"Printed invoice suppressed because electronic master version is used for tax reclaim")]
    INSU,
    
    /// <summary>
    /// Invoice printed and given to purchaser and then used for tax reclaim
    /// </summary>
    [EnumMember(Value = "INPP")]
    [IsoId("_fHw2sPM9Eei4qfiLgRIZBA")]
    [Description(@"Invoice printed and given to purchaser and then used for tax reclaim")]
    INPP,
    
    /// <summary>
    /// Other tax reclaim method not elsewhere specified
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_4yGRcPM-Eei4qfiLgRIZBA")]
    [Description(@"Other tax reclaim method not elsewhere specified")]
    OTHR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxReclaimMethodCodeMetadataExtensions
{
    private static readonly TaxReclaimMethodCodeDropdownSource _dropdownSource = new TaxReclaimMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxReclaimMethodCodeDropdownRow GetMetadata(this TaxReclaimMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


