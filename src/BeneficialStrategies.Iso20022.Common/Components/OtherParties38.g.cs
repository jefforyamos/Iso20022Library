﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherParties38.  ISO2002 ID# _Ga5BAMIsEei34K_Q744LyA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other business parties relevant to the transaction/Instruction
/// </summary>
public partial record OtherParties38
{
    #nullable enable
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    public PartyIdentification136? Issuer { get; init; } 
    /// <summary>
    /// Instructing party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentification149[] Investor { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
