﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification10.  ISO2002 ID# _RaMEFtp-Ed-ak6NoX_4Aeg_-793210991.
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
/// Identifies a document by a unique identification and a version together with the submitter of the document.|Also specifies the type of document and an index for easy referencing.
/// </summary>
[IsoId("_RaMEFtp-Ed-ak6NoX_4Aeg_-793210991")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Document Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentIdentification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentIdentification10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentIdentification10( System.String reqIdentification,System.UInt64 reqVersion,DataSetType2Code reqType,BICIdentification1 reqSubmitter,System.String reqDocumentIndex )
    {
        Identification = reqIdentification;
        Version = reqVersion;
        Type = reqType;
        Submitter = reqSubmitter;
        DocumentIndex = reqDocumentIndex;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RaMEF9p-Ed-ak6NoX_4Aeg_-792290935")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the version of a set of data. Example: Version 1.
    /// </summary>
    [IsoId("_RaMEGNp-Ed-ak6NoX_4Aeg_-792290904")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Version")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.UInt64 Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Version { get; init; } 
    #else
    public System.UInt64 Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of data set.
    /// </summary>
    [IsoId("_RaMEGdp-Ed-ak6NoX_4Aeg_-792290843")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DataSetType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetType2Code Type { get; init; } 
    #else
    public DataSetType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Uniquely identifies the financial institution which has submitted the set of data by using a BIC.
    /// </summary>
    [IsoId("_RaVOANp-Ed-ak6NoX_4Aeg_-792290750")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submitter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 Submitter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BICIdentification1 Submitter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 Submitter { get; init; } 
    #else
    public BICIdentification1 Submitter { get; set; } 
    #endif
    
    /// <summary>
    /// Index assigned to the document, to allow easy referencing.
    /// </summary>
    [IsoId("_RaVOAdp-Ed-ak6NoX_4Aeg_-792290812")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Document Index")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText DocumentIndex { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String DocumentIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DocumentIndex { get; init; } 
    #else
    public System.String DocumentIndex { get; set; } 
    #endif
    
    
    #nullable disable
    
}
