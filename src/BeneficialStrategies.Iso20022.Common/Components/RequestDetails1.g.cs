﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestDetails1.  ISO2002 ID# _UhHYzNp-Ed-ak6NoX_4Aeg_-52038934.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the settlement condition modification request.
/// </summary>
[DataContract]
[XmlType]
public partial record RequestDetails1
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [DataMember]
    public required References1 Reference { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [DataMember]
    public AutomaticBorrowing2Choice_? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? RetainIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [DataMember]
    public LinkageType1Choice_? Linkage { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [DataMember]
    public PriorityNumeric1Choice_? Priority { get; init; } 
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [DataMember]
    public ValueList<GenericIdentification20> OtherProcessing { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [DataMember]
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [DataMember]
    public MatchingDenied1Choice_? MatchingDenial { get; init; } 
    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [DataMember]
    public UnilateralSplit1Choice_? UnilateralSplit { get; init; } 
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [DataMember]
    public ValueList<Linkages3> Linkages { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
