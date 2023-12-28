﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LegSwapType1Code.  ISO2002 ID# _aeSh0dp-Ed-ak6NoX_4Aeg_-167248068.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of leg structuring a swap. For fixed income, it is used to requests the respondent to calculate the quantity based on the quantity on the opposite side of the swap.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LegSwapType1CodeDropdownSource"/>.
/// Implements <seealso cref="ILegSwapType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aeSh0dp-Ed-ak6NoX_4Aeg_-167248068")]
public partial class LegSwapType1CodeDropdownRow : EnumMetadataItem<LegSwapType1Code>, ILegSwapType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the type of leg structuring a swap. For fixed income, it is used to requests the respondent to calculate the quantity based on the quantity on the opposite side of the swap.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LegSwapType1CodeDropdownRow(LegSwapType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
