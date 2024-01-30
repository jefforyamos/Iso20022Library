﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard11.  ISO2002 ID# _o19lQWlsEeSGkpGpjm7tzg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
public partial record PaymentCard11
{
    #nullable enable
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType10? ProtectedCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData9? PlainCardData { get; init; } 
    /// <summary>
    /// Masked PAN to be printed the payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as '*'.
    /// </summary>
    public IsoMax30Text? MaskedPAN { get; init; } 
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
    /// Type of card product.
    /// </summary>
    public CardProductType1Code? CardProductType { get; init; } 
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    public IsoMax70Text? AdditionalCardData { get; init; } 
    
    #nullable disable
}
