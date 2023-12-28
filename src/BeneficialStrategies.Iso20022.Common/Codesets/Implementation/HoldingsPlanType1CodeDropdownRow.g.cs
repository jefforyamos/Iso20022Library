﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for HoldingsPlanType1Code.  ISO2002 ID# _15H24PuzEeC3VvXpH76gow.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the holdings plan of the assets to transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="HoldingsPlanType1CodeDropdownSource"/>.
/// Implements <seealso cref="IHoldingsPlanType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_15H24PuzEeC3VvXpH76gow")]
public partial class HoldingsPlanType1CodeDropdownRow : EnumMetadataItem<HoldingsPlanType1Code>, IHoldingsPlanType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the holdings plan of the assets to transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public HoldingsPlanType1CodeDropdownRow(HoldingsPlanType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
