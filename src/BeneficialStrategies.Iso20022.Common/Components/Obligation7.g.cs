﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Obligation7.  ISO2002 ID# _Ar7UOAM2EeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the collateral agreement.
/// </summary>
public partial record Obligation7
{
    #nullable enable
    
    /// <summary>
    /// One of the entities associated with the collateral agreement
    /// </summary>
    public required PartyIdentification178Choice_ PartyA { get; init; } 
    /// <summary>
    /// Party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    public PartyIdentification178Choice_? ServicingPartyA { get; init; } 
    /// <summary>
    /// Other entity associated with the collateral agreement
    /// </summary>
    public required PartyIdentification178Choice_ PartyB { get; init; } 
    /// <summary>
    /// Party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    public PartyIdentification178Choice_? ServicingPartyB { get; init; } 
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    /// <summary>
    /// Underlying business area or type of trade causing the collateral movement.
    /// </summary>
    public ExposureType5Code? ExposureType { get; init; } 
    /// <summary>
    /// Type of collateral instruction.
    /// </summary>
    public CollateralTransactionType1Choice_? CollateralTransactionType { get; init; } 
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    public CollateralRole1Code? CollateralSide { get; init; } 
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    public AmountAndDirection20? ExposureAmount { get; init; } 
    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    public DateAndDateTime2Choice_? ValuationDate { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public ClosingDate4Choice_? ClosingDate { get; init; } 
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    
    #nullable disable
}
