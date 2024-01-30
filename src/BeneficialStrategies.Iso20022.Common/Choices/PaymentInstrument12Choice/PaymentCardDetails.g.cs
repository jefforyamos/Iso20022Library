﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentCardDetails.  ISO2002 ID# _SBX_6dp-Ed-ak6NoX_4Aeg_1545985520.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument12Choice;

/// <summary>
/// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
/// </summary>
public partial record PaymentCardDetails : IPaymentInstrument12Choice
{
    #nullable enable
    /// <summary>
    /// Type of card, eg, credit card.
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
    public IPartyIdentification2Choice? CardIssuerIdentification { get; init; } 
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
