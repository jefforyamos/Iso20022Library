﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Q_EOUNp-Ed-ak6NoX_4Aeg_-27583390.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BookingUnit1Choice;

/// <summary>
/// Booking unit is defined using a data source scheme.
/// </summary>
public partial record Proprietary : IBookingUnit1Choice
{
    #nullable enable
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax35Text Issuer { get; init; } 
    #nullable disable
}
