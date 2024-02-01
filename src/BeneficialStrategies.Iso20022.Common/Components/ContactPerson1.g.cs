﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContactPerson1.  ISO2002 ID# _QDnStdp-Ed-ak6NoX_4Aeg_-2124213178.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information about the contact responsible for the transaction identified in the message.
/// </summary>
public partial record ContactPerson1
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information regarding the party, eg, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public required ContactIdentification4 ContactPerson { get; init; } 
    /// <summary>
    /// Identification of the institution that the contact person represents.
    /// </summary>
    public PartyIdentification2Choice_? InstitutionIdentification { get; init; } 
    
    #nullable disable
}
