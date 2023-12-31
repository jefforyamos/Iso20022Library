﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SaleCapabilities1Code.  ISO2002 ID# _hlgS8NtsEeiXqq0XHEoNUA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Hardware capabilities of the Sale Terminal.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SaleCapabilities1CodeDropdownSource"/>.
/// Implements <seealso cref="ISaleCapabilities1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hlgS8NtsEeiXqq0XHEoNUA")]
public partial class SaleCapabilities1CodeDropdownRow : EnumMetadataItem<SaleCapabilities1Code>, ISaleCapabilities1CodeDropdownRow
{
    /// <summary>
    /// Hardware capabilities of the Sale Terminal.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SaleCapabilities1CodeDropdownRow(SaleCapabilities1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
