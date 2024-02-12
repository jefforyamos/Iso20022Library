﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromDateToDate.  ISO2002 ID# _VQk9WTwGEemGDJYTly2NCA.
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
namespace BeneficialStrategies.Iso20022.Choices.Period7Choice
{
    /// <summary>
    /// Time span defined by a start date and time, and an end date and time.
    /// </summary>
    [IsoId("_VQk9WTwGEemGDJYTly2NCA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("From Date To Date")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FromDateToDate : Period7Choice_
    #else
    public partial class FromDateToDate : Period7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FromDateToDate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FromDateToDate( System.DateOnly reqFromDate,System.DateOnly reqToDate )
        {
            FromDate = reqFromDate;
            ToDate = reqToDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_T5oiAdp-Ed-ak6NoX_4Aeg_1497161242")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("From Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate FromDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateOnly FromDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly FromDate { get; init; } 
        #else
        public System.DateOnly FromDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_T5oiAtp-Ed-ak6NoX_4Aeg_1497161560")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("To Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ToDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateOnly ToDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ToDate { get; init; } 
        #else
        public System.DateOnly ToDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
