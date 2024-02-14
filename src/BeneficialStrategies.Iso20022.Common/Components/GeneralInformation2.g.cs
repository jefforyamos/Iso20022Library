﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralInformation2.  ISO2002 ID# _S8KT9gEcEeCQm6a_G2yO_w_1137960838.
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
[IsoId("_S8KT9gEcEeCQm6a_G2yO_w_1137960838")]
[DisplayName("General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralInformation2
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
    [IsoId("_S8KT9wEcEeCQm6a_G2yO_w_1024121772")]
    [DisplayName("Block Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckInd")]
    #endif
    [IsoXmlTag("BlckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BlockIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockIndicator { get; init; } 
    #else
    public System.String? BlockIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a preceeding transaction, for example, an option or swap.
    /// </summary>
    [IsoId("_S8KT-AEcEeCQm6a_G2yO_w_27049419")]
    [DisplayName("Related Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdTradRef")]
    #endif
    [IsoXmlTag("RltdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
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
    [IsoId("_S8KT-QEcEeCQm6a_G2yO_w_-970022934")]
    [DisplayName("Dealing Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgMtd")]
    #endif
    [IsoXmlTag("DealgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Trading1MethodCode? DealingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Trading1MethodCode? DealingMethod { get; init; } 
    #else
    public Trading1MethodCode? DealingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Broker that arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    [IsoId("_S8KT-gEcEeCQm6a_G2yO_w_-1967095287")]
    [DisplayName("Broker Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrId")]
    #endif
    [IsoXmlTag("BrkrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification19Choice_? BrokerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_? BrokerIdentification { get; init; } 
    #else
    public PartyIdentification19Choice_? BrokerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Counterparty&apos;s reference for the trade.
    /// </summary>
    [IsoId("_S8KT-wEcEeCQm6a_G2yO_w_1330799656")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
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
    [IsoId("_S8KT_AEcEeCQm6a_G2yO_w_333727303")]
    [DisplayName("Brokers Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrsComssn")]
    #endif
    [IsoXmlTag("BrkrsComssn")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? BrokersCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? BrokersCommission { get; init; } 
    #else
    public System.Decimal? BrokersCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies additional information for the receiver.
    /// </summary>
    [IsoId("_S8KT_QEcEeCQm6a_G2yO_w_-586306349")]
    [DisplayName("Sender To Receiver Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrToRcvrInf")]
    #endif
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SenderToReceiverInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderToReceiverInformation { get; init; } 
    #else
    public System.String? SenderToReceiverInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_S8KT_gEcEeCQm6a_G2yO_w_1099683553")]
    [DisplayName("Dealing Branch Trading Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgBrnchTradgSd")]
    #endif
    [IsoXmlTag("DealgBrnchTradgSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification19Choice_? DealingBranchTradingSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_? DealingBranchTradingSide { get; init; } 
    #else
    public PartyIdentification19Choice_? DealingBranchTradingSide { get; set; } 
    #endif
    
    /// <summary>
    /// Branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_S8KT_wEcEeCQm6a_G2yO_w_102611200")]
    [DisplayName("Dealing Branch Counterparty Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgBrnchCtrPtySd")]
    #endif
    [IsoXmlTag("DealgBrnchCtrPtySd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification19Choice_? DealingBranchCounterpartySide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification19Choice_? DealingBranchCounterpartySide { get; init; } 
    #else
    public PartyIdentification19Choice_? DealingBranchCounterpartySide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the name and/or electronic address of the the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    [IsoId("_S8KUAAEcEeCQm6a_G2yO_w_-894461153")]
    [DisplayName("Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctInf")]
    #endif
    [IsoXmlTag("CtctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactInformation1? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactInformation1? ContactInformation { get; init; } 
    #else
    public ContactInformation1? ContactInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
