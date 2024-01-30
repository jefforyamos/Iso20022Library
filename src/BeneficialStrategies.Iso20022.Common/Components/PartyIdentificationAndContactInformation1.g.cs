﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndContactInformation1.  ISO2002 ID# _Pb-D5Np-Ed-ak6NoX_4Aeg_196982310.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person, or a non-financial institution.
/// </summary>
public partial record PartyIdentificationAndContactInformation1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification8 PartyIdentification { get; init; } 
    /// <summary>
    /// Information needed to contact a physical person related to the party, such as name, phone number, email address.
    /// </summary>
    public ContactIdentification1? ContactInformation { get; init; } 
    
    #nullable disable
}
