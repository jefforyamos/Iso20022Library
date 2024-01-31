﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DisputeResolutionType2Code.  ISO2002 ID# _YcgQQtp-Ed-ak6NoX_4Aeg_1011613504.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDisputeResolutionType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcgQQtp-Ed-ak6NoX_4Aeg_1011613504")]
public partial class DisputeResolutionType2CodeDropdownSource : EnumMetadataManager<DisputeResolutionType2Code,IDisputeResolutionType2CodeDropdownRow,DisputeResolutionType2CodeDropdownRow>
{
    public DisputeResolutionType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DisputeResolutionType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
