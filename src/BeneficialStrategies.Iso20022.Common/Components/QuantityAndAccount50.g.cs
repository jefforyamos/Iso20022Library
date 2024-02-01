﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount50.  ISO2002 ID# _6MmIXZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the quantity, account and other related information involved in a transaction.
/// </summary>
public partial record QuantityAndAccount50
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ SettlementQuantity { get; init; } 
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    public IsoRestrictedFINXMax210Text? DenominationChoice { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccountIdentification6Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    public QuantityBreakdown38[] QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace2? SafekeepingPlace { get; init; } 
    
    #nullable disable
}
