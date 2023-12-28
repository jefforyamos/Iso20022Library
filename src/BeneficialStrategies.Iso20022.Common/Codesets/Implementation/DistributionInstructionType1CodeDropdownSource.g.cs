﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DistributionInstructionType1Code.  ISO2002 ID# _awd2-dp-Ed-ak6NoX_4Aeg_-1269116309.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of distribution instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDistributionInstructionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_awd2-dp-Ed-ak6NoX_4Aeg_-1269116309")]
public partial class DistributionInstructionType1CodeDropdownSource : EnumMetadataManager<DistributionInstructionType1Code,IDistributionInstructionType1CodeDropdownRow,DistributionInstructionType1CodeDropdownRow>
{
    public DistributionInstructionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DistributionInstructionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
