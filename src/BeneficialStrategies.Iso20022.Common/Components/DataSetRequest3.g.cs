﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DataSetRequest3.  ISO2002 ID# _LBawUVEKEeyApZmLzm74zA.
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
/// Identification of requested data set.
/// </summary>
[IsoId("_LBawUVEKEeyApZmLzm74zA")]
[DisplayName("Data Set Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DataSetRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DataSetRequest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DataSetRequest3( DataSetIdentification9 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_LHfjIVEKEeyApZmLzm74zA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification9 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetIdentification9 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification9 Identification { get; init; } 
    #else
    public DataSetIdentification9 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_LHfjI1EKEeyApZmLzm74zA")]
    [DisplayName("POI Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIChllng")]
    #endif
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? POIChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? POIChallenge { get; init; } 
    #else
    public System.Byte[]? POIChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_LHfjJVEKEeyApZmLzm74zA")]
    [DisplayName("TM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllng")]
    #endif
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? TMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TMChallenge { get; init; } 
    #else
    public System.Byte[]? TMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Temporary encryption key that the host will use for protecting keys to download.
    /// </summary>
    [IsoId("_LHfjJ1EKEeyApZmLzm74zA")]
    [DisplayName("Session Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SsnKey")]
    #endif
    [IsoXmlTag("SsnKey")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey16? SessionKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey16? SessionKey { get; init; } 
    #else
    public CryptographicKey16? SessionKey { get; set; } 
    #endif
    
    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    [IsoId("_LHfjKVEKEeyApZmLzm74zA")]
    [DisplayName("Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnProof")]
    #endif
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? DelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationProof { get; init; } 
    #else
    public System.Byte[]? DelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_LHfjK1EKEeyApZmLzm74zA")]
    [DisplayName("Protected Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdDlgtnProof")]
    #endif
    [IsoXmlTag("PrtctdDlgtnProof")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType30? ProtectedDelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType30? ProtectedDelegationProof { get; init; } 
    #else
    public ContentInformationType30? ProtectedDelegationProof { get; set; } 
    #endif
    
    
    #nullable disable
    
}
