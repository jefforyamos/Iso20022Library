﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RepurchaseAgreement2.  ISO2002 ID# _onOhMbJVEeaYqc4G3TTwhA.
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
/// Agreement between two parties to sell a financial instrument or set of financial instruments and repurchase at an agreed later date.
/// </summary>
[IsoId("_onOhMbJVEeaYqc4G3TTwhA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Repurchase Agreement")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RepurchaseAgreement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RepurchaseAgreement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RepurchaseAgreement2( System.DateOnly reqMaturityDate,System.Decimal reqSecondLegPrice,System.Decimal reqCollateralMarketValue,System.String reqCounterparty,RepurchaseAgreementType3Choice_ reqRepurchaseAgreementType )
    {
        MaturityDate = reqMaturityDate;
        SecondLegPrice = reqSecondLegPrice;
        CollateralMarketValue = reqCollateralMarketValue;
        Counterparty = reqCounterparty;
        RepurchaseAgreementType = reqRepurchaseAgreementType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the repurchase agreement matures.
    /// </summary>
    [IsoId("_oxf3gbJVEeaYqc4G3TTwhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maturity Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate MaturityDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateOnly MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly MaturityDate { get; init; } 
    #else
    public System.DateOnly MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the repurchase price at maturity of the repo.
    /// </summary>
    [IsoId("_oxf3g7JVEeaYqc4G3TTwhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Second Leg Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount SecondLegPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal SecondLegPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal SecondLegPrice { get; init; } 
    #else
    public System.Decimal SecondLegPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the dirty price of the underlying security or securities in repo.
    /// </summary>
    [IsoId("_-lqgULboEeaqL_M7XFD7PQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Market Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount CollateralMarketValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal CollateralMarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal CollateralMarketValue { get; init; } 
    #else
    public System.Decimal CollateralMarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the counterparty to the repurchase agreement.
    /// </summary>
    [IsoId("_oxf3hbJVEeaYqc4G3TTwhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Counterparty { get; init; } 
    #else
    public System.String Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of repurchase agreement.
    /// </summary>
    [IsoId("_3JXU8LJVEeaYqc4G3TTwhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repurchase Agreement Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; } 
    #else
    public RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the triparty repurchase agent.
    /// </summary>
    [IsoId("_63_i0LJVEeaYqc4G3TTwhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Triparty Agent Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? TripartyAgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentIdentification { get; init; } 
    #else
    public System.String? TripartyAgentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
