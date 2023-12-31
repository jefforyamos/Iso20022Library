﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PriceSource2Code.  ISO2002 ID# _l1ruYaB6EeOEyO7fCl8lLA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the source of a price quotation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PriceSource2CodeDropdownSource"/>.
/// Implements <seealso cref="IPriceSource2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_l1ruYaB6EeOEyO7fCl8lLA")]
public partial class PriceSource2CodeDropdownRow : EnumMetadataItem<PriceSource2Code>, IPriceSource2CodeDropdownRow
{
    /// <summary>
    /// Specifies the source of a price quotation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PriceSource2CodeDropdownRow(PriceSource2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
