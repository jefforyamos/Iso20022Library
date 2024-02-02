﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment64.  ISO2002 ID# _pAXm8apzEeanIZ10Ka8PnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the diagnostic exchange.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentEnvironment64
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [DataMember]
    public required Acquirer4 Acquirer { get; init; } 
    /// <summary>
    /// The availability of the acquirer to process transaction must be provided.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; } 
    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [DataMember]
    public GenericIdentification53? MerchantIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    [DataMember]
    public GenericIdentification32? POIIdentification { get; init; } 
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the payment transactions.
    /// </summary>
    [DataMember]
    public ValueList<PointOfInteractionComponent7> POIComponent { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
