﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GoodsAndServices1Code.  ISO2002 ID# _XQ414ErDEeenp6hmNprBHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of goods and services purchased.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GoodsAndServices1CodeDropdownSource"/>.
/// Implements <seealso cref="IGoodsAndServices1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XQ414ErDEeenp6hmNprBHg")]
public partial class GoodsAndServices1CodeDropdownRow : EnumMetadataItem<GoodsAndServices1Code>, IGoodsAndServices1CodeDropdownRow
{
    /// <summary>
    /// Type of goods and services purchased.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GoodsAndServices1CodeDropdownRow(GoodsAndServices1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}