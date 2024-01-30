﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification67.  ISO2002 ID# _gnUSkSp6EeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SubAccountIdentification67
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification144? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount25? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public BlockChainAddressWallet2? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    public AggregateBalanceInformation42? BalanceForSubAccount { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
