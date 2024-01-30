﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService5.  ISO2002 ID# _ltY8kYqvEeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry service provided by the ATM inside the session.
/// </summary>
public partial record ATMService5
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
    
    #nullable disable
}
