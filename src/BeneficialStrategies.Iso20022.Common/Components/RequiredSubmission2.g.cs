﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequiredSubmission2.  ISO2002 ID# _Rax58Np-Ed-ak6NoX_4Aeg_1462344534.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of a data set.
/// </summary>
public partial record RequiredSubmission2
{
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    public BICIdentification1? Submitter { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
