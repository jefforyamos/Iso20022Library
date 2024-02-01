﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafekeepingAccount3.  ISO2002 ID# _QT_4Etp-Ed-ak6NoX_4Aeg_599991386.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// A safekeeping account is an account on which a securities entry is made.
/// </summary>
public partial record SafekeepingAccount3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification9Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    public SubAccount2? SubAccountDetails { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public HoldingBalance4[] InstructedBalance { get; init; } = [];
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    public PartyIdentification9Choice_[] RightsHolder { get; init; } = [];
    
    #nullable disable
}
