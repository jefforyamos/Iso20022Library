﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment65.  ISO2002 ID# _sFoHsapzEeanIZ10Ka8PnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction given in a response to a request.
/// </summary>
public partial record CardPaymentEnvironment65
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    public GenericIdentification53? AcquirerIdentification { get; init; } 
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    public GenericIdentification32? MerchantIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public required GenericIdentification32 POIIdentification { get; init; } 
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    public PaymentCard27? Card { get; init; } 
    /// <summary>
    /// Payment token information.
    /// </summary>
    public CardPaymentToken2? PaymentToken { get; init; } 
    
    #nullable disable
}
