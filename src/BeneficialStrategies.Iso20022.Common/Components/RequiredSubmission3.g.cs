﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequiredSubmission3.  ISO2002 ID# _Rax58tp-Ed-ak6NoX_4Aeg_-1897093654.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of the insurance data set.
/// </summary>
public partial record RequiredSubmission3
{
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    public BICIdentification1? Submitter { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies if the issuer must be matched as part of the validation of the data set.
    /// </summary>
    public PartyIdentification27? MatchIssuer { get; init; } 
    /// <summary>
    /// Specifies if the issue date must be matched as part of the validation of the data set.
    /// </summary>
    public required IsoYesNoIndicator MatchIssueDate { get; init; } 
    /// <summary>
    /// Specifies if the transport information must be matched as part of the validation of the data set.
    /// </summary>
    public required IsoYesNoIndicator MatchTransport { get; init; } 
    /// <summary>
    /// Specifies if the insured amount must be matched as part of the validation of the data set.
    /// </summary>
    public required IsoYesNoIndicator MatchAmount { get; init; } 
    /// <summary>
    /// Specifies which clauses are required in the insurance data set.
    /// </summary>
    public InsuranceClauses1Code? ClausesRequired { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies if the assured (insured) party must be matched as part of the validation of the data set.
    /// </summary>
    public AssuredType1Code? MatchAssuredParty { get; init; } 
    
    #nullable disable
}
