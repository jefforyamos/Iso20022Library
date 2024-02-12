﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeStateReport12.  ISO2002 ID# _nBfoF3g-Eeu3kecHd7QKUQ.
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
/// Provides details for a trade state report.
/// </summary>
[IsoId("_nBfoF3g-Eeu3kecHd7QKUQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Trade State Report")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeStateReport12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeStateReport12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeStateReport12( CommonTradeDataReport50 reqCommonTradeData )
    {
        CommonTradeData = reqCommonTradeData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_nQXxkXg-Eeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty Specific Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(1)]
    [MaxLength(2)]
    #endif
    public ValueList<CounterpartySpecificData29> CounterpartySpecificData { get; init; } = new ValueList<CounterpartySpecificData29>(){};
    
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    [IsoId("_nQXxk3g-Eeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Common Trade Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommonTradeDataReport50 CommonTradeData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CommonTradeDataReport50 CommonTradeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommonTradeDataReport50 CommonTradeData { get; init; } 
    #else
    public CommonTradeDataReport50 CommonTradeData { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_nQXxlXg-Eeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Technical Attributes")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TechnicalAttributes4? TechnicalAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TechnicalAttributes4? TechnicalAttributes { get; init; } 
    #else
    public TechnicalAttributes4? TechnicalAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nQXxl3g-Eeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
