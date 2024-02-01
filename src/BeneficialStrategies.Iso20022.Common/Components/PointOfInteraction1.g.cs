﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteraction1.  ISO2002 ID# _TGSgUwEcEeCQm6a_G2yO_w_-296140444.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point of interaction (POI) performing the transaction.
/// </summary>
public partial record PointOfInteraction1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    public required GenericIdentification32 Identification { get; init; } 
    /// <summary>
    /// Common name assigned by the acquirer to the POI system.
    /// </summary>
    public IsoMax70Text? SystemName { get; init; } 
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    public IsoMax35Text? GroupIdentification { get; init; } 
    /// <summary>
    /// Capabilities of the POI performing the transaction.
    /// </summary>
    public PointOfInteractionCapabilities1? Capabilities { get; init; } 
    /// <summary>
    /// Data related to a component of the POI performing the transaction.
    /// </summary>
    public PointOfInteractionComponent1[] Component { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
