﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _l235NRN-EeKyONjZVQUqzg.
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
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus12Choice
{
    /// <summary>
    /// Proprietary status related to an instruction.
    /// </summary>
    [IsoId("_l235NRN-EeKyONjZVQUqzg")]
    [DisplayName("Proprietary Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProprietaryStatus : InstructionProcessingStatus12Choice_
    #else
    public partial class ProprietaryStatus : InstructionProcessingStatus12Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProprietaryStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProprietaryStatus( GenericIdentification20 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtrySts")]
        #endif
        [IsoXmlTag("PrtrySts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification20 Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification20 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification20 Value { get; init; } 
        #else
        public GenericIdentification20 Value { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_UatOw9p-Ed-ak6NoX_4Aeg_-1512024757")]
        [DisplayName("Proprietary Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryRsn")]
        #endif
        [IsoXmlTag("PrtryRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ProprietaryReason1? ProprietaryReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProprietaryReason1? ProprietaryReason { get; init; } 
        #else
        public ProprietaryReason1? ProprietaryReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
