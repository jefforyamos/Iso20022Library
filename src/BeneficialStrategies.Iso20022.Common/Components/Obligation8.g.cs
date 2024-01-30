﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Obligation8.  ISO2002 ID# _G5UkMSW1EeyT3chuyX0PgA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the collateral agreement.
/// </summary>
public partial record Obligation8
{
    #nullable enable
    
    /// <summary>
    /// One of the entities associated with the collateral agreement
    /// </summary>
    public required IPartyIdentification178Choice PartyA { get; init; } 
    /// <summary>
    /// Party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    public IPartyIdentification178Choice? ServicingPartyA { get; init; } 
    /// <summary>
    /// Other entity associated with the collateral agreement
    /// </summary>
    public required IPartyIdentification178Choice PartyB { get; init; } 
    /// <summary>
    /// Party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    public IPartyIdentification178Choice? ServicingPartyB { get; init; } 
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Underlying business area or type of trade causing the collateral movement.
    /// </summary>
    public IExposureType21Choice? ExposureType { get; init; } 
    /// <summary>
    /// Type of collateral instruction.
    /// </summary>
    public ICollateralTransactionType1Choice? CollateralTransactionType { get; init; } 
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    public CollateralRole1Code? CollateralSide { get; init; } 
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ExposureAmount { get; init; } 
    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    public IDateAndDateTime2Choice? ValuationDate { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public IClosingDate4Choice? ClosingDate { get; init; } 
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    public IDateAndDateTime2Choice? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    public GenericIdentification30? SettlementProcess { get; init; } 
    
    #nullable disable
}
