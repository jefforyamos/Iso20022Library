﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsData3.  ISO2002 ID# _afLKcR2lEeqF2P5v-Rtejg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data of settlement fails instructions.
/// </summary>
public partial record SettlementFailsData3
{
    #nullable enable
    
    /// <summary>
    /// Total of all types of settlement transactions.
    /// </summary>
    public required SettlementTotalData1 Total { get; init; } 
    /// <summary>
    /// Further details on the central securities depositories participants with the highest rates of settlement fails.
    /// </summary>
    public SettlementFailsParticipantRange1? ParticipantInFail { get; init; } 
    /// <summary>
    /// Further details on the settlement fails per currency.
    /// </summary>
    public SettlementFailsCurrency2? FailsPerCurrency { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details on the settlement fails per financial instrument type.
    /// </summary>
    public SettlementFailsInstrument2? FailsPerFinancialInstrumentType { get; init; } 
    /// <summary>
    /// Further details on the securities with the highest rates of settlement fails.
    /// </summary>
    public SettlementFailsSecuritiesRange1? SecuritiesInFail { get; init; } 
    /// <summary>
    /// Further details on the settlement fails per transaction type.
    /// </summary>
    public SettlementFailsTransactionType2? FailsPerTransactionType { get; init; } 
    /// <summary>
    /// Total of all types of settlement penalties (such as total of late matching and settlement fails).
    /// </summary>
    public SettlementDataVolume2? TotalSettlementPenalties { get; init; } 
    /// <summary>
    /// Further details on the reason for the settlement fails.
    /// </summary>
    public required SettlementFailureReason3 FailureReason { get; init; } 
    
    #nullable disable
}
