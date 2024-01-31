﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCInstructionStatus2Code.  ISO2002 ID# _kWpW4JIWEeaNbfbSYshZYw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC (The Depository Trust Company) system status code of instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCInstructionStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kWpW4JIWEeaNbfbSYshZYw")]
public partial class DTCInstructionStatus2CodeDropdownSource : EnumMetadataManager<DTCInstructionStatus2Code,IDTCInstructionStatus2CodeDropdownRow,DTCInstructionStatus2CodeDropdownRow>
{
    public DTCInstructionStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCInstructionStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
