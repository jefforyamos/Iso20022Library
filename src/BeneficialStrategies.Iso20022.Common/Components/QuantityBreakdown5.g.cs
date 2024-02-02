﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown5.  ISO2002 ID# _TAjk9tp-Ed-ak6NoX_4Aeg_-322788334.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
[DataContract]
[XmlType]
public partial record QuantityBreakdown5
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [DataMember]
    public required Number2Choice_ LotNumber { get; init; } 
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    
    #nullable disable
}
