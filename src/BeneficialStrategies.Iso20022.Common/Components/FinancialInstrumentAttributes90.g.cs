﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes90.  ISO2002 ID# _ja4gschlEeadgvwNGwK05w.
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
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_ja4gschlEeadgvwNGwK05w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Instrument Attributes")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes90
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributes90 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributes90( System.Decimal reqUnitValue,GenericIdentification168 reqIndexIdentification,System.String reqIndexUnit )
    {
        UnitValue = reqUnitValue;
        IndexIdentification = reqIndexIdentification;
        IndexUnit = reqIndexUnit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference notional amount of the contract.
    /// </summary>
    [IsoId("_jjd08chlEeadgvwNGwK05w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notional")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? Notional { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Notional { get; init; } 
    #else
    public System.Decimal? Notional { get; set; } 
    #endif
    
    /// <summary>
    /// Value of unit move in index if fixed in contract terms, and currency of payments relating to changes in the amount of the underlying.
    /// </summary>
    [IsoId("_jjd088hlEeadgvwNGwK05w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unit Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount UnitValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal UnitValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal UnitValue { get; init; } 
    #else
    public System.Decimal UnitValue { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for underlying index on which final settlement price or periodic payments are calculated.
    /// </summary>
    [IsoId("_jjd09chlEeadgvwNGwK05w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Index Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification168 IndexIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification168 IndexIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification168 IndexIdentification { get; init; } 
    #else
    public GenericIdentification168 IndexIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unit index, typically ‘Points’, or for interest rate and CDS products, ‘Bps’.
    /// </summary>
    [IsoId("_HF0BMMhoEeadgvwNGwK05w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Index Unit")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IndexUnit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String IndexUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IndexUnit { get; init; } 
    #else
    public System.String IndexUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Day count convention for interest payments. Interest rate products only.
    /// </summary>
    [IsoId("_NMr40MhoEeadgvwNGwK05w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Rate Terms")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethod2Code? InterestRateTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethod2Code? InterestRateTerms { get; init; } 
    #else
    public InterestComputationMethod2Code? InterestRateTerms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
