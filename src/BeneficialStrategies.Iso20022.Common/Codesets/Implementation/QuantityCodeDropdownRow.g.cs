﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for QuantityCode.  ISO2002 ID# _ZXgf89p-Ed-ak6NoX_4Aeg_973159431.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Quantity is unknown by the sender or has not been established.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="QuantityCodeDropdownSource"/>.
/// Implements <seealso cref="IQuantityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZXgf89p-Ed-ak6NoX_4Aeg_973159431")]
public partial class QuantityCodeDropdownRow : EnumMetadataItem<QuantityCode>, IQuantityCodeDropdownRow
{
    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public QuantityCodeDropdownRow(QuantityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
