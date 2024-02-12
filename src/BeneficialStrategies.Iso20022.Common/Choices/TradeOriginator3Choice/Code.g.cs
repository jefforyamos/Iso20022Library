﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _69UZwTtCEeWRTLSN0i0tng.
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
namespace BeneficialStrategies.Iso20022.Choices.TradeOriginator3Choice
{
    /// <summary>
    /// Trading party capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_69UZwTtCEeWRTLSN0i0tng")]
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
    public partial record Code : TradeOriginator3Choice_
    #else
    public partial class Code : TradeOriginator3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Code instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Code( OriginatorRole2Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the trading party in the transaction.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OriginatorRole2Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public OriginatorRole2Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OriginatorRole2Code Value { get; init; } 
        #else
        public OriginatorRole2Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
