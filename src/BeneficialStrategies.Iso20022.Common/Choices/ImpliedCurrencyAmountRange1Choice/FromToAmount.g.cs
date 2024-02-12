﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromToAmount.  ISO2002 ID# _O_mxNZlcEeeE1Ya-LgRsuQ.
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
namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRange1Choice
{
    /// <summary>
    /// Range of valid amount values.
    /// </summary>
    [IsoId("_O_mxNZlcEeeE1Ya-LgRsuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("From To Amount")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FromToAmount : ImpliedCurrencyAmountRange1Choice_
    #else
    public partial class FromToAmount : ImpliedCurrencyAmountRange1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FromToAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FromToAmount( AmountRangeBoundary1 reqFromAmount,AmountRangeBoundary1 reqToAmount )
        {
            FromAmount = reqFromAmount;
            ToAmount = reqToAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Lower boundary of a range of amount values.
        /// </summary>
        [IsoId("_jw5KoZljEeeE1Ya-LgRsuQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("From Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AmountRangeBoundary1 FromAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AmountRangeBoundary1 FromAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountRangeBoundary1 FromAmount { get; init; } 
        #else
        public AmountRangeBoundary1 FromAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Upper boundary of a range of amount values.
        /// </summary>
        [IsoId("_jw5Ko5ljEeeE1Ya-LgRsuQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("To Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AmountRangeBoundary1 ToAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AmountRangeBoundary1 ToAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountRangeBoundary1 ToAmount { get; init; } 
        #else
        public AmountRangeBoundary1 ToAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
