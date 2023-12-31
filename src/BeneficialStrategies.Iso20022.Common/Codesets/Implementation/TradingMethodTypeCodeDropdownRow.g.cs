﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradingMethodTypeCode.  ISO2002 ID# _tZm3wESaEeS6cOLECtYLrA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of trading method.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradingMethodTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ITradingMethodTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tZm3wESaEeS6cOLECtYLrA")]
public partial class TradingMethodTypeCodeDropdownRow : EnumMetadataItem<TradingMethodTypeCode>, ITradingMethodTypeCodeDropdownRow
{
    /// <summary>
    /// Identifies the type of trading method.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradingMethodTypeCodeDropdownRow(TradingMethodTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
