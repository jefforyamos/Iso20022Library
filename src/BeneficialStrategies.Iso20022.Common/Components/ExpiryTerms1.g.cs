﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExpiryTerms1.  ISO2002 ID# _95fqdHltEeG7BsjMvd1mEw_1330700912.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Expiry conditions.
/// </summary>
[DataContract]
[XmlType]
public partial record ExpiryTerms1
{
    #nullable enable
    
    /// <summary>
    /// Date and time when the undertaking will cease to be available.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? DateTime { get; init; } 
    /// <summary>
    /// Details related to the automatic extension of the undertaking.
    /// </summary>
    [DataMember]
    public AutoExtension1? AutoExtension { get; init; } 
    /// <summary>
    /// Documentary condition that indicates when the undertaking will cease to be available.
    /// </summary>
    [DataMember]
    public IsoMax2000Text? Condition { get; init; } 
    /// <summary>
    /// Indicates whether the expiry terms are without a fixed expiry date.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? OpenEndedIndicator { get; init; } 
    
    #nullable disable
}
