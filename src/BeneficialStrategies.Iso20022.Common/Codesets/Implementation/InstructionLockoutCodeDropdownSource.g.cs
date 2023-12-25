﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionLockoutCode.  ISO2002 ID# _1oFf1TL3EeKU9IrkkToqcw_-1695680614.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies status of the instruction lock (for elections).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionLockoutCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1oFf1TL3EeKU9IrkkToqcw_-1695680614")]
public partial class InstructionLockoutCodeDropdownSource : EnumMetadataManager<InstructionLockoutCode,IInstructionLockoutCodeDropdownRow,InstructionLockoutCodeDropdownRow>
{
    public InstructionLockoutCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionLockoutCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
