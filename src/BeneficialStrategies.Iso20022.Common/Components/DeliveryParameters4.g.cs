﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliveryParameters4.  ISO2002 ID# _T6hS0tp-Ed-ak6NoX_4Aeg_177856099.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of a physical delivery.
/// </summary>
public partial record DeliveryParameters4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the address for the physical delivery is the registered address.
    /// </summary>
    public required IsoYesNoIndicator RegisteredAddressIndicator { get; init; } 
    /// <summary>
    /// Name and address to/from which the physical delivery/receipt of the financial instrument must take place.
    /// </summary>
    public NameAndAddress4? NameAndAddress { get; init; } 
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    public ContactIdentification2? ContactPerson { get; init; } 
    
    #nullable disable
}
