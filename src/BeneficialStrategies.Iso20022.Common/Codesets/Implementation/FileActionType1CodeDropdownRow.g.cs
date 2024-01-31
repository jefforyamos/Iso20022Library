﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FileActionType1Code.  ISO2002 ID# _9p8WwFDqEee94_dUz-hvgw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Determines the type of file action service.
/// ISO 8583:87 bit 91; ISO 8583:93/2003 bit 24
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FileActionType1CodeDropdownSource"/>.
/// Implements <seealso cref="IFileActionType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9p8WwFDqEee94_dUz-hvgw")]
public partial class FileActionType1CodeDropdownRow : EnumMetadataItem<FileActionType1Code>, IFileActionType1CodeDropdownRow
{
    /// <summary>
    /// Determines the type of file action service.
    /// ISO 8583:87 bit 91; ISO 8583:93/2003 bit 24
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FileActionType1CodeDropdownRow(FileActionType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
