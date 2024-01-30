﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount96.  ISO2002 ID# _kp27MSp6EeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on a quantity, account and other related information.
/// </summary>
public partial record QuantityAndAccount96
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    public required IQuantity51Choice SettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    public IFinancialInstrumentQuantity33Choice? PreviouslySettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    public IFinancialInstrumentQuantity33Choice? RemainingToBeSettledQuantity { get; init; } 
    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    public AmountAndDirection52? PreviouslySettledAmount { get; init; } 
    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    public AmountAndDirection52? RemainingToBeSettledAmount { get; init; } 
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    public IsoMax210Text? DenominationChoice { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification144? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public ICashAccountIdentification5Choice? CashAccount { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    public QuantityBreakdown63? QuantityBreakdown { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    
    #nullable disable
}
