﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReconciliationStatus1Code.  ISO2002 ID# _hX-RwJSZEeyTze01ewG2Qw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReconciliationStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IReconciliationStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hX-RwJSZEeyTze01ewG2Qw")]
public partial class ReconciliationStatus1CodeDropdownRow : EnumMetadataItem<ReconciliationStatus1Code>, IReconciliationStatus1CodeDropdownRow
{
    /// <summary>
    /// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReconciliationStatus1CodeDropdownRow(ReconciliationStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
