﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transfer21.  ISO2002 ID# _veyNARghEeK-_89we2b-bA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record Transfer21
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    public AdditionalReference2? CounterpartyReference { get; init; } 
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    /// <summary>
    /// Identifies the transfer reason.
    /// </summary>
    public TransferReason1? TransferReason { get; init; } 
    /// <summary>
    /// Date at which the instructing party places the transfer instruction.
    /// </summary>
    public IDateFormat1Choice? TransferDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    public IReadOnlyCollection<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];
    /// <summary>
    /// Information related to the financial instrument to be received.
    /// </summary>
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    
    #nullable disable
}
