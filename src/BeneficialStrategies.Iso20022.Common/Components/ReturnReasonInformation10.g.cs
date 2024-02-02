﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReturnReasonInformation10.  ISO2002 ID# _TP6PlNp-Ed-ak6NoX_4Aeg_1913342073.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the return of the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record ReturnReasonInformation10
{
    #nullable enable
    
    /// <summary>
    /// Bank transaction code included in the original entry for the transaction.
    /// </summary>
    [DataMember]
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; init; } 
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [DataMember]
    public PartyIdentification32? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [DataMember]
    public ReturnReason5Choice_? Reason { get; init; } 
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
