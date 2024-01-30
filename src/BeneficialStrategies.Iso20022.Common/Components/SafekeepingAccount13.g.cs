﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafekeepingAccount13.  ISO2002 ID# _fAboZRuUEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification and information about a securities account and balance.
/// </summary>
public partial record SafekeepingAccount13
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification231Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    // public IReadOnlyCollection<HoldingBalance10> InstructedBalance { get; init; }
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    // public IReadOnlyCollection<IPartyIdentification237Choice> RightsHolder { get; init; }
    
    #nullable disable
}
