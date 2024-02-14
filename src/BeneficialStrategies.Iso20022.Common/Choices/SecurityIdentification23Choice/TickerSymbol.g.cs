﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TickerSymbol.  ISO2002 ID# _CSq4OyGQEeW7gKYhAMEFCw.
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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, for example, RTR.L for Reuters quoted in London.
    /// </summary>
    [IsoId("_CSq4OyGQEeW7gKYhAMEFCw")]
    [DisplayName("Ticker Symbol")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TickerSymbol : SecurityIdentification23Choice_
    #else
    public partial class TickerSymbol : SecurityIdentification23Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TickerSymbol instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TickerSymbol( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, for example, RTR.L for Reuters quoted in London.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TckrSymb")]
        #endif
        [IsoXmlTag("TckrSymb")]
        [IsoSimpleType(IsoSimpleType.TickerIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTickerIdentifier Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
