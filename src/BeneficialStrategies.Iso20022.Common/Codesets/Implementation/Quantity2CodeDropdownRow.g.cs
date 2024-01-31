﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Quantity2Code.  ISO2002 ID# _ZXWu9tp-Ed-ak6NoX_4Aeg_274124251.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies quantity of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Quantity2CodeDropdownSource"/>.
/// Implements <seealso cref="IQuantity2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZXWu9tp-Ed-ak6NoX_4Aeg_274124251")]
public partial class Quantity2CodeDropdownRow : EnumMetadataItem<Quantity2Code>, IQuantity2CodeDropdownRow
{
    /// <summary>
    /// Specifies quantity of a financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Quantity2CodeDropdownRow(Quantity2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
