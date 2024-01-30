﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails58.  ISO2002 ID# _dsj_YSp_EeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails58
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public IPriorityNumeric4Choice? Priority { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required IFinancialInstrumentQuantity33Choice SettlementQuantity { get; init; } 
    /// <summary>
    /// Number identifying a securities sub balance type (for example, restriction identification etc…).
    /// </summary>
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    public required IDateAndDateTime2Choice SettlementDate { get; init; } 
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown5 BalanceFrom { get; init; } 
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown5 BalanceTo { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which cannot be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
}
