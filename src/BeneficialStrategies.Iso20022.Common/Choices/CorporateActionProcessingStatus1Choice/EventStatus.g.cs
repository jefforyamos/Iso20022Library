﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EventStatus.  ISO2002 ID# _Q1O85dp-Ed-ak6NoX_4Aeg_109671588.
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
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus1Choice
{
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_Q1O85dp-Ed-ak6NoX_4Aeg_109671588")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Event Status")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record EventStatus : CorporateActionProcessingStatus1Choice_
    #else
    public partial class EventStatus : CorporateActionProcessingStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a EventStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public EventStatus( EventCompletenessStatus1Code reqEventCompletenessStatus,EventConfirmationStatus1Code reqEventConfirmationStatus )
        {
            EventCompletenessStatus = reqEventCompletenessStatus;
            EventConfirmationStatus = reqEventConfirmationStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates whether the details provided about an event are complete or incomplete.
        /// </summary>
        [IsoId("_UKK4Z9p-Ed-ak6NoX_4Aeg_1527495156")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Event Completeness Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
        #else
        public EventCompletenessStatus1Code EventCompletenessStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the status of the occurrence of an event.
        /// </summary>
        [IsoId("_UKK4aNp-Ed-ak6NoX_4Aeg_1457310397")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Event Confirmation Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
        #else
        public EventConfirmationStatus1Code EventConfirmationStatus { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
