﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment42.  ISO2002 ID# _g6fJIWpAEeS4VPLpYyQgxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the diagnostic exchange.
/// </summary>
public partial record CardPaymentEnvironment42
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    public required Acquirer4 Acquirer { get; init; } 
    /// <summary>
    /// The availability of the acquirer to process transaction must be provided.
    /// </summary>
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; } 
    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    public GenericIdentification53? MerchantIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    public GenericIdentification32? POIIdentification { get; init; } 
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the payment transactions.
    /// </summary>
    public PointOfInteractionComponent5[] POIComponent { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
