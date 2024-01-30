﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestDetails20.  ISO2002 ID# _ryJe4dBwEeihG9bKfarOOA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the settlement condition modification request.
/// </summary>
public partial record RequestDetails20
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    public required References23 Reference { get; init; } 
    /// <summary>
    /// Restriction references applied on the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    public RestrictionIdentification1? RestrictionReference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public IAutomaticBorrowing7Choice? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Indicates whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    public IsoYesNoIndicator? RetainIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    public ILinkageType3Choice? Linkage { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public IPriorityNumeric4Choice? Priority { get; init; } 
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    public GenericIdentification30? OtherProcessing { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public ISecuritiesRTGS4Choice? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public HoldIndicator6? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    public IMatchingDenied3Choice? MatchingDenial { get; init; } 
    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    public IUnilateralSplit3Choice? UnilateralSplit { get; init; } 
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    public Linkages53? Linkages { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
