﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DisputeResolutionTypeCode.  ISO2002 ID# _YcpaMdp-Ed-ak6NoX_4Aeg_-46223766.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DisputeResolutionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDisputeResolutionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcpaMdp-Ed-ak6NoX_4Aeg_-46223766")]
public partial class DisputeResolutionTypeCodeDropdownRow : EnumMetadataItem<DisputeResolutionTypeCode>, IDisputeResolutionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the disputed collateral amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DisputeResolutionTypeCodeDropdownRow(DisputeResolutionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
