﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FileActionScopeCode.  ISO2002 ID# _NFe4o90mEeil7LQldntseg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the action applies to a file or a record.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FileActionScopeCodeDropdownSource"/>.
/// Implements <seealso cref="IFileActionScopeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NFe4o90mEeil7LQldntseg")]
public partial class FileActionScopeCodeDropdownRow : EnumMetadataItem<FileActionScopeCode>, IFileActionScopeCodeDropdownRow
{
    /// <summary>
    /// Indicates whether the action applies to a file or a record.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FileActionScopeCodeDropdownRow(FileActionScopeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}