﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption58.  ISO2002 ID# _c30Qe5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesOption58
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [DataMember]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [DataMember]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [DataMember]
    public required Quantity10Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [DataMember]
    public required DateAndDateTimeChoice_ PostingDate { get; init; } 
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? OriginalPostingDate { get; init; } 
    
    #nullable disable
}
