﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessingCharacteristics6.  ISO2002 ID# _jUZEwV84Eeicg40_9gK9vQ.
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
/// Processing characteristics linked to a switch order for an investment fund or alternative/hedge fund.
/// </summary>
[IsoId("_jUZEwV84Eeicg40_9gK9vQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Processing Characteristics")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingCharacteristics6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency in which a switch is accepted.
    /// </summary>
    [IsoId("_jk5l9V84Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Currency Accepted")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? DealingCurrencyAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DealingCurrencyAccepted { get; init; } 
    #else
    public string? DealingCurrencyAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether an application form is required for a switch.
    /// </summary>
    [IsoId("_jk5l9184Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Switch Authorisation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Forms1? SwitchAuthorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Forms1? SwitchAuthorisation { get; init; } 
    #else
    public Forms1? SwitchAuthorisation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a switch can be instructed by amount.
    /// </summary>
    [IsoId("_jk5l-V84Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmountIndicator { get; init; } 
    #else
    public System.String? AmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a switch can be instructed as a number of units.
    /// </summary>
    [IsoId("_jk5l-184Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Units Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? UnitsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnitsIndicator { get; init; } 
    #else
    public System.String? UnitsIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_fTxzYV9WEeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rounding")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingDirection2Code? Rounding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingDirection2Code? Rounding { get; init; } 
    #else
    public RoundingDirection2Code? Rounding { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the main fund order desk.
    /// </summary>
    [IsoId("_jk5l_V84Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Main Fund Order Desk Location")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; } 
    #else
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency at which the switches are done.
    /// </summary>
    [IsoId("_jk5l_184Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Frequency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency5Code? DealingFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency5Code? DealingFrequency { get; init; } 
    #else
    public EventFrequency5Code? DealingFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Description of frequency at which the switch is done.
    /// </summary>
    [IsoId("_jk5mAV84Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Frequency Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? DealingFrequencyDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DealingFrequencyDescription { get; init; } 
    #else
    public System.String? DealingFrequencyDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Latest time at which an order to switch can be given.
    /// </summary>
    [IsoId("_jk5mA184Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Cut Off Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? DealingCutOffTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? DealingCutOffTime { get; init; } 
    #else
    public System.TimeOnly? DealingCutOffTime { get; set; } 
    #endif
    
    /// <summary>
    /// Dealing cut-off timeframe.
    /// </summary>
    [IsoId("_jk5mBV84Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dealing Cut Off Time Frame")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeFrame4? DealingCutOffTimeFrame { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame4? DealingCutOffTimeFrame { get; init; } 
    #else
    public TimeFrame4? DealingCutOffTimeFrame { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the deal confirmation is issued.
    /// </summary>
    [IsoId("_jk5mB184Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deal Confirmation Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? DealConfirmationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? DealConfirmationTime { get; init; } 
    #else
    public System.TimeOnly? DealConfirmationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time frame within which the deal confirmation is issued.
    /// </summary>
    [IsoId("_jk5mCV84Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deal Confirmation Time Frame")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeFrame5? DealConfirmationTimeFrame { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame5? DealConfirmationTimeFrame { get; init; } 
    #else
    public TimeFrame5? DealConfirmationTimeFrame { get; set; } 
    #endif
    
    /// <summary>
    /// Specific period, for example, for some guaranteed funds, during which the units/shares may be switched.
    /// </summary>
    [IsoId("_jk5mC184Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Limited Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? LimitedPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LimitedPeriod { get; init; } 
    #else
    public System.String? LimitedPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement timing.
    /// </summary>
    [IsoId("_jk5mDV84Eeicg40_9gK9vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Cycle")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeFrame8Choice_? SettlementCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame8Choice_? SettlementCycle { get; init; } 
    #else
    public TimeFrame8Choice_? SettlementCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the switch processing characteristics.
    /// </summary>
    [IsoId("_mNfQYWAKEeiNMJ262H2pWg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
