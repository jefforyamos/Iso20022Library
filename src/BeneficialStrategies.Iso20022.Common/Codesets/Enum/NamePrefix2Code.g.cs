﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NamePrefix2Code.  ISO2002 ID# _ODhzcHRmEeiH1ZOt2UD8vQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the terms used to formally address a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ODhzcHRmEeiH1ZOt2UD8vQ")]
[Description(@"Specifies the terms used to formally address a person.")]
[DerivedFrom(typeof(NamePrefixCode))]
public enum NamePrefix2Code
{
    /// <summary>
    /// Title of the person is Doctor or Dr.
    /// Encoded/decoded by serializers as "Doctor".
    /// </summary>
    [EnumMember(Value = "DOCT")]
    [IsoId("_SmTbEXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Doctor or Dr.")]
    Doctor,
    
    /// <summary>
    /// Title of the person is Madam.
    /// Encoded/decoded by serializers as "Madam".
    /// </summary>
    [EnumMember(Value = "MADM")]
    [IsoId("_SseUgXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Madam.")]
    Madam,
    
    /// <summary>
    /// Title of the person is Miss.
    /// Encoded/decoded by serializers as "Miss".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_SzqhoXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Miss.")]
    Miss,
    
    /// <summary>
    /// Title of the person is Mister or Mr.
    /// Encoded/decoded by serializers as "Mister".
    /// </summary>
    [EnumMember(Value = "MIST")]
    [IsoId("_S6p6cXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is Mister or Mr.")]
    Mister,
    
    /// <summary>
    /// Title of the person is gender neutral (Mx).
    /// Encoded/decoded by serializers as "GenderNeutral".
    /// </summary>
    [EnumMember(Value = "MIKS")]
    [IsoId("_TCckgXRmEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is gender neutral (Mx).")]
    GenderNeutral,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NamePrefix2CodeMetadataExtensions
{
    private static readonly NamePrefix2CodeDropdownSource _dropdownSource = new NamePrefix2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INamePrefix2CodeDropdownRow GetMetadata(this NamePrefix2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


