﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AmountPriceTypeCode.  ISO2002 ID# _beqZtdp-Ed-ak6NoX_4Aeg_904379222.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the amount price type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AmountPriceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAmountPriceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_beqZtdp-Ed-ak6NoX_4Aeg_904379222")]
public partial class AmountPriceTypeCodeDropdownRow : EnumMetadataItem<AmountPriceTypeCode>, IAmountPriceTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the amount price type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AmountPriceTypeCodeDropdownRow(AmountPriceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
