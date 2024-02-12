﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8BQtWaMgEeCJ6YNENx4h-w_-1124219834.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.MarketInfrastructureIdentification1Choice
{
    /// <summary>
    /// Infrastructure through which the payment instruction is processed, as published in an external clearing system identification code list.
    /// </summary>
    [IsoId("_8BQtWaMgEeCJ6YNENx4h-w_-1124219834")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Code")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Code : MarketInfrastructureIdentification1Choice_
    #else
    public partial class Code : MarketInfrastructureIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Code instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Code( ExternalMarketInfrastructure1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the market infrastructure identification, as published in an external market infrastructure code list.
        /// This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalMarketInfrastructure1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ExternalMarketInfrastructure1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalMarketInfrastructure1Code Value { get; init; } 
        #else
        public ExternalMarketInfrastructure1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
