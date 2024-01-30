﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Member4.  ISO2002 ID# _jEyVlZlCEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the members of a system.
/// </summary>
public partial record Member4
{
    #nullable enable
    
    /// <summary>
    /// Word by which something is called or known or the family name of a person.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
    /// </summary>
    public IMemberIdentification2Choice? ReturnAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccount24? Account { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    public MemberType1Code? Type { get; init; } 
    /// <summary>
    /// Status of a member in a system, for example enabled or deleted.
    /// </summary>
    public MemberStatus1Code? Status { get; init; } 
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
