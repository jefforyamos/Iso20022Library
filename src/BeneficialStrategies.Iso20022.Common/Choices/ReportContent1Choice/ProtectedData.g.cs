﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProtectedData.  ISO2002 ID# _f3ucsMlWEeuJ35KoBRZFOg.
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
namespace BeneficialStrategies.Iso20022.Choices.ReportContent1Choice
{
    /// <summary>
    /// Encrypted report content.
    /// </summary>
    [IsoId("_f3ucsMlWEeuJ35KoBRZFOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protected Data")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProtectedData : ReportContent1Choice_
    #else
    public partial class ProtectedData : ReportContent1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProtectedData instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProtectedData( ContentType3Code reqContentType )
        {
            ContentType = reqContentType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of data protection.
        /// </summary>
        [IsoId("_fj-2MEYdEeegp_DADCe7HQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Content Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ContentType3Code ContentType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ContentType3Code ContentType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContentType3Code ContentType { get; init; } 
        #else
        public ContentType3Code ContentType { get; set; } 
        #endif
        
        /// <summary>
        /// Consists of an encrypted content of any type and encrypted content-encryption keys for one or more recipients.  The combination of the encrypted content and one encrypted content-encryption key for a recipient is a "digital   envelope" for that recipient.
        /// </summary>
        [IsoId("_sSSU0EYdEeegp_DADCe7HQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Enveloped Data")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public EnvelopedData6? EnvelopedData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public EnvelopedData6? EnvelopedData { get; init; } 
        #else
        public EnvelopedData6? EnvelopedData { get; set; } 
        #endif
        
        /// <summary>
        /// Contains encrypted data and the attributes used to encrypt the data using the ISO 13492 methods for data encryption.  The encryption key is not included in the message with this method.
        /// </summary>
        [IsoId("_pF-HID6TEeq_lLaSkIVjTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Encrypted Data")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public EncryptedData1? EncryptedData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public EncryptedData1? EncryptedData { get; init; } 
        #else
        public EncryptedData1? EncryptedData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
