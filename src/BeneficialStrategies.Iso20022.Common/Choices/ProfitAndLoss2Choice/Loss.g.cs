﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Loss.  ISO2002 ID# _Nd_nI2YDEeaJx-BUPcSWQA.
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
namespace BeneficialStrategies.Iso20022.Choices.ProfitAndLoss2Choice
{
    /// <summary>
    /// Value of the negative amount.
    /// </summary>
    [IsoId("_Nd_nI2YDEeaJx-BUPcSWQA")]
    [DisplayName("Loss")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Loss : ProfitAndLoss2Choice_
    #else
    public partial class Loss : ProfitAndLoss2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Loss instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Loss( System.Decimal reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Loss")]
        #endif
        [IsoXmlTag("Loss")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoActiveCurrencyAndAmount Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal Value { get; init; } 
        #else
        public System.Decimal Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
