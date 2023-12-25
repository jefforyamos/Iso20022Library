﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QueryTypeCode.  ISO2002 ID# _ZXza4dp-Ed-ak6NoX_4Aeg_1663250443.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifyies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXza4dp-Ed-ak6NoX_4Aeg_1663250443")]
[Description(@"Specifyies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned.")]
public enum QueryTypeCode
{
    /// <summary>
    /// Specifies that the query requests that all matching items be returned.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_ZXza4tp-Ed-ak6NoX_4Aeg_1663250445")]
    [Description(@"Specifies that the query requests that all matching items be returned.")]
    ALLL,
    
    /// <summary>
    /// Specifies that the query requests that only new matching items since the last similar query be returned.
    /// </summary>
    [EnumMember(Value = "CHNG")]
    [IsoId("_ZXza49p-Ed-ak6NoX_4Aeg_1663250454")]
    [Description(@"Specifies that the query requests that only new matching items since the last similar query be returned.")]
    CHNG,
    
    /// <summary>
    /// Specifies that the query requests that only items that have changed since the last query be returned.
    /// </summary>
    [EnumMember(Value = "MODF")]
    [IsoId("_ZXza5Np-Ed-ak6NoX_4Aeg_2022498795")]
    [Description(@"Specifies that the query requests that only items that have changed since the last query be returned.")]
    MODF,
    
    /// <summary>
    /// Specifies that the query requests that items that have been deleted since the last query be returned.
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_ZX9L4Np-Ed-ak6NoX_4Aeg_2062212062")]
    [Description(@"Specifies that the query requests that items that have been deleted since the last query be returned.")]
    DELD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QueryTypeCodeMetadataExtensions
{
    private static readonly QueryTypeCodeDropdownSource _dropdownSource = new QueryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQueryTypeCodeDropdownRow GetMetadata(this QueryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


