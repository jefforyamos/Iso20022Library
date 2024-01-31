﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxType3Code.  ISO2002 ID# _Ykix9dp-Ed-ak6NoX_4Aeg_1780697405.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ykix9dp-Ed-ak6NoX_4Aeg_1780697405")]
public partial class TaxType3CodeDropdownSource : EnumMetadataManager<TaxType3Code,ITaxType3CodeDropdownRow,TaxType3CodeDropdownRow>
{
    public TaxType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
