﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for HoldingsPlanTypeCode.  ISO2002 ID# _1TJzwwnwEeGRcv5_yGDZOA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the holdings plan of the assets to transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="HoldingsPlanTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IHoldingsPlanTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1TJzwwnwEeGRcv5_yGDZOA")]
public partial class HoldingsPlanTypeCodeDropdownRow : EnumMetadataItem<HoldingsPlanTypeCode>, IHoldingsPlanTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the holdings plan of the assets to transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public HoldingsPlanTypeCodeDropdownRow(HoldingsPlanTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}