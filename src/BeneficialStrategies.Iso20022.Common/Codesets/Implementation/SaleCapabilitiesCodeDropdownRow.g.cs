﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SaleCapabilitiesCode.  ISO2002 ID# _yEJFENtrEeiXqq0XHEoNUA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Hardware capabilities of the Sale Terminal.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SaleCapabilitiesCodeDropdownSource"/>.
/// Implements <seealso cref="ISaleCapabilitiesCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yEJFENtrEeiXqq0XHEoNUA")]
public partial class SaleCapabilitiesCodeDropdownRow : EnumMetadataItem<SaleCapabilitiesCode>, ISaleCapabilitiesCodeDropdownRow
{
    /// <summary>
    /// Hardware capabilities of the Sale Terminal.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SaleCapabilitiesCodeDropdownRow(SaleCapabilitiesCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
