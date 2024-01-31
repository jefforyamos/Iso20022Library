﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StandingInstructionGrossNetCode.  ISO2002 ID# _ZPw5Mdp-Ed-ak6NoX_4Aeg_1122595996.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStandingInstructionGrossNetCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZPw5Mdp-Ed-ak6NoX_4Aeg_1122595996")]
public partial class StandingInstructionGrossNetCodeDropdownSource : EnumMetadataManager<StandingInstructionGrossNetCode,IStandingInstructionGrossNetCodeDropdownRow,StandingInstructionGrossNetCodeDropdownRow>
{
    public StandingInstructionGrossNetCodeDropdownSource()
        : base( (enumValue, memberInfo) => new StandingInstructionGrossNetCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
