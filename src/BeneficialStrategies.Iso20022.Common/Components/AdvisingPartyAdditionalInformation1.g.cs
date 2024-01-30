﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdvisingPartyAdditionalInformation1.  ISO2002 ID# _GBqPw34hEeG2Zfa6JvOQSQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information related to the advising party.
/// </summary>
public partial record AdvisingPartyAdditionalInformation1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned as a reference.
    /// </summary>
    public IsoMax35Text? ReferenceNumber { get; init; } 
    /// <summary>
    /// Additional information specific to the bank-to-beneficiary communication.
    /// </summary>
    // public IReadOnlyCollection<IsoMax2000Text> BankToBeneficiaryInformation { get; init; }
    
    #nullable disable
}
