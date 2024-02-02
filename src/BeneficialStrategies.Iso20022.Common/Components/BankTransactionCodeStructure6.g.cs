﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BankTransactionCodeStructure6.  ISO2002 ID# _TVRQu9p-Ed-ak6NoX_4Aeg_1515822708.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the type or operations code of a transaction entry.
/// </summary>
[DataContract]
[XmlType]
public partial record BankTransactionCodeStructure6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the family within a domain.
    /// </summary>
    [DataMember]
    public required ExternalBankTransactionFamily1Code Code { get; init; } 
    /// <summary>
    /// Specifies the sub-product family within a specific family.
    /// </summary>
    [DataMember]
    public required ExternalBankTransactionSubFamily1Code SubFamilyCode { get; init; } 
    
    #nullable disable
}
