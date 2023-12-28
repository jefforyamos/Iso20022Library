﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CopyDuplicate1Code.  ISO2002 ID# _bCWRI9p-Ed-ak6NoX_4Aeg_-462671342.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CopyDuplicate1CodeDropdownSource"/>.
/// Implements <seealso cref="ICopyDuplicate1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bCWRI9p-Ed-ak6NoX_4Aeg_-462671342")]
public partial class CopyDuplicate1CodeDropdownRow : EnumMetadataItem<CopyDuplicate1Code>, ICopyDuplicate1CodeDropdownRow
{
    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CopyDuplicate1CodeDropdownRow(CopyDuplicate1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
