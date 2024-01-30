﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TravelAgency2.  ISO2002 ID# _H51h0_PdEeihCvvpsmGI2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Travel agency component provides details of travel agency, airline, or railway transactions. 
/// </summary>
public partial record TravelAgency2
{
    #nullable enable
    
    /// <summary>
    /// Information describing the travel agency or party providing travel-related services. 
    /// </summary>
    public PartyIdentification207? Company { get; init; } 
    /// <summary>
    /// Provides detailed information about the travel package, excluding specific itinerary data. 
    /// </summary>
    public TravelAgencyPackage1? TravelPackage { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional travel details.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}
