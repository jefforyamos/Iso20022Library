﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReorganisationInstructionDetailsSD4.  ISO2002 ID# _dbQNhcY1EeesocHIuVGr7g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action reorganisation instruction details.
/// </summary>
public partial record ReorganisationInstructionDetailsSD4
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Identifies the reorganisation withdrawal transaction type.
    /// </summary>
    public ReorganisationWithdrawalTransactionType1Code? WithdrawalTransactionType { get; init; } 
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    public IsoMax15Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; } 
    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    public DTCProtectInstructionStatus1Code? ProtectTransactionStatus { get; init; } 
    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is rejected.
    /// </summary>
    public InstructionRejectionReason1Code[] RejectionReason { get; init; } = [];
    /// <summary>
    /// Identifies the protect itself or of that is being covered. It is required for the function types cover protect (COVR), cover protect directly to agent (COVA) and cover on behalf of another participant (COVP).
    /// </summary>
    public required IsoMax15Text ProtectIdentification { get; init; } 
    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public SecuritiesQuantityDetailsSD4? SecuritiesQuantityDetails { get; init; } 
    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    public ContactIdentification5? ContactPerson { get; init; } 
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    /// <summary>
    /// Transaction record number for ATAM or ART system which may be causing pending status. Corresponds to ATP RBN number.
    /// </summary>
    public IsoMax10NumericText? TransactionRecordNumber { get; init; } 
    
    #nullable disable
}
