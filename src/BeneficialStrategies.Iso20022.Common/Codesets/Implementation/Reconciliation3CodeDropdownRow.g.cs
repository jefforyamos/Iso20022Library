﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Reconciliation3Code.  ISO2002 ID# _Zw8U8FBUEe2v8Nk6ybN7jA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Reconciliation3CodeDropdownSource"/>.
/// Implements <seealso cref="IReconciliation3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zw8U8FBUEe2v8Nk6ybN7jA")]
public partial class Reconciliation3CodeDropdownRow : EnumMetadataItem<Reconciliation3Code>, IReconciliation3CodeDropdownRow
{
    /// <summary>
    /// Specifies the process type used for the trade repository reconciliation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Reconciliation3CodeDropdownRow(Reconciliation3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}