﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReconciliationStatusCode.  ISO2002 ID# _Zvl6MJSQEeyb24yfD-3rmg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReconciliationStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IReconciliationStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zvl6MJSQEeyb24yfD-3rmg")]
public partial class ReconciliationStatusCodeDropdownRow : EnumMetadataItem<ReconciliationStatusCode>, IReconciliationStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the process type used for the trade repository reconciliation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReconciliationStatusCodeDropdownRow(ReconciliationStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
