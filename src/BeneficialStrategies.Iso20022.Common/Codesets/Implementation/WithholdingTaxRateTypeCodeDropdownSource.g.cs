﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for WithholdingTaxRateTypeCode.  ISO2002 ID# _gI-FsCeFEeOXAt_43VmZGw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of withholding tax rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IWithholdingTaxRateTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gI-FsCeFEeOXAt_43VmZGw")]
public partial class WithholdingTaxRateTypeCodeDropdownSource : EnumMetadataManager<WithholdingTaxRateTypeCode,IWithholdingTaxRateTypeCodeDropdownRow,WithholdingTaxRateTypeCodeDropdownRow>
{
    public WithholdingTaxRateTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new WithholdingTaxRateTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
