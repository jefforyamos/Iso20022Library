﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonEquitySubClass1.  ISO2002 ID# _POi7M6aTEeqZmriXpMtonA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-class of non-equity instruments sharing common characteristics according to criteria defined as per local regulation.
/// </summary>
[DataContract]
[XmlType]
public partial record NonEquitySubClass1
{
    #nullable enable
    
    /// <summary>
    /// Description of the derivative sub-class.
    /// </summary>
    [DataMember]
    public IsoMax1000Text? Description { get; init; } 
    /// <summary>
    /// Criteria used to segment classes of derivative instruments into sub classes as per local regulation.
    /// </summary>
    [DataMember]
    public ValueList<NonEquitySubClassSegmentationCriterion1> SegmentationCriteria { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
