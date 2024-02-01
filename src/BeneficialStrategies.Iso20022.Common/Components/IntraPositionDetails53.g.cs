﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails53.  ISO2002 ID# __66EbwVUEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails53
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    /// <summary>
    /// Number identifying a Securities Sub balance Type for example restriction identification.
    /// </summary>
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; } 
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    public AmountAndDirection55? CollateralMonitorAmount { get; init; } 
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; } 
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    public DateAndDateTime2Choice_? AvailableDate { get; init; } 
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    public CorporateActionEventType101Choice_? CorporateActionEventType { get; init; } 
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown4 BalanceFrom { get; init; } 
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown4 BalanceTo { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
}
