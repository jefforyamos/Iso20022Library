﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NamePrefixCode.  ISO2002 ID# _GP3GkIMmEeeBDNMiErKunw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the terms used to formally address a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GP3GkIMmEeeBDNMiErKunw")]
[Description(@"Specifies the terms used to formally address a person.")]
[Derivations(typeof(NamePrefix1Code),typeof(NamePrefix2Code))]
// External derivations that should be provided by the proper interface are: 
public enum NamePrefixCode
{
    /// <summary>
    /// Title of the person is Doctor or Dr.
    /// Encoded/decoded by serializers as "DOCT".
    /// </summary>
    [EnumMember(Value = "DOCT")]
    [IsoId("_aM_9hdp-Ed-ak6NoX_4Aeg_1978538845")]
    [Description(@"Title of the person is Doctor or Dr.")]
    Doctor,
    
    /// <summary>
    /// Title of the person is Mister or Mr.
    /// Encoded/decoded by serializers as "MIST".
    /// </summary>
    [EnumMember(Value = "MIST")]
    [IsoId("_aM_9htp-Ed-ak6NoX_4Aeg_2031181497")]
    [Description(@"Title of the person is Mister or Mr.")]
    Mister,
    
    /// <summary>
    /// Title of the person is Miss.
    /// Encoded/decoded by serializers as "MISS".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_aM_9h9p-Ed-ak6NoX_4Aeg_2045957026")]
    [Description(@"Title of the person is Miss.")]
    Miss,
    
    /// <summary>
    /// Title of the person is Madam.
    /// Encoded/decoded by serializers as "MADM".
    /// </summary>
    [EnumMember(Value = "MADM")]
    [IsoId("_aM_9iNp-Ed-ak6NoX_4Aeg_2050576025")]
    [Description(@"Title of the person is Madam.")]
    Madam,
    
    /// <summary>
    /// Title of the person is gender neutral (Mx).
    /// Encoded/decoded by serializers as "MIKS".
    /// </summary>
    [EnumMember(Value = "MIKS")]
    [IsoId("_dfH0MHRlEeiH1ZOt2UD8vQ")]
    [Description(@"Title of the person is gender neutral (Mx).")]
    GenderNeutral,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NamePrefixCodeMetadataExtensions
{
    private static readonly NamePrefixCodeDropdownSource _dropdownSource = new NamePrefixCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INamePrefixCodeDropdownRow GetMetadata(this NamePrefixCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


