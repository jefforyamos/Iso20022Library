﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxReclaimMethodCode.  ISO2002 ID# _Nff_g_M9Eei4qfiLgRIZBA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains Tax Reclaim options
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxReclaimMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Nff_g_M9Eei4qfiLgRIZBA")]
public partial class TaxReclaimMethodCodeDropdownSource : EnumMetadataManager<TaxReclaimMethodCode,ITaxReclaimMethodCodeDropdownRow,TaxReclaimMethodCodeDropdownRow>
{
    public TaxReclaimMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxReclaimMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
