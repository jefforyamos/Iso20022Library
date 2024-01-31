﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxType12Code.  ISO2002 ID# _YkP3Atp-Ed-ak6NoX_4Aeg_-1091962237.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxType12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YkP3Atp-Ed-ak6NoX_4Aeg_-1091962237")]
public partial class TaxType12CodeDropdownSource : EnumMetadataManager<TaxType12Code,ITaxType12CodeDropdownRow,TaxType12CodeDropdownRow>
{
    public TaxType12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxType12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
