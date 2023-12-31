﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateType3Code.  ISO2002 ID# _ayZwotp-Ed-ak6NoX_4Aeg_-1375472823.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwotp-Ed-ak6NoX_4Aeg_-1375472823")]
[Description(@"Specifies a type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType3Code
{
    /// <summary>
    /// Partial trades have occurred over a period of two or more days.
    /// Encoded/decoded by serializers as "Various".
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_ayZwo9p-Ed-ak6NoX_4Aeg_-1348690126")]
    [Description(@"Partial trades have occurred over a period of two or more days.")]
    Various,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DateType3CodeMetadataExtensions
{
    private static readonly DateType3CodeDropdownSource _dropdownSource = new DateType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDateType3CodeDropdownRow GetMetadata(this DateType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


