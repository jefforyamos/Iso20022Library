﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation6.  ISO2002 ID# _QNJpMNp-Ed-ak6NoX_4Aeg_-756944744.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information which describes the organisation.
/// </summary>
public partial record Organisation6
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text FullLegalName { get; init; } 
    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    public IsoMax350Text? TradingName { get; init; } 
    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    public required CountryCode CountryOfOperation { get; init; } 
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    public IsoISODate? RegistrationDate { get; init; } 
    /// <summary>
    /// Is an operational address, for example, of a shared services center.
    /// </summary>
    public PostalAddress6? OperationalAddress { get; init; } 
    /// <summary>
    /// Is the address where the business activity is taking place.
    /// </summary>
    public PostalAddress6? BusinessAddress { get; init; } 
    /// <summary>
    /// Is the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    public required PostalAddress6 LegalAddress { get; init; } 
    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    /// <summary>
    /// Person in the customer's organisation who can be contacted by the account servicer.
    /// </summary>
    public PartyIdentification40[] RepresentativeOfficer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the person responsible of the treasury department within an organisation.
    /// </summary>
    public PartyIdentification40? TreasuryManager { get; init; } 
    /// <summary>
    /// Is the main mandate holder that will delegate some authority to other individuals (mandate holders) to perform some specific bank operations on the account.
    /// </summary>
    public PartyIdentification40[] MainMandateHolder { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Potential sender of a message related to the life cyle of an account.
    /// </summary>
    public PartyIdentification40[] Sender { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
