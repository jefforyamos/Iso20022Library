﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PreviousReference.  ISO2002 ID# _2-DoMTWhEe2OzdGcZrUAEQ.
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
namespace BeneficialStrategies.Iso20022.Choices.LinkedMessage6Choice
{
    /// <summary>
    /// Linked previous reference.
    /// </summary>
    [IsoId("_2-DoMTWhEe2OzdGcZrUAEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Reference")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PreviousReference : LinkedMessage6Choice_
    #else
    public partial class PreviousReference : LinkedMessage6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PreviousReference instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PreviousReference( System.String reqReference,DocumentNumber5Choice_ reqMessageNumber )
        {
            Reference = reqReference;
            MessageNumber = reqMessageNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
        /// </summary>
        [IsoId("_3WWMYzWhEe2OzdGcZrUAEQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reference")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Reference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Reference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Reference { get; init; } 
        #else
        public System.String Reference { get; set; } 
        #endif
        
        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_3WWMZTWhEe2OzdGcZrUAEQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reference Issuer")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification247Choice_? ReferenceIssuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification247Choice_? ReferenceIssuer { get; init; } 
        #else
        public PartyIdentification247Choice_? ReferenceIssuer { get; set; } 
        #endif
        
        /// <summary>
        /// Name of a message.
        /// </summary>
        [IsoId("_3WWMZzWhEe2OzdGcZrUAEQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Message Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MessageName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MessageName { get; init; } 
        #else
        public System.String? MessageName { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the type of message.
        /// </summary>
        [IsoId("_EYz9JDWiEe2OzdGcZrUAEQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Message Number")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DocumentNumber5Choice_ MessageNumber { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public DocumentNumber5Choice_ MessageNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentNumber5Choice_ MessageNumber { get; init; } 
        #else
        public DocumentNumber5Choice_ MessageNumber { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
