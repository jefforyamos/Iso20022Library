﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LodgingSummary2.  ISO2002 ID# _JJ2zkcWmEeuhguwJmlgagQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data pertaining to a lodging transaction. 
/// </summary>
public partial record LodgingSummary2
{
    #nullable enable
    
    /// <summary>
    /// Contains the lodging company's invoice or billing ID reference number, referred to as a folio number. 
    /// </summary>
    public IsoMax35Text? FolioNumber { get; init; } 
    /// <summary>
    /// Details of the lodging property. 
    /// </summary>
    public LodgingProperty2? Property { get; init; } 
    /// <summary>
    /// Contains customer details.
    /// </summary>
    public Customer8? Customer { get; init; } 
    /// <summary>
    /// Number of rooms within the reservation. 
    /// </summary>
    public IsoMax4NumericText? NumberOfRooms { get; init; } 
    /// <summary>
    /// Contains the room details. 
    /// </summary>
    public LodgingRoom1[] Room { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Duration of stay in days.
    /// </summary>
    public IsoMax4NumericText? Duration { get; init; } 
    /// <summary>
    /// Lodging transaction details.
    /// </summary>
    public DepartureOrArrival2? Arrival { get; init; } 
    /// <summary>
    /// Contains departure details. 
    /// </summary>
    public DepartureOrArrival1? Departure { get; init; } 
    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented. 
    /// </summary>
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; } 
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    /// <summary>
    /// Amount of insurance.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    public Tax39[] TotalTax { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Contains the total amount of lodging expenses.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Contains Authorised amount details.
    /// </summary>
    public AuthorisedAmount1[] AuthorisedAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    public LoyaltyProgramme2[] LoyaltyProgramme { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional user-defined data pertaining to the lodging. 
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}
