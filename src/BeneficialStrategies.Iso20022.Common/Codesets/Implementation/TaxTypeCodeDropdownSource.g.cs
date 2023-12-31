﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxTypeCode.  ISO2002 ID# _Yk2T89p-Ed-ak6NoX_4Aeg_1366299042.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yk2T89p-Ed-ak6NoX_4Aeg_1366299042")]
public partial class TaxTypeCodeDropdownSource : EnumMetadataManager<TaxTypeCode,ITaxTypeCodeDropdownRow,TaxTypeCodeDropdownRow>
{
    public TaxTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
