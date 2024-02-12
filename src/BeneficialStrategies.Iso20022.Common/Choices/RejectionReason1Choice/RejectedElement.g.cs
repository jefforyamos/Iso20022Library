﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectedElement.  ISO2002 ID# _RJ8ootp-Ed-ak6NoX_4Aeg_1044987769.
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
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason1Choice
{
    /// <summary>
    /// Specifies a rejection reason for each individual element of a report.
    /// </summary>
    [IsoId("_RJ8ootp-Ed-ak6NoX_4Aeg_1044987769")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejected Element")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RejectedElement : RejectionReason1Choice_
    #else
    public partial class RejectedElement : RejectionReason1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RejectedElement instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RejectedElement( System.UInt64 reqElementSequenceNumber,System.String reqIndividualRejectionReason )
        {
            ElementSequenceNumber = reqElementSequenceNumber;
            IndividualRejectionReason = reqIndividualRejectionReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sequence number that allows to easily identify the element that is rejected.
        /// </summary>
        [IsoId("_RJy3ptp-Ed-ak6NoX_4Aeg_-1803784041")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Element Sequence Number")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber ElementSequenceNumber { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.UInt64 ElementSequenceNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 ElementSequenceNumber { get; init; } 
        #else
        public System.UInt64 ElementSequenceNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for rejecting an individual element.
        /// </summary>
        [IsoId("_RJy3p9p-Ed-ak6NoX_4Aeg_1481340627")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Individual Rejection Reason")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Text IndividualRejectionReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String IndividualRejectionReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String IndividualRejectionReason { get; init; } 
        #else
        public System.String IndividualRejectionReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
