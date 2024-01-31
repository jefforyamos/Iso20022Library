﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCorporateActionInstructionType2Code.  ISO2002 ID# _12r8gTL3EeKU9IrkkToqcw_1999140726.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the corporate action instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCorporateActionInstructionType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_12r8gTL3EeKU9IrkkToqcw_1999140726")]
public partial class DTCCorporateActionInstructionType2CodeDropdownSource : EnumMetadataManager<DTCCorporateActionInstructionType2Code,IDTCCorporateActionInstructionType2CodeDropdownRow,DTCCorporateActionInstructionType2CodeDropdownRow>
{
    public DTCCorporateActionInstructionType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCorporateActionInstructionType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
