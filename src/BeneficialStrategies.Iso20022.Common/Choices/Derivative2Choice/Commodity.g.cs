﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Commodity.  ISO2002 ID# _Bv9MQWkwEeaLAKoEUNsD9g.
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
namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice
{
    /// <summary>
    /// Details specific for commodity derivatives.
    /// </summary>
    [IsoId("_Bv9MQWkwEeaLAKoEUNsD9g")]
    [DisplayName("Commodity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Commodity : Derivative2Choice_
    #else
    public partial class Commodity : Derivative2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Commodity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Commodity( string reqNotionalCurrency )
        {
            NotionalCurrency = reqNotionalCurrency;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides specific information related to commodity derivatives.
        /// </summary>
        [IsoId("_znHVYWlHEeaLAKoEUNsD9g")]
        [DisplayName("Class Specific")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClssSpcfc")]
        #endif
        [IsoXmlTag("ClssSpcfc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommodityDerivate2Choice_? ClassSpecific { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommodityDerivate2Choice_? ClassSpecific { get; init; } 
        #else
        public CommodityDerivate2Choice_? ClassSpecific { get; set; } 
        #endif
        
        /// <summary>
        /// Currency in which the notional is denominated.
        /// </summary>
        [IsoId("_znHVY2lHEeaLAKoEUNsD9g")]
        [DisplayName("Notional Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NtnlCcy")]
        #endif
        [IsoXmlTag("NtnlCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string NotionalCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string NotionalCurrency { get; init; } 
        #else
        public string NotionalCurrency { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
