﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationSearchCriteria3.  ISO2002 ID# _ELOLu24-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a reservation.
/// </summary>
public partial record ReservationSearchCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public ISystemIdentification2Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Type of reservation as set by default in the system. The default reservation is applicable by the system unless otherwise instructed.
    /// </summary>
    public ReservationType1Code? DefaultReservationType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of reservation applied by the system at the present time.
    /// </summary>
    public ReservationType1Code? CurrentReservationType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? AccountIdentification { get; init; } 
    
    #nullable disable
}
