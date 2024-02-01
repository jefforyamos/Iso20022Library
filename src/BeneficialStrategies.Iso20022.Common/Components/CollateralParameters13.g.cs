﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralParameters13.  ISO2002 ID# _MOvFUSs9EeySlt9bF77XfA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular triparty collateral instruction/transaction  can be confirmed. These parameters are defined by the instructing party in compliance with triparty collateral rules in the market the instruction/transaction will take place.
/// </summary>
public partial record CollateralParameters13
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    public required ExposureType23Choice_ ExposureType { get; init; } 
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    public required CollateralRole1Code CollateralSide { get; init; } 
    /// <summary>
    /// Specifies the priority with which the instruction needs to be executed.
    /// </summary>
    public GenericIdentification30? Priority { get; init; } 
    /// <summary>
    /// Specifies whether the allocation of the collateral is manual or automatic.
    /// </summary>
    public IsoYesNoIndicator? AutomaticAllocation { get; init; } 
    /// <summary>
    /// Indicates whether the proposed collateral movements can be accepted.
    /// </summary>
    public IsoYesNoIndicator? CollateralApproved { get; init; } 
    /// <summary>
    /// Indicates whether the proposed collateral movements have settled or not.
    /// </summary>
    public IsoYesNoIndicator? SettlementApproved { get; init; } 
    /// <summary>
    /// Specifies the amount of the collateral.
    /// </summary>
    public CollateralAmount5? CollateralAmount { get; init; } 
    
    #nullable disable
}
