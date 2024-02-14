﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _1Tcqatx4EeqESbVR5AloZQ.
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
namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus1Choice
{
    /// <summary>
    /// Proprietary status related to an instruction cancellation request.
    /// </summary>
    [IsoId("_1Tcqatx4EeqESbVR5AloZQ")]
    [DisplayName("Proprietary Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProprietaryStatus : MarketClaimCancellationRequestStatus1Choice_
    #else
    public partial class ProprietaryStatus : MarketClaimCancellationRequestStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProprietaryStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProprietaryStatus( GenericIdentification30 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtrySts")]
        #endif
        [IsoXmlTag("PrtrySts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification30 Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification30 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification30 Value { get; init; } 
        #else
        public GenericIdentification30 Value { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_y0OagTp4EeWVrPy0StzzSg")]
        [DisplayName("Proprietary Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryRsn")]
        #endif
        [IsoXmlTag("PrtryRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ProprietaryReason4? ProprietaryReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProprietaryReason4? ProprietaryReason { get; init; } 
        #else
        public ProprietaryReason4? ProprietaryReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
