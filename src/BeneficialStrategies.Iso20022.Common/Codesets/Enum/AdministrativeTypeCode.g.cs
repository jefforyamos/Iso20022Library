﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdministrativeTypeCode.  ISO2002 ID# _H-bSIDNKEeylu6lH-gut-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that identifies an administrative type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H-bSIDNKEeylu6lH-gut-A")]
[Description(@"Code that identifies an administrative type.")]
public enum AdministrativeTypeCode
{
    /// <summary>
    /// Text message.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_N79nkDNKEeylu6lH-gut-A")]
    [Description(@"Text message.")]
    TEXT,
    
    /// <summary>
    /// Other administrative type defined at private level.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_TckJYDNKEeylu6lH-gut-A")]
    [Description(@"Other administrative type defined at private level.")]
    OTHP,
    
    /// <summary>
    /// Other administrative type defined at national level.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_fkWakDNKEeylu6lH-gut-A")]
    [Description(@"Other administrative type defined at national level.")]
    OTHN,
    
    /// <summary>
    /// Currency conversion rate data.
    /// </summary>
    [EnumMember(Value = "CCRD")]
    [IsoId("_kBf7UDNKEeylu6lH-gut-A")]
    [Description(@"Currency conversion rate data.")]
    CCRD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdministrativeTypeCodeMetadataExtensions
{
    private static readonly AdministrativeTypeCodeDropdownSource _dropdownSource = new AdministrativeTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdministrativeTypeCodeDropdownRow GetMetadata(this AdministrativeTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


