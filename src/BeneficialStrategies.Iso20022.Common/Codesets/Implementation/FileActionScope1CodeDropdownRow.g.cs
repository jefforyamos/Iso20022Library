﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FileActionScope1Code.  ISO2002 ID# _O_lBYDEmEemzCpWiCwK4aQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the action applies to a file or a record.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FileActionScope1CodeDropdownSource"/>.
/// Implements <seealso cref="IFileActionScope1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_O_lBYDEmEemzCpWiCwK4aQ")]
public partial class FileActionScope1CodeDropdownRow : EnumMetadataItem<FileActionScope1Code>, IFileActionScope1CodeDropdownRow
{
    /// <summary>
    /// Indicates whether the action applies to a file or a record.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FileActionScope1CodeDropdownRow(FileActionScope1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
