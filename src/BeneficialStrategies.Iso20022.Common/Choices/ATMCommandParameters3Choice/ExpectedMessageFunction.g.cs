﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ExpectedMessageFunction.  ISO2002 ID# _htqcM12aEeekzJIz1JxYSQ.
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
namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters3Choice
{
    /// <summary>
    /// Message to send for the send message command.
    /// </summary>
    [IsoId("_htqcM12aEeekzJIz1JxYSQ")]
    [DisplayName("Expected Message Function")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ExpectedMessageFunction : ATMCommandParameters3Choice_
    #else
    public partial class ExpectedMessageFunction : ATMCommandParameters3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ExpectedMessageFunction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ExpectedMessageFunction( MessageFunction8Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the type of process requested by the host to an ATM.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XpctdMsgFctn")]
        #endif
        [IsoXmlTag("XpctdMsgFctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required MessageFunction8Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required MessageFunction8Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MessageFunction8Code Value { get; init; } 
        #else
        public MessageFunction8Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
