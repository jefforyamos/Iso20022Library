﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IsabelEnhancedHeader1.  ISO2002 ID# _wsbQIMmJEeWAGphE2LvqeA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the enhanced parameters for an Isabel payment file.
/// </summary>
public partial record IsabelEnhancedHeader1
{
    #nullable enable
    
    /// <summary>
    /// Type of debit to be applied to the payment, as provided by the end-user.
    /// </summary>
    public required DebitType1Code DebitType { get; init; } 
    /// <summary>
    /// Type of debit to be applied to the payment, as provided by the bank.
    /// This may supersede the debit type provided by the end-user.
    /// </summary>
    public required DebitType1Code BankDebitType { get; init; } 
    /// <summary>
    /// Contract is defined on a specific account.
    /// </summary>
    public required IsoTrueFalseIndicator AccountBasedContract { get; init; } 
    /// <summary>
    /// Results of all validations performed during the processing of a file provided in the payload.
    /// </summary>
    public required Validation1Code ValidationResults { get; init; } 
    /// <summary>
    /// Results of the signature validation provided by the 'PowerToSign' user.
    /// </summary>
    public required Validation2Code PowerToSignValidationResults { get; init; } 
    /// <summary>
    /// Validation of the time stamp provided by the 'PowerToSign' user.
    /// </summary>
    public required IsoISODateTime PowerToSignValidationTimeStamp { get; init; } 
    /// <summary>
    /// Trigger used by the sender to transfer the file.
    /// </summary>
    public required IsabelSenderTrigger1Choice_ SenderTrigger { get; init; } 
    /// <summary>
    /// Time stamp on when the file is sent.
    /// </summary>
    public required IsoISODateTime SendTimeStamp { get; init; } 
    /// <summary>
    /// Indicates whether extra conditions are applicable and accepted for this file.
    /// </summary>
    public required IsoTrueFalseIndicator ExtraConditionsAccepted { get; init; } 
    /// <summary>
    /// Input source for the generation of the file.
    /// </summary>
    public required IsabelInputSource1Choice_ Source { get; init; } 
    /// <summary>
    /// Number of signatures required to validate the payments file.
    /// </summary>
    public IsoNumber? NumberOfRequiredSignatures { get; init; } 
    /// <summary>
    /// Extended parameters for an Isabel payment initiation file.
    /// </summary>
    public IsabelExtendedHeader1? Extended { get; init; } 
    
    #nullable disable
}
