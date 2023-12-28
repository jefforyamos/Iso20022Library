﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxType4Code.  ISO2002 ID# _Ykix-dp-Ed-ak6NoX_4Aeg_-858033368.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ykix-dp-Ed-ak6NoX_4Aeg_-858033368")]
public partial class TaxType4CodeDropdownSource : EnumMetadataManager<TaxType4Code,ITaxType4CodeDropdownRow,TaxType4CodeDropdownRow>
{
    public TaxType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
