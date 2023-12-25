﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GlobalNoteCode.  ISO2002 ID# _hbcAoGliEeGaMcKyqKNRfQ_-953519462.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbcAoGliEeGaMcKyqKNRfQ_-953519462")]
[Description(@"Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).")]
public enum GlobalNoteCode
{
    /// <summary>
    /// Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).
    /// </summary>
    [EnumMember(Value = "NGNO")]
    [IsoId("_hbcAoWliEeGaMcKyqKNRfQ_1154534279")]
    [Description(@"Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).")]
    NGNO,
    
    /// <summary>
    /// Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).
    /// </summary>
    [EnumMember(Value = "CGNO")]
    [IsoId("_hbcAomliEeGaMcKyqKNRfQ_1453098033")]
    [Description(@"Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).")]
    CGNO,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GlobalNoteCodeMetadataExtensions
{
    private static readonly GlobalNoteCodeDropdownSource _dropdownSource = new GlobalNoteCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGlobalNoteCodeDropdownRow GetMetadata(this GlobalNoteCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


