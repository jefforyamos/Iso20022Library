﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _ds02PTi8Eeydid5dcNPKvg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus11Choice
{
    /// <summary>
    /// Proprietary status.
    /// </summary>
    [IsoId("_ds02PTi8Eeydid5dcNPKvg")]
    [DisplayName("Proprietary")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Proprietary : ModificationProcessingStatus11Choice_
    #else
    public partial class Proprietary : ModificationProcessingStatus11Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Proprietary instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Proprietary( GenericIdentification47 reqProprietaryStatus )
        {
            ProprietaryStatus = reqProprietaryStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        [IsoId("_cemexZKQEeWHWpTQn1FFVg")]
        [DisplayName("Proprietary Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtrySts")]
        #endif
        [IsoXmlTag("PrtrySts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification47 ProprietaryStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification47 ProprietaryStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification47 ProprietaryStatus { get; init; } 
        #else
        public GenericIdentification47 ProprietaryStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_cemex5KQEeWHWpTQn1FFVg")]
        [DisplayName("Proprietary Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryRsn")]
        #endif
        [IsoXmlTag("PrtryRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ProprietaryReason5? ProprietaryReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProprietaryReason5? ProprietaryReason { get; init; } 
        #else
        public ProprietaryReason5? ProprietaryReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
