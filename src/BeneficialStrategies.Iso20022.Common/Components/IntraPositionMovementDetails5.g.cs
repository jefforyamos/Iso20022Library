﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionMovementDetails5.  ISO2002 ID# _w7exW0ADEeC4mKrqv7wPJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionMovementDetails5
{
    #nullable enable
    
    /// <summary>
    /// Identifications (account owner and/or account servicer) of the intra-position movement.
    /// </summary>
    public References19Choice_? Identification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    /// <summary>
    /// Number identifying a lot constituting the financial instrument.
    /// </summary>
    public Number2Choice_? LotNumber { get; init; } 
    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    public required SecuritiesBalanceType3Choice_ BalanceTo { get; init; } 
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    public required DateAndDateTimeChoice_ SettlementDate { get; init; } 
    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    public DateAndDateTimeChoice_? AvailableDate { get; init; } 
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    public CorporateActionEventType3Choice_? CorporateActionEventType { get; init; } 
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    public AmountAndDirection9? CollateralMonitorAmount { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
