﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsParticipantRange1.  ISO2002 ID# _VEBnQI0UEemUAO64Q252gQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the participants with the highest volume and value ranking for settlement fails.
/// </summary>
public partial record SettlementFailsParticipantRange1
{
    #nullable enable
    
    /// <summary>
    /// Participant with the highest volume of settlement fails.
    /// </summary>
    public SettlementFailsParticipant1? HighestInVolume { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Participant with the highest value of settlement fails.
    /// </summary>
    public SettlementFailsParticipant1? HighestInValue { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
