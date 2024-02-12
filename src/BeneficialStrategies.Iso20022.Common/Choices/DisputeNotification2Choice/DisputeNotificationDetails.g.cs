﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DisputeNotificationDetails.  ISO2002 ID# _KkjLoStOEeyOa655cLd-DQ.
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
namespace BeneficialStrategies.Iso20022.Choices.DisputeNotification2Choice
{
    /// <summary>
    /// Provides the dispute notification details for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_KkjLoStOEeyOa655cLd-DQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Notification Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DisputeNotificationDetails : DisputeNotification2Choice_
    #else
    public partial class DisputeNotificationDetails : DisputeNotification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DisputeNotificationDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DisputeNotificationDetails( VariationMarginDispute1 reqVariationMarginDispute )
        {
            VariationMarginDispute = reqVariationMarginDispute;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the dispute notification details for the variation margin.
        /// </summary>
        [IsoId("_N2groStOEeyOa655cLd-DQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Variation Margin Dispute")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required VariationMarginDispute1 VariationMarginDispute { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public VariationMarginDispute1 VariationMarginDispute { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public VariationMarginDispute1 VariationMarginDispute { get; init; } 
        #else
        public VariationMarginDispute1 VariationMarginDispute { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the dispute notification details for the segregated independent amount.
        /// </summary>
        [IsoId("_N2groytOEeyOa655cLd-DQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Segregated Independent Amount Dispute")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SegregatedIndependentAmountDispute2? SegregatedIndependentAmountDispute { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SegregatedIndependentAmountDispute2? SegregatedIndependentAmountDispute { get; init; } 
        #else
        public SegregatedIndependentAmountDispute2? SegregatedIndependentAmountDispute { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
