﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification17.  ISO2002 ID# _K2B0F-aOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SubAccountIdentification17
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification36Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount14 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    public AggregateBalanceInformation12? BalanceForSubAccount { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
