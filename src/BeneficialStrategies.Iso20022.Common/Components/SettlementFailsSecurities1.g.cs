﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsSecurities1.  ISO2002 ID# _Bnkxd40bEemUAO64Q252gQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the settlement fails and the ranking for a specific financial instrument.
/// </summary>
public partial record SettlementFailsSecurities1
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Ranking of the top financial instruments with the highest rate of settlement fails.
    /// </summary>
    public required IsoMax2NumericText Rank { get; init; } 
    
    #nullable disable
}
