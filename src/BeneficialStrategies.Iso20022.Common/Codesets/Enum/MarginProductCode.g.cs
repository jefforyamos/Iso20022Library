﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarginProductCode.  ISO2002 ID# _YZq-t9p-Ed-ak6NoX_4Aeg_1067655731.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying product of the margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZq-t9p-Ed-ak6NoX_4Aeg_1067655731")]
[Description(@"Specifies the underlying product of the margin.")]
public enum MarginProductCode
{
    /// <summary>
    /// Specifies that the margin is related to equities.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_YZq-uNp-Ed-ak6NoX_4Aeg_997889557")]
    [Description(@"Specifies that the margin is related to equities.")]
    EQUI,
    
    /// <summary>
    /// Specifies that the margin is related to fixed income.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_YZ0IoNp-Ed-ak6NoX_4Aeg_-1565139017")]
    [Description(@"Specifies that the margin is related to fixed income.")]
    FIXI,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MarginProductCodeMetadataExtensions
{
    private static readonly MarginProductCodeDropdownSource _dropdownSource = new MarginProductCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMarginProductCodeDropdownRow GetMetadata(this MarginProductCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


