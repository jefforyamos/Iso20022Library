﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Guarantee.  ISO2002 ID# _yMukYK_7EeaE9YROwd69hA.
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
namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice
{
    /// <summary>
    /// Promise to meet the obligations of a clearing member provided by a third party.
    /// </summary>
    [IsoId("_yMukYK_7EeaE9YROwd69hA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Guarantee")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Guarantee : AssetHolding1Choice_
    #else
    public partial class Guarantee : AssetHolding1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Guarantee instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Guarantee( PartyIdentification118Choice_ reqProvider,System.Decimal reqAmount )
        {
            Provider = reqProvider;
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of guarantee provider.
        /// </summary>
        [IsoId("_S3vCAK_8EeaE9YROwd69hA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Provider")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification118Choice_ Provider { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public PartyIdentification118Choice_ Provider { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification118Choice_ Provider { get; init; } 
        #else
        public PartyIdentification118Choice_ Provider { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the collateral guarantee.
        /// </summary>
        [IsoId("_WWJpoK_8EeaE9YROwd69hA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.Decimal Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal Amount { get; init; } 
        #else
        public System.Decimal Amount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
