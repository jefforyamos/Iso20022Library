﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vote3.  ISO2002 ID# _TK_TVtp-Ed-ak6NoX_4Aeg_696615532.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Decision of the voting party for one resolution.
/// </summary>
public partial record Vote3
{
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    public required IsoMax35Text IssuerLabel { get; init; } 
    /// <summary>
    /// Specifies the different instructions which can be used to vote.
    /// </summary>
    public required VoteInstruction2Code VoteOption { get; init; } 
    
    #nullable disable
}
