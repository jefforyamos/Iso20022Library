﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KEK.  ISO2002 ID# _EE9KgwxqEeqdx6buGpCCQw.
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
namespace BeneficialStrategies.Iso20022.Choices.Recipient8Choice
{
    /// <summary>
    /// Key encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("_EE9KgwxqEeqdx6buGpCCQw")]
    [DisplayName("KEK")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record KEK : Recipient8Choice_
    #else
    public partial class KEK : Recipient8Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a KEK instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public KEK( KEKIdentifier2 reqKEKIdentification,AlgorithmIdentification29 reqKeyEncryptionAlgorithm,System.Byte[] reqEncryptedKey )
        {
            KEKIdentification = reqKEKIdentification;
            KeyEncryptionAlgorithm = reqKeyEncryptionAlgorithm;
            EncryptedKey = reqEncryptedKey;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_ByuFQQ0yEeqUVL7sB4m7NA")]
        [DisplayName("Version")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Vrsn")]
        #endif
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? Version { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Version { get; init; } 
        #else
        public System.UInt64? Version { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_ByuFQw0yEeqUVL7sB4m7NA")]
        [DisplayName("KEK Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="KEKId")]
        #endif
        [IsoXmlTag("KEKId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required KEKIdentifier2 KEKIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required KEKIdentifier2 KEKIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public KEKIdentifier2 KEKIdentification { get; init; } 
        #else
        public KEKIdentifier2 KEKIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_ByuFRQ0yEeqUVL7sB4m7NA")]
        [DisplayName("Key Encryption Algorithm")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="KeyNcrptnAlgo")]
        #endif
        [IsoXmlTag("KeyNcrptnAlgo")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AlgorithmIdentification29 KeyEncryptionAlgorithm { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AlgorithmIdentification29 KeyEncryptionAlgorithm { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AlgorithmIdentification29 KeyEncryptionAlgorithm { get; init; } 
        #else
        public AlgorithmIdentification29 KeyEncryptionAlgorithm { get; set; } 
        #endif
        
        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_ByuFRw0yEeqUVL7sB4m7NA")]
        [DisplayName("Encrypted Key")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NcrptdKey")]
        #endif
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax500Binary EncryptedKey { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Byte[] EncryptedKey { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[] EncryptedKey { get; init; } 
        #else
        public System.Byte[] EncryptedKey { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
