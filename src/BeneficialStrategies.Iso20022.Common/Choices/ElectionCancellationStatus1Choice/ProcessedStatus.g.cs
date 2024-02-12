﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessedStatus.  ISO2002 ID# _RiiHw9p-Ed-ak6NoX_4Aeg_1800632270.
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
namespace BeneficialStrategies.Iso20022.Choices.ElectionCancellationStatus1Choice
{
    /// <summary>
    /// Provides information about the processing status of the request.
    /// </summary>
    [IsoId("_RiiHw9p-Ed-ak6NoX_4Aeg_1800632270")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processed Status")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProcessedStatus : ElectionCancellationStatus1Choice_
    #else
    public partial class ProcessedStatus : ElectionCancellationStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProcessedStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProcessedStatus( ProcessedStatus5FormatChoice_ reqStatus )
        {
            Status = reqStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// The processing status.
        /// </summary>
        [IsoId("_RlD3Vtp-Ed-ak6NoX_4Aeg_-1520950491")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ProcessedStatus5FormatChoice_ Status { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ProcessedStatus5FormatChoice_ Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProcessedStatus5FormatChoice_ Status { get; init; } 
        #else
        public ProcessedStatus5FormatChoice_ Status { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RlD3V9p-Ed-ak6NoX_4Aeg_-1520950490")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Additional Information")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalInformation { get; init; } 
        #else
        public System.String? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
