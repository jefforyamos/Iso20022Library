﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BusinessFlowTypeCode.  ISO2002 ID# _EbRBA_sMEeCZF5_uug7xyA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BusinessFlowTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IBusinessFlowTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EbRBA_sMEeCZF5_uug7xyA")]
public partial class BusinessFlowTypeCodeDropdownRow : EnumMetadataItem<BusinessFlowTypeCode>, IBusinessFlowTypeCodeDropdownRow
{
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BusinessFlowTypeCodeDropdownRow(BusinessFlowTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
