﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractType8.  ISO2002 ID# _Zj1khQ1HEeqV4s5SpzR1dQ.
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
/// Information related to contract attributes.
/// </summary>
[IsoId("_Zj1khQ1HEeqV4s5SpzR1dQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Contract Type")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractType8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_Zko1wQ1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contract Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #else
    public FinancialInstrumentContractType2Code? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_Zko1ww1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Asset Class")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductType4Code? AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType4Code? AssetClass { get; init; } 
    #else
    public ProductType4Code? AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    [IsoId("_Zkpc0Q1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product Classification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductClassification1Choice_? ProductClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductClassification1Choice_? ProductClassification { get; init; } 
    #else
    public ProductClassification1Choice_? ProductClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    [IsoId("_Zkpc1Q1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification18Choice_? ProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification18Choice_? ProductIdentification { get; init; } 
    #else
    public SecurityIdentification18Choice_? ProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_Zkpc1w1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying Instrument")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; init; } 
    #else
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    [IsoId("_Zkpc2Q1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notional Currency First Leg")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? NotionalCurrencyFirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NotionalCurrencyFirstLeg { get; init; } 
    #else
    public string? NotionalCurrencyFirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Other currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    [IsoId("_Zkpc2w1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notional Currency Second Leg")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? NotionalCurrencySecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NotionalCurrencySecondLeg { get; init; } 
    #else
    public string? NotionalCurrencySecondLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency to be delivered.
    /// </summary>
    [IsoId("_Zkpc3Q1HEeqV4s5SpzR1dQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deliverable Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? DeliverableCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DeliverableCurrency { get; init; } 
    #else
    public string? DeliverableCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
