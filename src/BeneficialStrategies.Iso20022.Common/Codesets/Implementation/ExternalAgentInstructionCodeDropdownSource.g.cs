﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalAgentInstructionCode.  ISO2002 ID# _KTAyqtA4EeeCAfThR1cp_Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions for the agent concerning the processing of an instruction.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalAgentInstructionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KTAyqtA4EeeCAfThR1cp_Q")]
public partial class ExternalAgentInstructionCodeDropdownSource : EnumMetadataManager<ExternalAgentInstructionCode,IExternalAgentInstructionCodeDropdownRow,ExternalAgentInstructionCodeDropdownRow>
{
    public ExternalAgentInstructionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalAgentInstructionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}