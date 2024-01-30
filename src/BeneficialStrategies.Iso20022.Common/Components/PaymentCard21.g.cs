﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard21.  ISO2002 ID# _eTiqgY0TEeWRYffwL7E13A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
public partial record PaymentCard21
{
    #nullable enable
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType10? ProtectedCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData15? PlainCardData { get; init; } 
    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    public IsoMax70Text? PaymentAccountReference { get; init; } 
    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    public IsoMax15NumericText? IssuerBIN { get; init; } 
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    public IsoMax3Text? CardCountryCode { get; init; } 
    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; } 
    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    public IsoMax35Text? CardProductProfile { get; init; } 
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    public IsoMax35Text? CardBrand { get; init; } 
    /// <summary>
    /// True if the card may be used abroad.
    /// </summary>
    public IsoTrueFalseIndicator? InternationalCard { get; init; } 
    /// <summary>
    /// Product that can be purchased with the card.
    /// </summary>
    public IsoMax70Text? AllowedProduct { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Options to the service provided by the card.
    /// </summary>
    public IsoMax35Text? ServiceOption { get; init; } 
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    public IsoMax70Text? AdditionalCardData { get; init; } 
    
    #nullable disable
}
