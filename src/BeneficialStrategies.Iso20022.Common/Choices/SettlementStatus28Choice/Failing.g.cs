﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Failing.  ISO2002 ID# _BVp3OwpIEeup4r-PFG2T5Q.
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
namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus28Choice
{
    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// </summary>
    [IsoId("_BVp3OwpIEeup4r-PFG2T5Q")]
    [DisplayName("Failing")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Failing : SettlementStatus28Choice_
    #else
    public partial class Failing : SettlementStatus28Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        
        #nullable disable
        
    }
}
