﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionInstructionDetails8.  ISO2002 ID# _pf87HTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructions information received for a given option.
/// </summary>
public partial record OptionInstructionDetails8
{
    #nullable enable
    
    /// <summary>
    /// Identifies the instruction or protect instruction.
    /// </summary>
    public required IsoRestrictedFINMax15Text InstructionIdentification { get; init; } 
    /// <summary>
    /// Provides the sequence number of the instruction.
    /// </summary>
    public IsoMax3NumericText? InstructionSequenceNumber { get; init; } 
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    public ProtectTransactionType2Code? ProtectIndicator { get; init; } 
    /// <summary>
    /// Securities quantity instructed in the instruction.
    /// </summary>
    public required FinancialInstrumentQuantity36Choice_ InstructionQuantity { get; init; } 
    /// <summary>
    /// Date of the instruction.
    /// </summary>
    public required IsoISODate InstructionDate { get; init; } 
    /// <summary>
    /// Date of the client protect instruction.
    /// </summary>
    public IsoISODate? ProtectDate { get; init; } 
    /// <summary>
    /// Date of the cover protect Instruction
    /// </summary>
    public IsoISODate? CoverProtectDate { get; init; } 
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    public PriceFormat57Choice_? BidPrice { get; init; } 
    /// <summary>
    /// Conditional quantity of the instruction.
    /// </summary>
    public FinancialInstrumentQuantity36Choice_? ConditionalQuantity { get; init; } 
    /// <summary>
    /// Customer related narrative information.
    /// </summary>
    public IsoRestrictedFINMax50Text? CustomerReference { get; init; } 
    /// <summary>
    /// Narrative information from the submitted instruction.
    /// </summary>
    public IsoRestrictedFINXMax350Text? InstructionNarrative { get; init; } 
    /// <summary>
    /// Status of a particular instruction.
    /// </summary>
    public required InstructionProcessingStatus48Choice_ InstructionStatus { get; init; } 
    
    #nullable disable
}
