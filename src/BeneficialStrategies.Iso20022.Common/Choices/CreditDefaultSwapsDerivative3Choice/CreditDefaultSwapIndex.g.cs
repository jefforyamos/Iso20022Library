﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditDefaultSwapIndex.  ISO2002 ID# _xfbL035eEea2k7EBUopqxw.
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
namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative3Choice
{
    /// <summary>
    /// A credit default swap on an index.
    /// </summary>
    [IsoId("_xfbL035eEea2k7EBUopqxw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Credit Default Swap Index")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CreditDefaultSwapIndex : CreditDefaultSwapsDerivative3Choice_
    #else
    public partial class CreditDefaultSwapIndex : CreditDefaultSwapsDerivative3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CreditDefaultSwapIndex instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CreditDefaultSwapIndex( string reqNotionalCurrency )
        {
            NotionalCurrency = reqNotionalCurrency;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Series number of the composition of the index if applicable.
        /// </summary>
        [IsoId("_xtQzgX5eEea2k7EBUopqxw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Series")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? Series { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Series { get; init; } 
        #else
        public System.UInt64? Series { get; set; } 
        #endif
        
        /// <summary>
        /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
        /// </summary>
        [IsoId("_xtQzg35eEea2k7EBUopqxw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Version")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? Version { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Version { get; init; } 
        #else
        public System.UInt64? Version { get; set; } 
        #endif
        
        /// <summary>
        /// All months when the roll is expected as established by the index provider for a given year. Field should be repeated for each month in the roll.
        /// </summary>
        [IsoId("_xtQzhX5eEea2k7EBUopqxw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Roll Month")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [MinLength(0)]
        [MaxLength(12)]
        #endif
        public SimpleValueList<System.UInt64> RollMonth { get; init; } = new SimpleValueList<System.UInt64>(){};
        
        /// <summary>
        /// To be populated in the case of a CDS Index or a derivative CDS Index with the next roll date of the index as established by the index provider.
        /// </summary>
        [IsoId("_xtQzh35eEea2k7EBUopqxw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Next Roll Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? NextRollDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? NextRollDate { get; init; } 
        #else
        public System.DateOnly? NextRollDate { get; set; } 
        #endif
        
        /// <summary>
        /// Currency in which the notional is denominated.
        /// </summary>
        [IsoId("_xtQziX5eEea2k7EBUopqxw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Notional Currency")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public string NotionalCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string NotionalCurrency { get; init; } 
        #else
        public string NotionalCurrency { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
