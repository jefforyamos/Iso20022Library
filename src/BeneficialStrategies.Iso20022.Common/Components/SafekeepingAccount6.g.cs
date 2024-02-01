﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafekeepingAccount6.  ISO2002 ID# _HjiCdVtiEeSwKe7KuKvXhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// A safekeeping account is an account on which a securities entry is made.
/// </summary>
public partial record SafekeepingAccount6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification40Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    public SubAccount2? SubAccountDetails { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public HoldingBalance8[] InstructedBalance { get; init; } = [];
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    public PartyIdentification40Choice_[] RightsHolder { get; init; } = [];
    
    #nullable disable
}
