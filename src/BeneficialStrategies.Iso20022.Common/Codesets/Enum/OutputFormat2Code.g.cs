﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OutputFormat2Code.  ISO2002 ID# _iMwOkIqHEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Information format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iMwOkIqHEeSRT5rEzcAHEw")]
[Description(@"Information format.")]
[DerivedFrom(typeof(OutputFormatCode))]
public enum OutputFormat2Code
{
    /// <summary>
    /// Predefined configured messages, identified by a reference.
    /// Encoded/decoded by serializers as "MessageReference".
    /// </summary>
    [EnumMember(Value = "MREF")]
    [IsoId("_lPN6AYqHEeSRT5rEzcAHEw")]
    [Description(@"Predefined configured messages, identified by a reference.")]
    MessageReference,
    
    /// <summary>
    /// Screen to display identified by a reference.
    /// Encoded/decoded by serializers as "ScreenReference".
    /// </summary>
    [EnumMember(Value = "SREF")]
    [IsoId("_lUIPMYqHEeSRT5rEzcAHEw")]
    [Description(@"Screen to display identified by a reference.")]
    ScreenReference,
    
    /// <summary>
    /// Text without format attributes.
    /// Encoded/decoded by serializers as "SimpleText".
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_lY5acYqHEeSRT5rEzcAHEw")]
    [Description(@"Text without format attributes.")]
    SimpleText,
    
    /// <summary>
    /// XHTML document which includes a subset of the XHTML output tag.
    /// Encoded/decoded by serializers as "XHTML".
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_ld0WsYqHEeSRT5rEzcAHEw")]
    [Description(@"XHTML document which includes a subset of the XHTML output tag.")]
    XHTML,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OutputFormat2CodeMetadataExtensions
{
    private static readonly OutputFormat2CodeDropdownSource _dropdownSource = new OutputFormat2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOutputFormat2CodeDropdownRow GetMetadata(this OutputFormat2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


