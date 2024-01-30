﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Group3.  ISO2002 ID# _D1xVkW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of parties with their related security certificate.
/// </summary>
public partial record Group3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    public Modification1Code? ModificationCode { get; init; } 
    /// <summary>
    /// Specifies the identification of the group.
    /// </summary>
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; } 
    /// <summary>
    /// Specifies a party and related certificate.
    /// </summary>
    public PartyAndCertificate5? Party { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
