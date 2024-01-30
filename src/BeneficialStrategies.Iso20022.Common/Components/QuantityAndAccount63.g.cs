﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount63.  ISO2002 ID# _e0Z2oa5YEeey8N0JWnVPUw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the quantity, account and other related information involved in a transaction.
/// </summary>
public partial record QuantityAndAccount63
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required IFinancialInstrumentQuantity1Choice SettlementQuantity { get; init; } 
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    public IsoMax210Text? DenominationChoice { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification98? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount19 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public ICashAccountIdentification5Choice? CashAccount { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    public QuantityBreakdown46? QuantityBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace1? SafekeepingPlace { get; init; } 
    
    #nullable disable
}
