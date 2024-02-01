﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructionForFinalAgent.  ISO2002 ID# _Prd4cdp-Ed-ak6NoX_4Aeg_-1258143330.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the final agent.
/// </summary>
public partial record InstructionForFinalAgent
{
    #nullable enable
    
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the final agent, in coded form.
    /// </summary>
    public Instruction3Code[] Code { get; init; } = [];
    /// <summary>
    /// Instruction to the final agent that is specific to a user community and is required for use within that user community.||Usage: The proprietary element should only be used when the coded element does not provide sufficient codes or when the selected code in the coded element needs to be supplemented by additional information such as a passport number or telephone number.
    /// </summary>
    public IsoMax140Text? Proprietary { get; init; } 
    
    #nullable disable
}
