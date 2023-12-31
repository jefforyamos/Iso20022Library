﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StandingOrderType1Code.  ISO2002 ID# _8OFBU6MgEeCJ6YNENx4h-w_-143150650.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StandingOrderType1CodeDropdownSource"/>.
/// Implements <seealso cref="IStandingOrderType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8OFBU6MgEeCJ6YNENx4h-w_-143150650")]
public partial class StandingOrderType1CodeDropdownRow : EnumMetadataItem<StandingOrderType1Code>, IStandingOrderType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StandingOrderType1CodeDropdownRow(StandingOrderType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
