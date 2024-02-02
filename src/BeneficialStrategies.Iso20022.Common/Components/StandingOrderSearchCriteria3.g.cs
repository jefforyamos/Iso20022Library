﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StandingOrderSearchCriteria3.  ISO2002 ID# _GWGH2W4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for standing orders defined within the system.
/// </summary>
[DataContract]
[XmlType]
public partial record StandingOrderSearchCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the key fields or business attributes defined within the system must be returned.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? KeyAttributesIndicator { get; init; } 
    /// <summary>
    /// Unique identification to unambiguously identify the standing order used to initiate the liquidity transfer.
    /// </summary>
    [DataMember]
    public IsoMax35Text? StandingOrderIdentification { get; init; } 
    /// <summary>
    /// Type of the standing order.
    /// </summary>
    [DataMember]
    public StandingOrderType1Choice_? Type { get; init; } 
    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [DataMember]
    public CashAccount38? Account { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [DataMember]
    public DatePeriod2Choice_? ValidityPeriod { get; init; } 
    /// <summary>
    /// Specifies if the account is debited or credited by the standing order.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification6? SystemMember { get; init; } 
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification6? ResponsibleParty { get; init; } 
    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [DataMember]
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; } 
    /// <summary>
    /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
    /// </summary>
    [DataMember]
    public IsoMax35Text? LinkSetIdentification { get; init; } 
    /// <summary>
    /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
    /// </summary>
    [DataMember]
    public IsoMax35Text? LinkSetOrderIdentification { get; init; } 
    /// <summary>
    /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
    /// </summary>
    [DataMember]
    public IsoNumber? LinkSetOrderSequence { get; init; } 
    /// <summary>
    /// Indicates whether the query shall return all liquidity transfer standing orders defined as zero sweeping orders.
    /// When the indicator is set to true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; } 
    
    #nullable disable
}
