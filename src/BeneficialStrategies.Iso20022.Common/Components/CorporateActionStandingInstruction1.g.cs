﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionStandingInstruction1.  ISO2002 ID# _UJbRidp-Ed-ak6NoX_4Aeg_852863952.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the standing instruction.
/// </summary>
public partial record CorporateActionStandingInstruction1
{
    #nullable enable
    
    /// <summary>
    /// Identifies whether the account Holders want their income to be paid net or gross of income tax (default is gross).
    /// </summary>
    public required StandingInstructionGrossNet1Code NetOrGross { get; init; } 
    /// <summary>
    /// Provides information about the cash distribution standing instruction.
    /// </summary>
    public required CashAccount17 CashDistributionDetails { get; init; } 
    /// <summary>
    /// Provides information about the securities distribution standing instruction.
    /// </summary>
    public required SecuritiesAccount6 SecuritiesDistributionDetails { get; init; } 
    /// <summary>
    /// Additional information about the standing instruction.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
