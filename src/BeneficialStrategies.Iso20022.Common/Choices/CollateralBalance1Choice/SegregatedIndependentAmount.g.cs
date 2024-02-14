﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _UnXxytp-Ed-ak6NoX_4Aeg_1045799197.
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
namespace BeneficialStrategies.Iso20022.Choices.CollateralBalance1Choice
{
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the segregated independent amount only.
    /// </summary>
    [IsoId("_UnXxytp-Ed-ak6NoX_4Aeg_1045799197")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SegregatedIndependentAmount : CollateralBalance1Choice_
    #else
    public partial class SegregatedIndependentAmount : CollateralBalance1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Post haircut market value of all margin collateral held by party A.
        /// </summary>
        [IsoId("_Uoa6ptp-Ed-ak6NoX_4Aeg_-733012556")]
        [DisplayName("Held By Party A")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HeldByPtyA")]
        #endif
        [IsoXmlTag("HeldByPtyA")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAndAmount? HeldByPartyA { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? HeldByPartyA { get; init; } 
        #else
        public System.Decimal? HeldByPartyA { get; set; } 
        #endif
        
        /// <summary>
        /// Post haircut market value of all margin collateral held by party B.
        /// </summary>
        [IsoId("_Uoa6p9p-Ed-ak6NoX_4Aeg_-264212788")]
        [DisplayName("Held By Party B")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HeldByPtyB")]
        #endif
        [IsoXmlTag("HeldByPtyB")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAndAmount? HeldByPartyB { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? HeldByPartyB { get; init; } 
        #else
        public System.Decimal? HeldByPartyB { get; set; } 
        #endif
        
        /// <summary>
        /// Sum of all margin agreed amounts due to party A from prior days’ collateral calls where collateral movements have not yet been agreed.
        /// </summary>
        [IsoId("_Uoa6qNp-Ed-ak6NoX_4Aeg_609978302")]
        [DisplayName("Prior Agreed To Party A")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrrAgrdToPtyA")]
        #endif
        [IsoXmlTag("PrrAgrdToPtyA")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAndAmount? PriorAgreedToPartyA { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? PriorAgreedToPartyA { get; init; } 
        #else
        public System.Decimal? PriorAgreedToPartyA { get; set; } 
        #endif
        
        /// <summary>
        /// Sum of all margin agreed amounts due to party B from prior days’ collateral calls where collateral movements have not yet been agreed.
        /// </summary>
        [IsoId("_Uoa6qdp-Ed-ak6NoX_4Aeg_316227488")]
        [DisplayName("Prior Agreed To Party B")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrrAgrdToPtyB")]
        #endif
        [IsoXmlTag("PrrAgrdToPtyB")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAndAmount? PriorAgreedToPartyB { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? PriorAgreedToPartyB { get; init; } 
        #else
        public System.Decimal? PriorAgreedToPartyB { get; set; } 
        #endif
        
        /// <summary>
        /// Sum of all margin collateral movements due to party A in progress but not yet settled.
        /// </summary>
        [IsoId("_Uoa6qtp-Ed-ak6NoX_4Aeg_-11345204")]
        [DisplayName("In Transit To Party A")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InTrnstToPtyA")]
        #endif
        [IsoXmlTag("InTrnstToPtyA")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAndAmount? InTransitToPartyA { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? InTransitToPartyA { get; init; } 
        #else
        public System.Decimal? InTransitToPartyA { get; set; } 
        #endif
        
        /// <summary>
        /// Sum of all margin collateral movements due to party B in progress but not yet settled.
        /// </summary>
        [IsoId("_Uoa6q9p-Ed-ak6NoX_4Aeg_1038693613")]
        [DisplayName("In Transit To Party B")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InTrnstToPtyB")]
        #endif
        [IsoXmlTag("InTrnstToPtyB")]
        [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoActiveCurrencyAndAmount? InTransitToPartyB { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? InTransitToPartyB { get; init; } 
        #else
        public System.Decimal? InTransitToPartyB { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
