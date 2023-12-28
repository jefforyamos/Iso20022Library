﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Modification1Code.  ISO2002 ID# _5rSSUA4SEeKGXqvMN6jpiw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if an item is added, modified, deleted or unchanged.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Modification1CodeDropdownSource"/>.
/// Implements <seealso cref="IModification1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5rSSUA4SEeKGXqvMN6jpiw")]
public partial class Modification1CodeDropdownRow : EnumMetadataItem<Modification1Code>, IModification1CodeDropdownRow
{
    /// <summary>
    /// Specifies if an item is added, modified, deleted or unchanged.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Modification1CodeDropdownRow(Modification1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}