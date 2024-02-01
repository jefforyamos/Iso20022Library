﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService15.  ISO2002 ID# _-C7vwa4VEeW_TaP-ygI0SQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry service provided by the ATM inside the session.
/// </summary>
public partial record ATMService15
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the withdrawal service provided by the ATM inside the session.
    /// </summary>
    public IsoMax35Text? ServiceReference { get; init; } 
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    public IsoMax35Text? ATMServiceCode { get; init; } 
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    public required ATMServiceType3Code ServiceType { get; init; } 
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    public IsoMax35Text[] ServiceVariantIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
