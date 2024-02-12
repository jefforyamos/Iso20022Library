﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditLine3.  ISO2002 ID# _oZe7n4Z5Eee8r9VKRbnJSg.
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
/// Set of elements used to provide details of the credit line.
/// </summary>
[IsoId("_oZe7n4Z5Eee8r9VKRbnJSg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Credit Line")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditLine3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditLine3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditLine3( System.String reqIncluded )
    {
        Included = reqIncluded;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the credit line is included in the balance.
    /// </summary>
    [IsoId("_ohzxI4Z5Eee8r9VKRbnJSg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Included")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Included { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Included { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Included { get; init; } 
    #else
    public System.String Included { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    [IsoId("_tjAaIYZ5Eee8r9VKRbnJSg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditLineType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditLineType1Choice_? Type { get; init; } 
    #else
    public CreditLineType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money of the credit line.
    /// </summary>
    [IsoId("_ohzxJYZ5Eee8r9VKRbnJSg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Amount { get; init; } 
    #else
    public System.Decimal? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    [IsoId("_-qXbALPcEeeppqgHuc69jg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? Date { get; init; } 
    #else
    public DateAndDateTime2Choice_? Date { get; set; } 
    #endif
    
    
    #nullable disable
    
}
