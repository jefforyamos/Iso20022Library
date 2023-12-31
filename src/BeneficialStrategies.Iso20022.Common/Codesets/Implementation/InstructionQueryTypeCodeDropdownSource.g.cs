﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstructionQueryTypeCode.  ISO2002 ID# _jj4Sgu5NEeCisYr99QEiWA_1468427888.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of instruction queried.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstructionQueryTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jj4Sgu5NEeCisYr99QEiWA_1468427888")]
public partial class InstructionQueryTypeCodeDropdownSource : EnumMetadataManager<InstructionQueryTypeCode,IInstructionQueryTypeCodeDropdownRow,InstructionQueryTypeCodeDropdownRow>
{
    public InstructionQueryTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstructionQueryTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
