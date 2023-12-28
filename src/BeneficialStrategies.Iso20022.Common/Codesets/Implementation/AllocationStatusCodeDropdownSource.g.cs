﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AllocationStatusCode.  ISO2002 ID# _boymEtp-Ed-ak6NoX_4Aeg_-1844046552.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of allocation of collateral to cover the instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAllocationStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_boymEtp-Ed-ak6NoX_4Aeg_-1844046552")]
public partial class AllocationStatusCodeDropdownSource : EnumMetadataManager<AllocationStatusCode,IAllocationStatusCodeDropdownRow,AllocationStatusCodeDropdownRow>
{
    public AllocationStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AllocationStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}