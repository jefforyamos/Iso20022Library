﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommunicationChannel1.  ISO2002 ID# _9yCXl3ltEeG7BsjMvd1mEw_167324952.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication channel information.
/// </summary>
public partial record CommunicationChannel1
{
    #nullable enable
    
    /// <summary>
    /// Method by which the original undertaking or proposed amendment is to be made available.
    /// </summary>
    public required ExternalChannel1Code Method { get; init; } 
    /// <summary>
    /// Type of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    public required IPartyType1Choice DeliverToPartyType { get; init; } 
    /// <summary>
    /// Name of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    public IsoMax140Text? DeliverToName { get; init; } 
    /// <summary>
    /// Address of party to whom the original undertaking or proposed amendment is intended to be delivered.
    /// </summary>
    public PostalAddress6? DeliverToAddress { get; init; } 
    
    #nullable disable
}
