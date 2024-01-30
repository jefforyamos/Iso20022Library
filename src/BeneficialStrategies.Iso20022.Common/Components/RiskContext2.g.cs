﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RiskContext2.  ISO2002 ID# _VFt7wcStEeuBjv5G5kw00g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the risk associated with the transaction.
/// </summary>
public partial record RiskContext2
{
    #nullable enable
    
    /// <summary>
    /// Input data to be considered in a risk assessment.
    /// </summary>
    public RiskInputData1? RiskInputData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates to the card issuer the level of risk associated with the transaction.
    /// </summary>
    public RiskAssessment2? RiskAssessment { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
