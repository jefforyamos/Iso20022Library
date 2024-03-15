﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherTransactionIdentification.  ISO2002 ID# _8T7AuZNLEeWGlc8L7oPDIg.
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
namespace BeneficialStrategies.Iso20022.Choices.References60Choice
{
    /// <summary>
    /// Reference to a transaction that cannot be identified using a standard reference element present in the message.
    /// </summary>
    [IsoId("_8T7AuZNLEeWGlc8L7oPDIg")]
    [DisplayName("Other Transaction Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherTransactionIdentification : References60Choice_
    #else
    public partial class OtherTransactionIdentification : References60Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherTransactionIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherTransactionIdentification( System.String reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Message type number/message identifier of the message referenced in the linkage sequence.
        /// </summary>
        [IsoId("_8T7nsZNLEeWGlc8L7oPDIg")]
        [DisplayName("Message Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MsgNb")]
        #endif
        [IsoXmlTag("MsgNb")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DocumentNumber16Choice_? MessageNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentNumber16Choice_? MessageNumber { get; init; } 
        #else
        public DocumentNumber16Choice_? MessageNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the document.
        /// </summary>
        [IsoId("_8T7nuZNLEeWGlc8L7oPDIg")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINXMax16Text Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
