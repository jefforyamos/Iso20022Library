﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReconciliationTypeCode.  ISO2002 ID# _F091QNxeEeioifFt1dhnJA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of Reconciliation requested by the Sale to the POI.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReconciliationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_F091QNxeEeioifFt1dhnJA")]
public partial class ReconciliationTypeCodeDropdownSource : EnumMetadataManager<ReconciliationTypeCode,IReconciliationTypeCodeDropdownRow,ReconciliationTypeCodeDropdownRow>
{
    public ReconciliationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReconciliationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
