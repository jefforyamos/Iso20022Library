﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FileActionScopeCode.  ISO2002 ID# _NFe4o90mEeil7LQldntseg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the action applies to a file or a record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NFe4o90mEeil7LQldntseg")]
[Description(@"Indicates whether the action applies to a file or a record.")]
public enum FileActionScopeCode
{
    /// <summary>
    /// Action applies to a file
    /// Encoded/decoded by serializers as "FILE".
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_NFffsN0mEeil7LQldntseg")]
    [Description(@"Action applies to a file")]
    File,
    
    /// <summary>
    /// Action applies to a record
    /// Encoded/decoded by serializers as "RECD".
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_NFffsd0mEeil7LQldntseg")]
    [Description(@"Action applies to a record")]
    Record,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FileActionScopeCodeMetadataExtensions
{
    private static readonly FileActionScopeCodeDropdownSource _dropdownSource = new FileActionScopeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFileActionScopeCodeDropdownRow GetMetadata(this FileActionScopeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

