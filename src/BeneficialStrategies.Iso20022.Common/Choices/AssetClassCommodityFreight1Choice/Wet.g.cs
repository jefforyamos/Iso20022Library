﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Wet.  ISO2002 ID# _9FcRwFrcEeWN79Bl6BUd3g.
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
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFreight1Choice
{
    /// <summary>
    /// Wet freight commodity derivative.
    /// </summary>
    [IsoId("_9FcRwFrcEeWN79Bl6BUd3g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Wet")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Wet : AssetClassCommodityFreight1Choice_
    #else
    public partial class Wet : AssetClassCommodityFreight1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Wet instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Wet( AssetClassProductType4Code reqBaseProduct,AssetClassSubProductType32Code reqSubProduct )
        {
            BaseProduct = reqBaseProduct;
            SubProduct = reqSubProduct;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_4K64gFrcEeWN79Bl6BUd3g")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Base Product")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassProductType4Code BaseProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AssetClassProductType4Code BaseProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassProductType4Code BaseProduct { get; init; } 
        #else
        public AssetClassProductType4Code BaseProduct { get; set; } 
        #endif
        
        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_gTfT4FrdEeWN79Bl6BUd3g")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Sub Product")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassSubProductType32Code SubProduct { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AssetClassSubProductType32Code SubProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassSubProductType32Code SubProduct { get; init; } 
        #else
        public AssetClassSubProductType32Code SubProduct { get; set; } 
        #endif
        
        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_xu1wcFrdEeWN79Bl6BUd3g")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Additional Sub Product")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AssetClassDetailedSubProductType12Code? AdditionalSubProduct { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassDetailedSubProductType12Code? AdditionalSubProduct { get; init; } 
        #else
        public AssetClassDetailedSubProductType12Code? AdditionalSubProduct { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
