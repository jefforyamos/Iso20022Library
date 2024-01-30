﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EligiblePosition13.  ISO2002 ID# _IOz-pzQ_Ee2id-MjcNoBdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities position and rights holders.
/// </summary>
public partial record EligiblePosition13
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IPartyIdentification231Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    // public IReadOnlyCollection<HoldingBalance11> HoldingBalance { get; init; }
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    // public IReadOnlyCollection<IPartyIdentification246Choice> RightsHolder { get; init; }
    
    #nullable disable
}
