﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FinancingStatusReasonCode.  ISO2002 ID# _aqgY5Np-Ed-ak6NoX_4Aeg_1593858714.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the coded reason for the financing status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFinancingStatusReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aqgY5Np-Ed-ak6NoX_4Aeg_1593858714")]
public partial class FinancingStatusReasonCodeDropdownSource : EnumMetadataManager<FinancingStatusReasonCode,IFinancingStatusReasonCodeDropdownRow,FinancingStatusReasonCodeDropdownRow>
{
    public FinancingStatusReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FinancingStatusReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
