﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProtectInstruction2.  ISO2002 ID# _-0arNrpREeilsanBGAzy4A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on protect and cover protect instructions.
/// </summary>
public partial record ProtectInstruction2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    public required ProtectTransactionType2Code TransactionType { get; init; } 
    /// <summary>
    /// Status of the protect transaction.
    /// </summary>
    public ProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; } 
    /// <summary>
    /// Unique reference of the protect transaction assigned by the depository and used for cover protect validation.
    /// </summary>
    public IsoMax15Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Account which submitted the original protect instruction used for cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account.
    /// </summary>
    public IsoMax35Text? ProtectSafekeepingAccount { get; init; } 
    /// <summary>
    /// Date at which the protect instruction was created and used for cover protect validation.
    /// </summary>
    public IsoISODate? ProtectDate { get; init; } 
    /// <summary>
    /// Remaining quantity of protect instruction which has not been covered.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? UncoveredProtectQuantity { get; init; } 
    
    #nullable disable
}
