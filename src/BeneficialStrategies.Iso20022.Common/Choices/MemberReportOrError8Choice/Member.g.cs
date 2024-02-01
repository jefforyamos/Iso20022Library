﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Member.  ISO2002 ID# _fSe1UdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError8Choice;

/// <summary>
/// Requested member data when found in the system.
/// </summary>
public partial record Member : MemberReportOrError8Choice_
{
    #nullable enable
    /// <summary>
    /// Word by which something is called or known or the family name of a person.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
    /// </summary>
    public MemberIdentification3Choice_? ReturnAddress { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccount40? Account { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    public SystemMemberType1Choice_? Type { get; init; } 
    /// <summary>
    /// Status of a member in a system, for example enabled or deleted.
    /// </summary>
    public SystemMemberStatus1Choice_? Status { get; init; } 
    /// <summary>
    /// Person to be contacted in a given organisation.
    /// </summary>
    public ContactIdentificationAndAddress2? ContactReference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    public CommunicationAddress10? CommunicationAddress { get; init; } 
    #nullable disable
}
