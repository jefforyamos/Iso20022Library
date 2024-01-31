﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BusinessFlowDirectionType1Code.  ISO2002 ID# _HUJJQPslEeCIi9ZETLBv8g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BusinessFlowDirectionType1CodeDropdownSource"/>.
/// Implements <seealso cref="IBusinessFlowDirectionType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_HUJJQPslEeCIi9ZETLBv8g")]
public partial class BusinessFlowDirectionType1CodeDropdownRow : EnumMetadataItem<BusinessFlowDirectionType1Code>, IBusinessFlowDirectionType1CodeDropdownRow
{
    /// <summary>
    /// Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BusinessFlowDirectionType1CodeDropdownRow(BusinessFlowDirectionType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
