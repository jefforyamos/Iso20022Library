﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateType5Code.  ISO2002 ID# _ayZwp9p-Ed-ak6NoX_4Aeg_609768006.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwp9p-Ed-ak6NoX_4Aeg_609768006")]
[Description(@"Specifies a type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Open".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ayjhoNp-Ed-ak6NoX_4Aeg_957934914")]
    [Description(@"??")]
    Open,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DateType5CodeMetadataExtensions
{
    private static readonly DateType5CodeDropdownSource _dropdownSource = new DateType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDateType5CodeDropdownRow GetMetadata(this DateType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

