﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for KeyTransport7.  ISO2002 ID# _SNoCoS8jEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key encryption key (KEK), encrypted with a previously distributed asymmetric public key.
/// </summary>
[IsoId("_SNoCoS8jEeu125Ip9zFcsQ")]
[DisplayName("Key Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record KeyTransport7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a KeyTransport7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public KeyTransport7( Recipient9Choice_ reqRecipientIdentification,AlgorithmIdentification19 reqKeyEncryptionAlgorithm,System.Byte[] reqEncryptedKey )
    {
        RecipientIdentification = reqRecipientIdentification;
        KeyEncryptionAlgorithm = reqKeyEncryptionAlgorithm;
        EncryptedKey = reqEncryptedKey;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SahPIS8jEeu125Ip9zFcsQ")]
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
    /// Identification of a cryptographic asymmetric key for the recipient.
    /// </summary>
    [IsoId("_SahPIy8jEeu125Ip9zFcsQ")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Recipient9Choice_ RecipientIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Recipient9Choice_ RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Recipient9Choice_ RecipientIdentification { get; init; } 
    #else
    public Recipient9Choice_ RecipientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [IsoId("_SahPJS8jEeu125Ip9zFcsQ")]
    [DisplayName("Key Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyNcrptnAlgo")]
    #endif
    [IsoXmlTag("KeyNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification19 KeyEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [IsoId("_SahPJy8jEeu125Ip9zFcsQ")]
    [DisplayName("Encrypted Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdKey")]
    #endif
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax5000Binary EncryptedKey { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] EncryptedKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] EncryptedKey { get; init; } 
    #else
    public System.Byte[] EncryptedKey { get; set; } 
    #endif
    
    
    #nullable disable
    
}
