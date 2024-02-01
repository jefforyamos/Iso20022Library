﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount108.  ISO2002 ID# _dud07Ti8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on a quantity, account and other related information.
/// </summary>
public partial record QuantityAndAccount108
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    public required Quantity54Choice_ SettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    public FinancialInstrumentQuantity36Choice_? PreviouslySettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    public FinancialInstrumentQuantity36Choice_? RemainingToBeSettledQuantity { get; init; } 
    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    public AmountAndDirection57? PreviouslySettledAmount { get; init; } 
    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    public AmountAndDirection57? RemainingToBeSettledAmount { get; init; } 
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    public IsoRestrictedFINXMax210Text? DenominationChoice { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification156? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccountIdentification6Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    public QuantityBreakdown75[] QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    
    #nullable disable
}
