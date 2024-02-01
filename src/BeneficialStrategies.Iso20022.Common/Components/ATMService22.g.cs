﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService22.  ISO2002 ID# _obPXIa4sEeWLdt0vLARX2Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry service provided by the ATM inside the session.
/// </summary>
public partial record ATMService22
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the transfer is performed.
    /// </summary>
    public IsoMax35Text? ServiceReference { get; init; } 
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    public IsoMax35Text? ATMServiceCode { get; init; } 
    /// <summary>
    /// Describes the type of fund transfer selected by the customer or the ATM.
    /// </summary>
    public required ATMServiceType9Code ServiceType { get; init; } 
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    public IsoMax35Text[] ServiceVariantIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
