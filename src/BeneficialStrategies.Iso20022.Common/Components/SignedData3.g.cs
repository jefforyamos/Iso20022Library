﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedData3.  ISO2002 ID# _SIFo4VW8EeOlEMHvp-ipJg.
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
/// Digital signature of data, with an asymmetric key.
/// </summary>
[IsoId("_SIFo4VW8EeOlEMHvp-ipJg")]
[DisplayName("Signed Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SignedData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SignedData3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SignedData3( EncapsulatedContent2 reqEncapsulatedContent )
    {
        EncapsulatedContent = reqEncapsulatedContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SS0SMVW8EeOlEMHvp-ipJg")]
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
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_SS0SM1W8EeOlEMHvp-ipJg")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    public AlgorithmIdentification5? DigestAlgorithm { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _SS0SM1W8EeOlEMHvp-ipJg
    
    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_SS0SNVW8EeOlEMHvp-ipJg")]
    [DisplayName("Encapsulated Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcpsltdCntt")]
    #endif
    [IsoXmlTag("NcpsltdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EncapsulatedContent2 EncapsulatedContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EncapsulatedContent2 EncapsulatedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedContent2 EncapsulatedContent { get; init; } 
    #else
    public EncapsulatedContent2 EncapsulatedContent { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_SS0SN1W8EeOlEMHvp-ipJg")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Entity who has signed the data.
    /// </summary>
    [IsoId("_SS0SOVW8EeOlEMHvp-ipJg")]
    [DisplayName("Signer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgnr")]
    #endif
    [IsoXmlTag("Sgnr")]
    public Signer2? Signer { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _SS0SOVW8EeOlEMHvp-ipJg
    
    
    #nullable disable
    
}
