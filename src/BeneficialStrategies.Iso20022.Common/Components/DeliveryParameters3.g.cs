﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliveryParameters3.  ISO2002 ID# _T6YI7tp-Ed-ak6NoX_4Aeg_152223563.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of a physical delivery.
/// </summary>
public partial record DeliveryParameters3
{
    #nullable enable
    
    /// <summary>
    /// Address for physical delivery.
    /// </summary>
    public required NameAndAddress4 Address { get; init; } 
    /// <summary>
    /// Certificate representing a security that is delivered.
    /// </summary>
    public IsoMax35Text? IssuedCertificateNumber { get; init; } 
    
    #nullable disable
}
