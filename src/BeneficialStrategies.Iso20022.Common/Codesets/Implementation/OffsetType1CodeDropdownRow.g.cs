﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OffsetType1Code.  ISO2002 ID# _aOfyV9p-Ed-ak6NoX_4Aeg_-1413993585.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OffsetType1CodeDropdownSource"/>.
/// Implements <seealso cref="IOffsetType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aOfyV9p-Ed-ak6NoX_4Aeg_-1413993585")]
public partial class OffsetType1CodeDropdownRow : EnumMetadataItem<OffsetType1Code>, IOffsetType1CodeDropdownRow
{
    /// <summary>
    /// Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OffsetType1CodeDropdownRow(OffsetType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
