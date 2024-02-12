﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SystemRestriction.  ISO2002 ID# _8IwTgzp0Eemk2e6qGBk8IQ.
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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountModification2Choice
{
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_8IwTgzp0Eemk2e6qGBk8IQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("System Restriction")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SystemRestriction : SecuritiesAccountModification2Choice_
    #else
    public partial class SystemRestriction : SecuritiesAccountModification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SystemRestriction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SystemRestriction( System.DateTime reqValidFrom,System.String reqType )
        {
            ValidFrom = reqValidFrom;
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the date from which the restriction is valid.
        /// </summary>
        [IsoId("_kpU3oe5NEeCisYr99QEiWA_534617393")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Valid From")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ValidFrom { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateTime ValidFrom { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ValidFrom { get; init; } 
        #else
        public System.DateTime ValidFrom { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the date until which the restriction is valid.
        /// </summary>
        [IsoId("_kpU3ou5NEeCisYr99QEiWA_1295382546")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Valid To")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? ValidTo { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? ValidTo { get; init; } 
        #else
        public System.DateTime? ValidTo { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the identification of a restriction.
        /// </summary>
        [IsoId("_kpU3o-5NEeCisYr99QEiWA_1881329572")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Type { get; init; } 
        #else
        public System.String Type { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
