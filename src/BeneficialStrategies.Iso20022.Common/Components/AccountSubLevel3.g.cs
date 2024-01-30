﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountSubLevel3.  ISO2002 ID# _WpqXp4j2EeONZKAAW4pOaQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 3).
/// </summary>
public partial record AccountSubLevel3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    public required PartyIdentification100 AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the sub-level account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public required PartyIdentification100 AccountServicer { get; init; } 
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    public BeneficialOwner2? BeneficialOwner { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    public AggregateHoldingBalance1? BalanceForAccount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Holdings of level 4.
    /// </summary>
    public AccountSubLevel4? AccountSubLevel4 { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Difference in holdings betweensub-account at level 3 and the sub-accounts of level 4.
    /// </summary>
    public AggregateHoldingBalance2? AccountSubLevel4Difference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    public Intermediary29? Agent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
