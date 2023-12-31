﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BeneficiaryCertificationCompletionCode.  ISO2002 ID# _bdn359p-Ed-ak6NoX_4Aeg_-1583381957.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of certification completion required for a beneficiary.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBeneficiaryCertificationCompletionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bdn359p-Ed-ak6NoX_4Aeg_-1583381957")]
public partial class BeneficiaryCertificationCompletionCodeDropdownSource : EnumMetadataManager<BeneficiaryCertificationCompletionCode,IBeneficiaryCertificationCompletionCodeDropdownRow,BeneficiaryCertificationCompletionCodeDropdownRow>
{
    public BeneficiaryCertificationCompletionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BeneficiaryCertificationCompletionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
