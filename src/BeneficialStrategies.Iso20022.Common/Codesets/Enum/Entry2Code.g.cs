﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Entry2Code.  ISO2002 ID# _ahQ9VNp-Ed-ak6NoX_4Aeg_-245723672.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of an entry in a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahQ9VNp-Ed-ak6NoX_4Aeg_-245723672")]
[Description(@"Specifies the type of an entry in a report.")]
[DerivedFrom(typeof(EntryCode))]
public enum Entry2Code
{
    /// <summary>
    /// Trial pay-in schedule.
    /// Encoded/decoded by serializers as "Trial".
    /// </summary>
    [EnumMember(Value = "TRIA")]
    [IsoId("_ahQ9Vdp-Ed-ak6NoX_4Aeg_-218020347")]
    [Description(@"Trial pay-in schedule.")]
    Trial,
    
    /// <summary>
    /// Official pay-in schedule.
    /// Encoded/decoded by serializers as "Official".
    /// </summary>
    [EnumMember(Value = "OFFI")]
    [IsoId("_ahQ9Vtp-Ed-ak6NoX_4Aeg_-214324853")]
    [Description(@"Official pay-in schedule.")]
    Official,
    
    /// <summary>
    /// Pay-in schedule on request.
    /// Encoded/decoded by serializers as "Requested".
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_ahQ9V9p-Ed-ak6NoX_4Aeg_-203241624")]
    [Description(@"Pay-in schedule on request.")]
    Requested,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Entry2CodeMetadataExtensions
{
    private static readonly Entry2CodeDropdownSource _dropdownSource = new Entry2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEntry2CodeDropdownRow GetMetadata(this Entry2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


