﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TripLeg1.  ISO2002 ID# _Z20p3_PzEeihCvvpsmGI2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for travel transactions.
/// </summary>
public partial record TripLeg1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the specific occurrence of trip leg data. 
    /// </summary>
    public IsoMax35NumericText? SequenceNumber { get; init; } 
    /// <summary>
    /// Details of the ticket.
    /// </summary>
    public Ticket1? Ticket { get; init; } 
    /// <summary>
    /// Provides the document type and reference information.
    /// </summary>
    public DocumentReference1[] Document { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which service was booked or cancellation was done.
    /// </summary>
    public IsoMax35Text? ProcedureReference { get; init; } 
    /// <summary>
    /// Type of transportation.
    /// </summary>
    public TransportType1Code? TransportType { get; init; } 
    /// <summary>
    /// Other type of transportation.
    /// </summary>
    public IsoMax35Text? OtherTransportType { get; init; } 
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    public IsoMax4Text? CommodityCode { get; init; } 
    /// <summary>
    /// Identification of transportation carrier.
    /// </summary>
    public CarrierIdentification1? Carrier { get; init; } 
    /// <summary>
    /// Route number as specified by the transportation carrier (for example, flight number, bus number, train route or number, etc.)
    /// </summary>
    public IsoMax35Text? RouteNumber { get; init; } 
    /// <summary>
    /// Indicates the service class (for example, coach or first class).
    /// </summary>
    public IsoMax35Text? ServiceClass { get; init; } 
    /// <summary>
    /// Contains departure location, date and time. 
    /// </summary>
    public DepartureOrArrival1? Departure { get; init; } 
    /// <summary>
    /// Contains arrival location, date and time. 
    /// </summary>
    public DepartureOrArrival1? Arrival { get; init; } 
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    public IsoMax4NumericText? Duration { get; init; } 
    /// <summary>
    /// Indicator that specifies whether the mode of transportation was a direct or non-direct route on the same ticket number.
    /// </summary>
    public IsoTrueFalseIndicator? StopOverIndicator { get; init; } 
    /// <summary>
    /// Indicates a non-direct route between the origin and the destination. 
    /// </summary>
    public IsoMax35Text? NonDirectRouteCode { get; init; } 
    /// <summary>
    /// Code that transportation companies assign to a particular ticket type, such as business class or discounted or non-refundable tickets. 
    /// </summary>
    public IsoMax35Text? FairBasisCode { get; init; } 
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    /// <summary>
    /// Contains trip leg amount information. 
    /// </summary>
    public AmountDetails1[] TripLegAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates reason for the credit to the cardholder.  Includes: ancillary purchase cancelled, passenger transport ticket and related ancillary purchase cancelled, etc.
    /// </summary>
    public IsoMax35Text? CreditReasonCode { get; init; } 
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which the service was booked or a cancellation was completed. 
    /// </summary>
    public IsoMax35Text? ProcedureIdentification { get; init; } 
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    /// <summary>
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}
