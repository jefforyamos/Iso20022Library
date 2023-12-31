﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCInstructionStatus1Code.  ISO2002 ID# _121thDL3EeKU9IrkkToqcw_1866676652.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// DTC (The Depository Trust Company) system status code of instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCInstructionStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_121thDL3EeKU9IrkkToqcw_1866676652")]
public partial class DTCInstructionStatus1CodeDropdownSource : EnumMetadataManager<DTCInstructionStatus1Code,IDTCInstructionStatus1CodeDropdownRow,DTCInstructionStatus1CodeDropdownRow>
{
    public DTCInstructionStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCInstructionStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
