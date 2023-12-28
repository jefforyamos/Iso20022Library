﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxationBasisCode.  ISO2002 ID# _ZSljs9p-Ed-ak6NoX_4Aeg_618293605.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tax basis.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxationBasisCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZSljs9p-Ed-ak6NoX_4Aeg_618293605")]
public partial class TaxationBasisCodeDropdownSource : EnumMetadataManager<TaxationBasisCode,ITaxationBasisCodeDropdownRow,TaxationBasisCodeDropdownRow>
{
    public TaxationBasisCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxationBasisCodeDropdownRow(enumValue, memberInfo))
    {
    }
}