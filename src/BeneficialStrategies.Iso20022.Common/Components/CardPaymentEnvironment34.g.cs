﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment34.  ISO2002 ID# _JdftkWlsEeSGkpGpjm7tzg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
public partial record CardPaymentEnvironment34
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    public Acquirer4? Acquirer { get; init; } 
    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    public Organisation8? Merchant { get; init; } 
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    public required PointOfInteraction4 POI { get; init; } 
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    public PaymentCard11? Card { get; init; } 
    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    public CustomerDevice1? CustomerDevice { get; init; } 
    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    public CustomerDevice1? Wallet { get; init; } 
    /// <summary>
    /// Payment token information.
    /// </summary>
    public CardPaymentToken3? PaymentToken { get; init; } 
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    public Cardholder8? Cardholder { get; init; } 
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType10? ProtectedCardholderData { get; init; } 
    
    #nullable disable
}
