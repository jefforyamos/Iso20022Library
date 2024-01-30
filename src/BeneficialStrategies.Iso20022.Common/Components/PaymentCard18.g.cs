﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard18.  ISO2002 ID# _slWAQSC3EeWJd9HF2tO7BA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
/// </summary>
public partial record PaymentCard18
{
    #nullable enable
    
    /// <summary>
    /// Type of card, for example, credit card.
    /// </summary>
    public required CardType1Code Type { get; init; } 
    /// <summary>
    /// Number embossed on a card that links the card to the account owner and account servicer.
    /// </summary>
    public required IsoMax35Text Number { get; init; } 
    /// <summary>
    /// Party entitled by a card issuer to use a card.
    /// </summary>
    public required IsoMax35Text HolderName { get; init; } 
    /// <summary>
    /// Year and month the card is available for use.
    /// </summary>
    public IsoISOYearMonth? StartDate { get; init; } 
    /// <summary>
    /// Year and month the card expires.
    /// </summary>
    public required IsoISOYearMonth ExpiryDate { get; init; } 
    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    public IsoMax35Text? CardIssuerName { get; init; } 
    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    public IPartyIdentification70Choice? CardIssuerIdentification { get; init; } 
    /// <summary>
    /// Security code written on, or in, the card.
    /// </summary>
    public IsoMax35Text? SecurityCode { get; init; } 
    /// <summary>
    /// Number distinguishing two or more payment cards with the same account number.
    /// </summary>
    public IsoMax3Text? SequenceNumber { get; init; } 
    
    #nullable disable
}
