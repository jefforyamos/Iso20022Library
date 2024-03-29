﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Description.  ISO2002 ID# _04Bcawk_EeGQpPnjvNlciw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
namespace BeneficialStrategies.Iso20022.Choices.MarketIdentification4Choice
{
    /// <summary>
    /// Description of the market when no Market Identifier Code is available.
    /// </summary>
    [IsoId("_04Bcawk_EeGQpPnjvNlciw")]
    [DisplayName("Description")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Description : MarketIdentification4Choice_
    #else
    public partial class Description : MarketIdentification4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Description instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Description( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 30 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ‘ + , and disable the use of slash &quot;/&quot; at the beginning and end of line and double slash &quot;//&quot; within the line.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Desc")]
        #endif
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
        [StringLength(maximumLength: 30 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINXMax30Text Value { get; init; } 
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
