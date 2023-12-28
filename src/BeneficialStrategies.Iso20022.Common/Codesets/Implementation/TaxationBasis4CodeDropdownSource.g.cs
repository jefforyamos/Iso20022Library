﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxationBasis4Code.  ISO2002 ID# _ZScZx9p-Ed-ak6NoX_4Aeg_678158284.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tax basis.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxationBasis4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZScZx9p-Ed-ak6NoX_4Aeg_678158284")]
public partial class TaxationBasis4CodeDropdownSource : EnumMetadataManager<TaxationBasis4Code,ITaxationBasis4CodeDropdownRow,TaxationBasis4CodeDropdownRow>
{
    public TaxationBasis4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxationBasis4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
