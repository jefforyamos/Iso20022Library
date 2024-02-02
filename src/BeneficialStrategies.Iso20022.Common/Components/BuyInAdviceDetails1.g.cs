﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BuyInAdviceDetails1.  ISO2002 ID# _fGNv0ZwREeqtp-LOti013g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a buy-in.
/// </summary>
[DataContract]
[XmlType]
public partial record BuyInAdviceDetails1
{
    #nullable enable
    
    /// <summary>
    /// References of the failing transaction.
    /// </summary>
    [DataMember]
    public required References23 Reference { get; init; } 
    /// <summary>
    /// Status of the buy-in transaction.
    /// </summary>
    [DataMember]
    public required BuyInState1Code BuyInState { get; init; } 
    /// <summary>
    /// Specifies if the buy-in transaction was deferred or not.
    /// </summary>
    [DataMember]
    public required BuyInDeferral1Code BuyInDeferral { get; init; } 
    /// <summary>
    /// Identification of the financial instrument of the buy-in instruction.
    /// </summary>
    [DataMember]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument concerned by the buy-in transaction.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    /// <summary>
    /// Price of the traded financial instrument in the buy-in transaction.
    /// </summary>
    [DataMember]
    public RateAndAmountFormat39Choice_? BuyInPrice { get; init; } 
    /// <summary>
    /// Amount of money that has to be paid by the failing trading party in case of an unsuccessful or partially successful buy-in transaction.
    /// </summary>
    [DataMember]
    public AmountAndDirection102? CashCompensationAmount { get; init; } 
    /// <summary>
    /// Settlement date of the buy-in. 
    /// </summary>
    [DataMember]
    public DateAndDateTime2Choice_? BuyInSettlementDate { get; init; } 
    
    #nullable disable
}
