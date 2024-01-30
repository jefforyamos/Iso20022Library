﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService23.  ISO2002 ID# _o9gH8a4yEeWpsoxRhdX-8A.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry service provided by the ATM inside the session.
/// </summary>
public partial record ATMService23
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
    /// Codification of the type of service for the host.
    /// </summary>
    public IsoMax35Text? HostServiceCode { get; init; } 
    /// <summary>
    /// Describes the type of fund transfer selected by the customer or the ATM.
    /// </summary>
    public required ATMServiceType9Code ServiceType { get; init; } 
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    public IsoMax35Text? ServiceVariantIdentification { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
