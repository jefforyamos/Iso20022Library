﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TypeAndIdentification.  ISO2002 ID# _9C3BGffEEeiNZp_PtLohLw.
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
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat34Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a type and identification.
    /// </summary>
    [IsoId("_9C3BGffEEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type And Identification")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TypeAndIdentification : SafekeepingPlaceFormat34Choice_
    #else
    public partial class TypeAndIdentification : SafekeepingPlaceFormat34Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TypeAndIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TypeAndIdentification( SafekeepingPlace1Code reqSafekeepingPlaceType,System.String reqIdentification )
        {
            SafekeepingPlaceType = reqSafekeepingPlaceType;
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Place of safekeeping as a code.
        /// </summary>
        [IsoId("_W1QC0bXEEeiTob_PrFFUxA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Safekeeping Place Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
        #else
        public SafekeepingPlace1Code SafekeepingPlaceType { get; set; } 
        #endif
        
        /// <summary>
        /// Place of safekeeping.
        /// </summary>
        [IsoId("_W1QC07XEEeiTob_PrFFUxA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoAnyBICDec2014Identifier Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
