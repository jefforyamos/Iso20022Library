﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginCallResultDetails.  ISO2002 ID# _QmevNtp-Ed-ak6NoX_4Aeg_-1489094435.
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
namespace BeneficialStrategies.Iso20022.Choices.MarginCallResult1Choice
{
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_QmevNtp-Ed-ak6NoX_4Aeg_-1489094435")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Margin Call Result Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginCallResultDetails : MarginCallResult1Choice_
    #else
    public partial class MarginCallResultDetails : MarginCallResult1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarginCallResultDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarginCallResultDetails( Result1 reqVariationMarginResult )
        {
            VariationMarginResult = reqVariationMarginResult;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the summation of the call amounts for the variation margin amount only.
        /// </summary>
        [IsoId("_UlvaF9p-Ed-ak6NoX_4Aeg_-1196189794")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Variation Margin Result")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Result1 VariationMarginResult { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public Result1 VariationMarginResult { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Result1 VariationMarginResult { get; init; } 
        #else
        public Result1 VariationMarginResult { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the summation of the call amounts for the segregated independent amount.
        /// </summary>
        [IsoId("_UlvaGNp-Ed-ak6NoX_4Aeg_872246105")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Segregated Independent Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Result1? SegregatedIndependentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Result1? SegregatedIndependentAmount { get; init; } 
        #else
        public Result1? SegregatedIndependentAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
