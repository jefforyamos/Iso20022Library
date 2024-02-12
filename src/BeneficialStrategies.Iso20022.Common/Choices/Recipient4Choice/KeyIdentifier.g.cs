﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyIdentifier.  ISO2002 ID# _N1aSpWi0EeS87LmvcA55sg.
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
namespace BeneficialStrategies.Iso20022.Choices.Recipient4Choice
{
    /// <summary>
    /// Identification of a protection key without a session key, shared and previously exchanged between the initiator and the recipient.
    /// </summary>
    [IsoId("_N1aSpWi0EeS87LmvcA55sg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Key Identifier")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record KeyIdentifier : Recipient4Choice_
    #else
    public partial class KeyIdentifier : Recipient4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a KeyIdentifier instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public KeyIdentifier( System.String reqKeyIdentification,System.String reqKeyVersion )
        {
            KeyIdentification = reqKeyIdentification;
            KeyVersion = reqKeyVersion;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the cryptographic key.
        /// </summary>
        [IsoId("_RzjGsWi1EeS87LmvcA55sg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Key Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Text KeyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String KeyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String KeyIdentification { get; init; } 
        #else
        public System.String KeyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_RzjGs2i1EeS87LmvcA55sg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Key Version")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Text KeyVersion { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String KeyVersion { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String KeyVersion { get; init; } 
        #else
        public System.String KeyVersion { get; set; } 
        #endif
        
        /// <summary>
        /// Number of usages of the cryptographic key.
        /// </summary>
        [IsoId("_riRHoGi1EeS87LmvcA55sg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Sequence Number")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? SequenceNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? SequenceNumber { get; init; } 
        #else
        public System.UInt64? SequenceNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Identification used for derivation of a unique key from a master key provided for the data protection.
        /// </summary>
        [IsoId("_RzjGtWi1EeS87LmvcA55sg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Derivation Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMin5Max16Binary? DerivationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[]? DerivationIdentification { get; init; } 
        #else
        public System.Byte[]? DerivationIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
