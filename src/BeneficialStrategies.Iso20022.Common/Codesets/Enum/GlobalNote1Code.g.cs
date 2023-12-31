﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GlobalNote1Code.  ISO2002 ID# _hbcAo2liEeGaMcKyqKNRfQ_1398344380.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbcAo2liEeGaMcKyqKNRfQ_1398344380")]
[Description(@"Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).")]
[DerivedFrom(typeof(GlobalNoteCode))]
public enum GlobalNote1Code
{
    /// <summary>
    /// Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).
    /// Encoded/decoded by serializers as "NewGlobalNote".
    /// </summary>
    [EnumMember(Value = "NGNO")]
    [IsoId("_hbcApGliEeGaMcKyqKNRfQ_526655547")]
    [Description(@"Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).")]
    NewGlobalNote,
    
    /// <summary>
    /// Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).
    /// Encoded/decoded by serializers as "ClassicalGlobalNote".
    /// </summary>
    [EnumMember(Value = "CGNO")]
    [IsoId("_hbcApWliEeGaMcKyqKNRfQ_-108376299")]
    [Description(@"Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).")]
    ClassicalGlobalNote,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GlobalNote1CodeMetadataExtensions
{
    private static readonly GlobalNote1CodeDropdownSource _dropdownSource = new GlobalNote1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGlobalNote1CodeDropdownRow GetMetadata(this GlobalNote1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


