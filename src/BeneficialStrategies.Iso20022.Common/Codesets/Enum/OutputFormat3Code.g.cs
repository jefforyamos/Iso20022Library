﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OutputFormat3Code.  ISO2002 ID# _sseY0NuXEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of output format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sseY0NuXEeiB5uLfkg9ZJA")]
[Description(@"Type of output format.")]
[DerivedFrom(typeof(OutputFormatCode))]
public enum OutputFormat3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Barcode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_A6E6kduYEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    Barcode,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MenuEntry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_A-QP8duYEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    MenuEntry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MessageReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BFHF4duYEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    MessageReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ScreenReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_CYgAYduYEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    ScreenReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SimpleText".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_CfgAQduYEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    SimpleText,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "XHTML".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_CmojAduYEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    XHTML,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OutputFormat3CodeMetadataExtensions
{
    private static readonly OutputFormat3CodeDropdownSource _dropdownSource = new OutputFormat3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOutputFormat3CodeDropdownRow GetMetadata(this OutputFormat3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

