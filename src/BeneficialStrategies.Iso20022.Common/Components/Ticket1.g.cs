﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Ticket1.  ISO2002 ID# _em5RL_P0EeihCvvpsmGI2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains ticket details. 
/// </summary>
public partial record Ticket1
{
    #nullable enable
    
    /// <summary>
    /// Contains the ticket number. 
    /// </summary>
    public IsoMax35Text? TicketNumber { get; init; } 
    /// <summary>
    /// Name of the issuing ticket agent. 
    /// </summary>
    public PartyIdentification197? TicketIssuer { get; init; } 
    /// <summary>
    /// Date the ticket was issued.
    /// </summary>
    public IsoISODate? TicketIssueDate { get; init; } 
    /// <summary>
    /// Location where ticket was issued.
    /// </summary>
    public IsoMax140Text? TicketIssueLocation { get; init; } 
    /// <summary>
    /// Number of a ticket that contains additional coupons for an itinerary that contains more than four segments. 
    /// </summary>
    public IsoMax35Text? ConjunctionTicketNumber { get; init; } 
    /// <summary>
    /// Indicates whether or not restrictions apply to the ticket.
    /// True = Restrictions apply
    /// False = Restrictions do not apply
    /// </summary>
    public IsoTrueFalseIndicator? RestrictedTicketIndicator { get; init; } 
    /// <summary>
    /// Indicates whether or not the ticket is open-ended. 
    /// True = Ticket is open-ended
    /// False = Ticket is not open-ended
    /// </summary>
    public IsoTrueFalseIndicator? OpenTicketIndicator { get; init; } 
    /// <summary>
    /// Contains the specific restriction applicable to the ticket.
    /// </summary>
    public IsoMax70Text? Restrictions { get; init; } 
    /// <summary>
    /// Indicates whether or not the ticket was exchanged (reissued or new ticket generated). 
    /// True = Ticket was exchanged
    /// False = Ticket was not exchanged
    /// </summary>
    public IsoTrueFalseIndicator? ExchangedTicketIndicator { get; init; } 
    /// <summary>
    /// Contains the original ticket number that was replaced by the new ticket number. 
    /// </summary>
    public IsoMax35Text? ExchangedTicketNumber { get; init; } 
    /// <summary>
    /// Ticket record locator number.
    /// </summary>
    public IsoMax35Text? RecordLocatorNumber { get; init; } 
    /// <summary>
    /// Reservation number or identifier. 
    /// </summary>
    public ReservationDetails3? Reservation { get; init; } 
    
    #nullable disable
}
