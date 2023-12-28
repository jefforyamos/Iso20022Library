﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateMode1Code.  ISO2002 ID# _f_Z6kFuSEeSmO6RkXg92Lg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_f_Z6kFuSEeSmO6RkXg92Lg")]
[Description(@"Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.")]
[DerivedFrom(typeof(DateModeCode))]
public enum DateMode1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BODY".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jKunEVuSEeSmO6RkXg92Lg")]
    [Description(@"??")]
    BODY,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EODY".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jT6_UVuSEeSmO6RkXg92Lg")]
    [Description(@"??")]
    EODY,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DateMode1CodeMetadataExtensions
{
    private static readonly DateMode1CodeDropdownSource _dropdownSource = new DateMode1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDateMode1CodeDropdownRow GetMetadata(this DateMode1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

