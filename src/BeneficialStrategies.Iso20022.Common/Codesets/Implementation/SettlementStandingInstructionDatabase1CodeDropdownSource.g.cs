﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementStandingInstructionDatabase1Code.  ISO2002 ID# _ZMMAxtp-Ed-ak6NoX_4Aeg_-1452828987.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementStandingInstructionDatabase1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZMMAxtp-Ed-ak6NoX_4Aeg_-1452828987")]
public partial class SettlementStandingInstructionDatabase1CodeDropdownSource : EnumMetadataManager<SettlementStandingInstructionDatabase1Code,ISettlementStandingInstructionDatabase1CodeDropdownRow,SettlementStandingInstructionDatabase1CodeDropdownRow>
{
    public SettlementStandingInstructionDatabase1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementStandingInstructionDatabase1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
