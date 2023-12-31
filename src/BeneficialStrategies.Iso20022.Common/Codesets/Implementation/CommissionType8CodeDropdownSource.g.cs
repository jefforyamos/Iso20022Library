﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CommissionType8Code.  ISO2002 ID# _bAHcgdp-Ed-ak6NoX_4Aeg_365784850.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Used to identify soft trades at order entry.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICommissionType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bAHcgdp-Ed-ak6NoX_4Aeg_365784850")]
public partial class CommissionType8CodeDropdownSource : EnumMetadataManager<CommissionType8Code,ICommissionType8CodeDropdownRow,CommissionType8CodeDropdownRow>
{
    public CommissionType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CommissionType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
