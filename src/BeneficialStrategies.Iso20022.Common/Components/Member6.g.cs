﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Member6.  ISO2002 ID# _W1ihMXSeEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the members of a system.
/// </summary>
public partial record Member6
{
    #nullable enable
    
    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example, returns or rejects.
    /// </summary>
    public IMemberIdentification3Choice? MemberReturnAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Person to be contacted in a given organisation.
    /// </summary>
    public ContactIdentificationAndAddress1? ContactReference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    public CommunicationAddress8? CommunicationAddress { get; init; } 
    
    #nullable disable
}
