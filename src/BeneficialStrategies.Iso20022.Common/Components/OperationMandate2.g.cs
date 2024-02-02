﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OperationMandate2.  ISO2002 ID# _a6CSAQ4aEeKGXqvMN6jpiw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specifying the Mandate.
/// </summary>
[DataContract]
[XmlType]
public partial record OperationMandate2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the mandate.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Channel for which the operation mandate is valid. If ApplicableChannel equals Fax, this means that a bank operation instruction sent by fax will be processed according to the mandates exchanged in this message.
    /// </summary>
    [DataMember]
    public ValueList<Channel2Choice_> ApplicableChannel { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Number of required and necessary signatures by the mandate.
    /// </summary>
    [DataMember]
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; } 
    /// <summary>
    /// Indicator whether a certain order of signatures has to be respected or not.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; } 
    /// <summary>
    /// Holder of the mandate.
    /// </summary>
    [DataMember]
    public ValueList<PartyAndAuthorisation1> MandateHolder { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Bank operation allowed by a mandate.
    /// </summary>
    [DataMember]
    public ValueList<BankTransactionCodeStructure4> BankOperation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Is the date when the mandate becomes valid.
    /// </summary>
    [DataMember]
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Is the date when the mandate stops to be valid.
    /// </summary>
    [DataMember]
    public IsoISODate? EndDate { get; init; } 
    
    #nullable disable
}
