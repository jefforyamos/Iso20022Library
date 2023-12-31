﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessingPosition4Code.  ISO2002 ID# _A2UAQBEhEeKG5rB3aM9OkQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessingPosition4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_A2UAQBEhEeKG5rB3aM9OkQ")]
public partial class ProcessingPosition4CodeDropdownSource : EnumMetadataManager<ProcessingPosition4Code,IProcessingPosition4CodeDropdownRow,ProcessingPosition4CodeDropdownRow>
{
    public ProcessingPosition4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessingPosition4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
