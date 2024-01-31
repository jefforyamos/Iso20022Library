﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PreAllocationMethodCode.  ISO2002 ID# _aH73WNp-Ed-ak6NoX_4Aeg_616932935.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the method of preallocation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPreAllocationMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aH73WNp-Ed-ak6NoX_4Aeg_616932935")]
public partial class PreAllocationMethodCodeDropdownSource : EnumMetadataManager<PreAllocationMethodCode,IPreAllocationMethodCodeDropdownRow,PreAllocationMethodCodeDropdownRow>
{
    public PreAllocationMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PreAllocationMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
