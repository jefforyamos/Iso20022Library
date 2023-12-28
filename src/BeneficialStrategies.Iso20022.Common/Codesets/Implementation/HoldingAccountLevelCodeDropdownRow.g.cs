﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for HoldingAccountLevelCode.  ISO2002 ID# _SvcYkU1pEeSvz4A_x0ui8g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of the safekeeping holding account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="HoldingAccountLevelCodeDropdownSource"/>.
/// Implements <seealso cref="IHoldingAccountLevelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SvcYkU1pEeSvz4A_x0ui8g")]
public partial class HoldingAccountLevelCodeDropdownRow : EnumMetadataItem<HoldingAccountLevelCode>, IHoldingAccountLevelCodeDropdownRow
{
    /// <summary>
    /// Specifies the level of the safekeeping holding account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public HoldingAccountLevelCodeDropdownRow(HoldingAccountLevelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}