﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails11.  ISO2002 ID# _jjm1wfFiEd-Vb-3Q5jpLDA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails11
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public PriorityNumeric1Choice_? Priority { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; } 
    /// <summary>
    /// Number identifying a lot constituting the financial instrument.
    /// </summary>
    public Number2Choice_? LotNumber { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    public required DateAndDateTimeChoice_ SettlementDate { get; init; } 
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    public required SecuritiesBalanceType2Choice_ BalanceFrom { get; init; } 
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    public required SecuritiesBalanceType2Choice_ BalanceTo { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
}
