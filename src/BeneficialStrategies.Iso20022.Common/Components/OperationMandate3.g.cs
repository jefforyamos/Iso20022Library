﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OperationMandate3.  ISO2002 ID# _QCGs4Q4fEeK3IMoVvcTkkg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specifying the Mandate.
/// </summary>
public partial record OperationMandate3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    public Modification1Code? ModificationCode { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the mandate.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Channel for which the operation mandate is valid. If ApplicableChannel equals Fax, this means that a bank operation instruction sent by fax will be processed according to the mandates exchanged in this message.
    /// </summary>
    public Channel2Choice_[] ApplicableChannel { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Number of required and necessary signatures by the mandate.
    /// </summary>
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; } 
    /// <summary>
    /// Indicator whether a certain order of signatures has to be respected or not.
    /// </summary>
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; } 
    /// <summary>
    /// Holder of the mandate.
    /// </summary>
    public PartyAndAuthorisation3[] MandateHolder { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Bank operation allowed by a mandate.
    /// </summary>
    public BankTransactionCodeStructure4[] BankOperation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Is the date when the mandate becomes valid.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Is the date when the mandate stops to be valid.
    /// </summary>
    public IsoISODate? EndDate { get; init; } 
    
    #nullable disable
}
