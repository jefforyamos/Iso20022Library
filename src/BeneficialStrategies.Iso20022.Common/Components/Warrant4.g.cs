﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Warrant4.  ISO2002 ID# _rfndQWf2Eembv_9KtOEw8g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument that gives the holder the right to purchase shares or bonds at a given price within a specified time.
/// </summary>
[DataContract]
[XmlType]
public partial record Warrant4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the ratio or multiply factor used to convert from contracts to shares.
    /// </summary>
    [DataMember]
    public IsoBaseOneRate? Multiplier { get; init; } 
    /// <summary>
    /// Pre-determined price at which the holder of a warrant is entitled to buy the underlying instrument.
    /// </summary>
    [DataMember]
    public Price8? SubscriptionPrice { get; init; } 
    /// <summary>
    /// Indicates when a warrant can be exercised.
    /// </summary>
    [DataMember]
    public WarrantStyle3Choice_? Type { get; init; } 
    /// <summary>
    /// Entity appointed by the issuer to process the exercising of warrants, sometimes responsible for the issuance of the warrants into the market.
    /// </summary>
    [DataMember]
    public ValueList<Organisation38> WarrantAgent { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
