﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Key.  ISO2002 ID# _rAZ80ItIEeSxlKlAGYErFg.
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
namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice
{
    /// <summary>
    /// Parameters to be used by the various cryptographic key commands.
    /// </summary>
    [IsoId("_rAZ80ItIEeSxlKlAGYErFg")]
    [DisplayName("Key")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Key : ATMCommandParameters2Choice_
    #else
    public partial class Key : ATMCommandParameters2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Category of the cryptographic key.
        /// </summary>
        [IsoId("_T5qOQItJEeSxlKlAGYErFg")]
        [DisplayName("Key Category")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="KeyCtgy")]
        #endif
        [IsoXmlTag("KeyCtgy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CryptographicKeyType4Code? KeyCategory { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CryptographicKeyType4Code? KeyCategory { get; init; } 
        #else
        public CryptographicKeyType4Code? KeyCategory { get; set; } 
        #endif
        
        /// <summary>
        /// Random value from the host provided during a previous exchange.
        /// </summary>
        [IsoId("_hkcjQItJEeSxlKlAGYErFg")]
        [DisplayName("Host Challenge")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HstChllng")]
        #endif
        [IsoXmlTag("HstChllng")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Binary? HostChallenge { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[]? HostChallenge { get; init; } 
        #else
        public System.Byte[]? HostChallenge { get; set; } 
        #endif
        
        /// <summary>
        /// Ordered certificate chain of the asymmetric key encryption key, starting with the host certificate.
        /// </summary>
        [IsoId("_tNm-wItJEeSxlKlAGYErFg")]
        [DisplayName("Certificate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cert")]
        #endif
        [IsoXmlTag("Cert")]
        [IsoSimpleType(IsoSimpleType.Max5000Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax5000Binary? Certificate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[]? Certificate { get; init; } 
        #else
        public System.Byte[]? Certificate { get; set; } 
        #endif
        
        /// <summary>
        /// Cryptographic key involved in the security command.
        /// </summary>
        [IsoId("_ABCokItKEeSxlKlAGYErFg")]
        [DisplayName("Key Properties")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="KeyProps")]
        #endif
        [IsoXmlTag("KeyProps")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public KEKIdentifier4? KeyProperties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public KEKIdentifier4? KeyProperties { get; init; } 
        #else
        public KEKIdentifier4? KeyProperties { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
