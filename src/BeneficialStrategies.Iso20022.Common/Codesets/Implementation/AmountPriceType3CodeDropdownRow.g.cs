﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AmountPriceType3Code.  ISO2002 ID# _eiyKAJbREee8S7xwGG7Veg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount price type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AmountPriceType3CodeDropdownSource"/>.
/// Implements <seealso cref="IAmountPriceType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eiyKAJbREee8S7xwGG7Veg")]
public partial class AmountPriceType3CodeDropdownRow : EnumMetadataItem<AmountPriceType3Code>, IAmountPriceType3CodeDropdownRow
{
    /// <summary>
    /// Specifies the amount price type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AmountPriceType3CodeDropdownRow(AmountPriceType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
