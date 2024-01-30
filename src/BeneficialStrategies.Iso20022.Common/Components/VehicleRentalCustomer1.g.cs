﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VehicleRentalCustomer1.  ISO2002 ID# _fx0Cj_SsEeife6veM7daYw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer renting a vehicle.
/// </summary>
public partial record VehicleRentalCustomer1
{
    #nullable enable
    
    /// <summary>
    /// Name of the vehicle rental customer.
    /// </summary>
    public required IsoMax70Text RenterName { get; init; } 
    /// <summary>
    /// Corporate name of the vehicle rental customer.
    /// </summary>
    public IsoMax70Text? CorporateName { get; init; } 
    /// <summary>
    /// Corporate identifier of the vehicle rental customer.
    /// </summary>
    public required IsoMax35Text CorporateIdentifier { get; init; } 
    /// <summary>
    /// Party assigning an identification to a vehicle rental customer.
    /// </summary>
    public CustomerAssigner1Code? Assigner { get; init; } 
    /// <summary>
    /// Vehicle rental driver.
    /// </summary>
    public DriverInParty1? PrimaryDriver { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of identification of the additional vehicle rental customer.
    /// </summary>
    public DriverInParty1? AdditionalDriver { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    
    #nullable disable
}
