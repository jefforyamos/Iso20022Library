﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateBasisCode.  ISO2002 ID# _ro2ZMc5IEeSc85GUbgBycw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the rate basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ro2ZMc5IEeSc85GUbgBycw")]
[Description(@"Specifies the rate basis.")]
public enum RateBasisCode
{
    /// <summary>
    /// Rate is reported in years.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_ro3AHc5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in years.")]
    Years,
    
    /// <summary>
    /// Rate is reported in months.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ro3AFs5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in months.")]
    Months,
    
    /// <summary>
    /// Rate is reported in weeks.
    /// Encoded/decoded by serializers as "WEEK".
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_ro2ZNs5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in weeks.")]
    Weeks,
    
    /// <summary>
    /// Rate is reported in days.
    /// Encoded/decoded by serializers as "DAYS".
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_ro2ZMs5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in days.")]
    Days,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateBasisCodeMetadataExtensions
{
    private static readonly RateBasisCodeDropdownSource _dropdownSource = new RateBasisCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateBasisCodeDropdownRow GetMetadata(this RateBasisCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


