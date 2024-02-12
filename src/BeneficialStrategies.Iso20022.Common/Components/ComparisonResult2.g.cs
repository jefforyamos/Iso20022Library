﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ComparisonResult2.  ISO2002 ID# _RbOl4dp-Ed-ak6NoX_4Aeg_153355944.
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
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_RbOl4dp-Ed-ak6NoX_4Aeg_153355944")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Comparison Result")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ComparisonResult2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ComparisonResult2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ComparisonResult2( System.UInt64 reqElementSequenceNumber,System.String reqElementPath,System.String reqElementName,Replacement2 reqReplacement,Deletion2 reqDeletion,Addition2 reqAddition )
    {
        ElementSequenceNumber = reqElementSequenceNumber;
        ElementPath = reqElementPath;
        ElementName = reqElementName;
        Replacement = reqReplacement;
        Deletion = reqDeletion;
        Addition = reqAddition;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequence number assigned to the element.
    /// </summary>
    [IsoId("_RbOl4tp-Ed-ak6NoX_4Aeg_153356284")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Element Sequence Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber ElementSequenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.UInt64 ElementSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ElementSequenceNumber { get; init; } 
    #else
    public System.UInt64 ElementSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies from the root of the message the complete path of the element.
    /// </summary>
    [IsoId("_RbOl49p-Ed-ak6NoX_4Aeg_153355976")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Element Path")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text ElementPath { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ElementPath { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ElementPath { get; init; } 
    #else
    public System.String ElementPath { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the element.
    /// </summary>
    [IsoId("_RbOl5Np-Ed-ak6NoX_4Aeg_153356222")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Element Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ElementName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ElementName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ElementName { get; init; } 
    #else
    public System.String ElementName { get; set; } 
    #endif
    
    /// <summary>
    /// Replacement of an existing content by a different one.
    /// </summary>
    [IsoId("_RbOl5dp-Ed-ak6NoX_4Aeg_153356746")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Replacement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Replacement2 Replacement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Replacement2 Replacement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Replacement2 Replacement { get; init; } 
    #else
    public Replacement2 Replacement { get; set; } 
    #endif
    
    /// <summary>
    /// Deletion of the current element.
    /// </summary>
    [IsoId("_RbOl5tp-Ed-ak6NoX_4Aeg_153356346")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deletion")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Deletion2 Deletion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Deletion2 Deletion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Deletion2 Deletion { get; init; } 
    #else
    public Deletion2 Deletion { get; set; } 
    #endif
    
    /// <summary>
    /// Addition of a new element.
    /// </summary>
    [IsoId("_RbOl59p-Ed-ak6NoX_4Aeg_153356686")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Addition")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Addition2 Addition { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Addition2 Addition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Addition2 Addition { get; init; } 
    #else
    public Addition2 Addition { get; set; } 
    #endif
    
    
    #nullable disable
    
}
