﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInformation17.  ISO2002 ID# _dqcAheLxEeWOD7aAy2fAcA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement of the securities in a securities transaction, that is, the instruction to deliver or receive securities, involving the payment of an amount of money or not.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementInformation17
{
    #nullable enable
    
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [DataMember]
    public SettlementUnitType3Choice_? SecuritiesQuantityType { get; init; } 
    /// <summary>
    /// Specifies when the contract (i.e. MBS/TBA) will settle.
    /// </summary>
    [DataMember]
    public IsoISOYearMonth? ContractSettlementMonth { get; init; } 
    /// <summary>
    /// Indicates the minimum quantity (unit or nominal) of a security.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; init; } 
    /// <summary>
    /// Minimum multiple quantity (unit or nominal) of securities.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1Choice_? MinimumMultipleQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [DataMember]
    public ValueList<FinancialInstrumentQuantity1Choice_> DeviatingSettlementUnit { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
