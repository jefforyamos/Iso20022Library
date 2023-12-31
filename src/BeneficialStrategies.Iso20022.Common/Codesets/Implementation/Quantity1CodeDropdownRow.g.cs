﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Quantity1Code.  ISO2002 ID# _ZXWu9Np-Ed-ak6NoX_4Aeg_1332281009.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies quantity of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Quantity1CodeDropdownSource"/>.
/// Implements <seealso cref="IQuantity1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZXWu9Np-Ed-ak6NoX_4Aeg_1332281009")]
public partial class Quantity1CodeDropdownRow : EnumMetadataItem<Quantity1Code>, IQuantity1CodeDropdownRow
{
    /// <summary>
    /// Specifies quantity of a financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Quantity1CodeDropdownRow(Quantity1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
