﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCInstructionStatusCode.  ISO2002 ID# _12r8hTL3EeKU9IrkkToqcw_504869830.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// DTC (The Depository Trust Company) system status code of instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCInstructionStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_12r8hTL3EeKU9IrkkToqcw_504869830")]
public partial class DTCInstructionStatusCodeDropdownSource : EnumMetadataManager<DTCInstructionStatusCode,IDTCInstructionStatusCodeDropdownRow,DTCInstructionStatusCodeDropdownRow>
{
    public DTCInstructionStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCInstructionStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
