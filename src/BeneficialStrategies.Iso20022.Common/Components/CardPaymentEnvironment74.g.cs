﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment74.  ISO2002 ID# _Aa4ywQuJEeqYM5yH99IYQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
public partial record CardPaymentEnvironment74
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    public Acquirer10? Acquirer { get; init; } 
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    public Organisation32? Merchant { get; init; } 
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    public PointOfInteraction10? POI { get; init; } 
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    public PaymentCard30? Card { get; init; } 
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    public CustomerDevice1? CustomerDevice { get; init; } 
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    public CustomerDevice1? Wallet { get; init; } 
    /// <summary>
    /// Payment token information.
    /// </summary>
    public CardPaymentToken5? PaymentToken { get; init; } 
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    public Cardholder16? Cardholder { get; init; } 
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType22? ProtectedCardholderData { get; init; } 
    
    #nullable disable
}
