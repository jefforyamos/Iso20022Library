﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transfer22.  ISO2002 ID# _wucooRgiEeK-_89we2b-bA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record Transfer22
{
    #nullable enable
    
    /// <summary>
    /// Date at which the instructing party places the transfer instruction.
    /// </summary>
    public DateFormat1Choice_? TransferDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    public HoldingsPlanType1Code[] HoldingsPlanType { get; init; } = [];
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
