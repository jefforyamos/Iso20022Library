﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PINFormat3Code.  ISO2002 ID# _WF5aYS_tEeO4w-IWHJMI9g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// PIN (Personal Identification Number) format used before encryption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WF5aYS_tEeO4w-IWHJMI9g")]
[Description(@"PIN (Personal Identification Number) format used before encryption.")]
[DerivedFrom(typeof(PINFormatCode))]
public enum PINFormat3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO0".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WUeo8S_tEeO4w-IWHJMI9g")]
    [Description(@"??")]
    ISO0,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WUeo8y_tEeO4w-IWHJMI9g")]
    [Description(@"??")]
    ISO1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WUeo9S_tEeO4w-IWHJMI9g")]
    [Description(@"??")]
    ISO2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WUeo9y_tEeO4w-IWHJMI9g")]
    [Description(@"??")]
    ISO3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO4".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WUeo-S_tEeO4w-IWHJMI9g")]
    [Description(@"??")]
    ISO4,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO5".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_X1B1sS_tEeO4w-IWHJMI9g")]
    [Description(@"??")]
    ISO5,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PINFormat3CodeMetadataExtensions
{
    private static readonly PINFormat3CodeDropdownSource _dropdownSource = new PINFormat3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPINFormat3CodeDropdownRow GetMetadata(this PINFormat3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


