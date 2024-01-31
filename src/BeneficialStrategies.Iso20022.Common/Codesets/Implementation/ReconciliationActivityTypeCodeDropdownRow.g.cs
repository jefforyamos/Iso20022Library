﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReconciliationActivityTypeCode.  ISO2002 ID# _ikZkgCX_Eeym0KcvJF9aDQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to indicate the activity type to be reconciled
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReconciliationActivityTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IReconciliationActivityTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ikZkgCX_Eeym0KcvJF9aDQ")]
public partial class ReconciliationActivityTypeCodeDropdownRow : EnumMetadataItem<ReconciliationActivityTypeCode>, IReconciliationActivityTypeCodeDropdownRow
{
    /// <summary>
    /// Code to indicate the activity type to be reconciled
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReconciliationActivityTypeCodeDropdownRow(ReconciliationActivityTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
