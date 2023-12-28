﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TotalDetails1Code.  ISO2002 ID# _ILmMsN6TEeiwsev40qZGEQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TotalDetails1CodeDropdownSource"/>.
/// Implements <seealso cref="ITotalDetails1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ILmMsN6TEeiwsev40qZGEQ")]
public partial class TotalDetails1CodeDropdownRow : EnumMetadataItem<TotalDetails1Code>, ITotalDetails1CodeDropdownRow
{
    /// <summary>
    /// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TotalDetails1CodeDropdownRow(TotalDetails1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}