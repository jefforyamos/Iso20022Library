﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateType4Code.  ISO2002 ID# _ayZwpNp-Ed-ak6NoX_4Aeg_-1040840411.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwpNp-Ed-ak6NoX_4Aeg_-1040840411")]
[Description(@"Specifies a type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Open".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ayZwpdp-Ed-ak6NoX_4Aeg_-753628532")]
    [Description(@"??")]
    Open,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ayZwptp-Ed-ak6NoX_4Aeg_-739775519")]
    [Description(@"??")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DateType4CodeMetadataExtensions
{
    private static readonly DateType4CodeDropdownSource _dropdownSource = new DateType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDateType4CodeDropdownRow GetMetadata(this DateType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

