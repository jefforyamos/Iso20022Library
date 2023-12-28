﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdministrativeType1Code.  ISO2002 ID# _3BW3kDNKEeylu6lH-gut-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that specifies the administrative type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3BW3kDNKEeylu6lH-gut-A")]
[Description(@"Code that specifies the administrative type.")]
[DerivedFrom(typeof(AdministrativeTypeCode))]
public enum AdministrativeType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6oeIMTNKEeylu6lH-gut-A")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6tdV4TNKEeylu6lH-gut-A")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TextMessage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6zMxgTNKEeylu6lH-gut-A")]
    [Description(@"??")]
    TextMessage,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdministrativeType1CodeMetadataExtensions
{
    private static readonly AdministrativeType1CodeDropdownSource _dropdownSource = new AdministrativeType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdministrativeType1CodeDropdownRow GetMetadata(this AdministrativeType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

