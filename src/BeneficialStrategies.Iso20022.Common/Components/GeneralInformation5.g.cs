﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralInformation5.  ISO2002 ID# _KAWoEZUVEea7vKctaoIyEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the negotiation process leading to a treasury trade.
/// </summary>
[IsoId("_KAWoEZUVEea7vKctaoIyEQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("General Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralInformation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is a block or single trade.
    /// </summary>
    [IsoId("_KNwx8ZUVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Block Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BlockIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockIndicator { get; init; } 
    #else
    public System.String? BlockIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a preceding transaction, for example, an option or swap.
    /// </summary>
    [IsoId("_KNwx85UVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Trade Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedTradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedTradeReference { get; init; } 
    #else
    public System.String? RelatedTradeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Method used by the trading parties to negotiate and/or execute a deal.
    /// </summary>
    [IsoId("_KNwx9ZUVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Trading1MethodCode? DealingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Trading1MethodCode? DealingMethod { get; init; } 
    #else
    public Trading1MethodCode? DealingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the broker which arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    [IsoId("_KNwx95UVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Broker Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? BrokerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? BrokerIdentification { get; init; } 
    #else
    public PartyIdentification73Choice_? BrokerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Counterparty's reference for the trade.
    /// </summary>
    [IsoId("_KNwx-ZUVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CounterpartyReference { get; init; } 
    #else
    public System.String? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage fee for a broker confirmation.
    /// </summary>
    [IsoId("_KNwx-5UVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Brokers Commission")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? BrokersCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? BrokersCommission { get; init; } 
    #else
    public System.Decimal? BrokersCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies additional information for the receiver and applies to the whole message.
    /// </summary>
    [IsoId("_KNwx_ZUVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sender To Receiver Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? SenderToReceiverInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderToReceiverInformation { get; init; } 
    #else
    public System.String? SenderToReceiverInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the branch at the trading side with which the deal was done.
    /// </summary>
    [IsoId("_KNwx_5UVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Branch Trading Side")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? DealingBranchTradingSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? DealingBranchTradingSide { get; init; } 
    #else
    public PartyIdentification73Choice_? DealingBranchTradingSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_KNwyAZUVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Branch Counterparty Side")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? DealingBranchCounterpartySide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? DealingBranchCounterpartySide { get; init; } 
    #else
    public PartyIdentification73Choice_? DealingBranchCounterpartySide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the name and/or electronic address of the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    [IsoId("_KNwyA5UVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contact Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactInformation1? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactInformation1? ContactInformation { get; init; } 
    #else
    public ContactInformation1? ContactInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type, date and version of the agreement used in a trade.
    /// </summary>
    [IsoId("_VTM1UJUVEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agreement Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreementConditions1? AgreementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreementConditions1? AgreementDetails { get; init; } 
    #else
    public AgreementConditions1? AgreementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the year of definitions of the agreement.
    /// </summary>
    [IsoId("_k1X30JUXEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Definitions Year")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYear? DefinitionsYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? DefinitionsYear { get; init; } 
    #else
    public System.UInt16? DefinitionsYear { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a reference applied to the trade instruction by a broker.
    /// </summary>
    [IsoId("_ntBk8JUYEea7vKctaoIyEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Brokers Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BrokersReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BrokersReference { get; init; } 
    #else
    public System.String? BrokersReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
