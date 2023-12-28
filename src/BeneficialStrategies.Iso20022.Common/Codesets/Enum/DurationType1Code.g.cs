﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DurationType1Code.  ISO2002 ID# _fLDx4A3eEeW9YKj3GUmIEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the duration of the delivery period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fLDx4A3eEeW9YKj3GUmIEw")]
[Description(@"Specifies the duration of the delivery period.")]
[DerivedFrom(typeof(DurationTypeCode))]
public enum DurationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Year".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_J_AT8RVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Year,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Week".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KNSAgRVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Week,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Season".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KTiZgRVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Season,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quarter".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KfbgcRVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Quarter,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Month".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Kta5IRVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Month,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Minute".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Kxb2cRVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Minute,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Hour".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_K9euYRVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Hour,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Day".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LLdgARVqEeWkV7eOBXXT7Q")]
    [Description(@"??")]
    Day,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_g4ZDwUDeEeWt96EosbOZ-w")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DurationType1CodeMetadataExtensions
{
    private static readonly DurationType1CodeDropdownSource _dropdownSource = new DurationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDurationType1CodeDropdownRow GetMetadata(this DurationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


