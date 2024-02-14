﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProxyNotAllowed.  ISO2002 ID# _iTU-wxrfEeyhRdHRjakS2w.
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
namespace BeneficialStrategies.Iso20022.Choices.Proxy5Choice
{
    /// <summary>
    /// Indicates that no proxy is allowed for a meeting.
    /// </summary>
    [IsoId("_iTU-wxrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy Not Allowed")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProxyNotAllowed : Proxy5Choice_
    #else
    public partial class ProxyNotAllowed : Proxy5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProxyNotAllowed instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProxyNotAllowed( ProxyNotAllowed1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the assignment of a proxy is not allowed for the meeting.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrxyNotAllwd")]
        #endif
        [IsoXmlTag("PrxyNotAllwd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ProxyNotAllowed1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ProxyNotAllowed1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProxyNotAllowed1Code Value { get; init; } 
        #else
        public ProxyNotAllowed1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
