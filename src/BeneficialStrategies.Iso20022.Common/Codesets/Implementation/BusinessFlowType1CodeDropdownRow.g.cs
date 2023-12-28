﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BusinessFlowType1Code.  ISO2002 ID# _p7MmMPsMEeCZF5_uug7xyA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BusinessFlowType1CodeDropdownSource"/>.
/// Implements <seealso cref="IBusinessFlowType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_p7MmMPsMEeCZF5_uug7xyA")]
public partial class BusinessFlowType1CodeDropdownRow : EnumMetadataItem<BusinessFlowType1Code>, IBusinessFlowType1CodeDropdownRow
{
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BusinessFlowType1CodeDropdownRow(BusinessFlowType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}