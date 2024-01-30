﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument101.  ISO2002 ID# _V3-UwelwEeuJptoA6B9tfA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security or other asset.
/// </summary>
public partial record FinancialInstrument101
{
    #nullable enable
    
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    public IsoMax35Text? LineIdentification { get; init; } 
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    public required IFinancialInstrument61Choice Instrument { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference10? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    public AdditionalReference10? CounterpartyReference { get; init; } 
    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    public Account28? TransfereeAccount { get; init; } 
    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    public Account28? Transferor { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    public FundSettlementParameters18? SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Indicates whether the assets are held in an individual’s own name.
    /// </summary>
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; } 
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; } 
    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
