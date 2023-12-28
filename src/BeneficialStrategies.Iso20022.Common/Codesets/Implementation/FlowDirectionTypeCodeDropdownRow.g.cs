﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FlowDirectionTypeCode.  ISO2002 ID# _aq9E1dp-Ed-ak6NoX_4Aeg_124504888.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the direction of a cash flow.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FlowDirectionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IFlowDirectionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aq9E1dp-Ed-ak6NoX_4Aeg_124504888")]
public partial class FlowDirectionTypeCodeDropdownRow : EnumMetadataItem<FlowDirectionTypeCode>, IFlowDirectionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the direction of a cash flow.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FlowDirectionTypeCodeDropdownRow(FlowDirectionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}