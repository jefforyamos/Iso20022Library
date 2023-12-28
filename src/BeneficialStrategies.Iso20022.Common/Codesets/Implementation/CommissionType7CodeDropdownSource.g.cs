﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CommissionType7Code.  ISO2002 ID# _a_9rh9p-Ed-ak6NoX_4Aeg_1912267455.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund commission.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICommissionType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a_9rh9p-Ed-ak6NoX_4Aeg_1912267455")]
public partial class CommissionType7CodeDropdownSource : EnumMetadataManager<CommissionType7Code,ICommissionType7CodeDropdownRow,CommissionType7CodeDropdownRow>
{
    public CommissionType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CommissionType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
