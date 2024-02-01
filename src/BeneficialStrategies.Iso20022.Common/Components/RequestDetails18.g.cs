﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestDetails18.  ISO2002 ID# _dfPzkeGFEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the settlement condition modification request.
/// </summary>
public partial record RequestDetails18
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    public required References18 Reference { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public AutomaticBorrowing7Choice_? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    public IsoYesNoIndicator? RetainIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    public LinkageType3Choice_? Linkage { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public PriorityNumeric4Choice_? Priority { get; init; } 
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    public GenericIdentification30[] OtherProcessing { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public HoldIndicator6? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    public MatchingDenied3Choice_? MatchingDenial { get; init; } 
    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    public UnilateralSplit3Choice_? UnilateralSplit { get; init; } 
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    public Linkages51[] Linkages { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
