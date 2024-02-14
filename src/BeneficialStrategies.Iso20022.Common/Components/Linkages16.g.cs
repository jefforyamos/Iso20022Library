﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages16.  ISO2002 ID# _H-S6vf7uEeCvPoRGOxRobQ.
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
/// Information related to a linked transaction.
/// </summary>
[IsoId("_H-S6vf7uEeCvPoRGOxRobQ")]
[DisplayName("Linkages")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Linkages16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Linkages16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Linkages16( References24Choice_ reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_H-S6w_7uEeCvPoRGOxRobQ")]
    [DisplayName("Processing Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgPos")]
    #endif
    [IsoXmlTag("PrcgPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition2Choice_? ProcessingPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition2Choice_? ProcessingPosition { get; init; } 
    #else
    public ProcessingPosition2Choice_? ProcessingPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_H-S6zf7uEeCvPoRGOxRobQ")]
    [DisplayName("Message Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNb")]
    #endif
    [IsoXmlTag("MsgNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    #else
    public DocumentNumber1Choice_? MessageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_H-S61_7uEeCvPoRGOxRobQ")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References24Choice_ Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References24Choice_ Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References24Choice_ Reference { get; init; } 
    #else
    public References24Choice_ Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_H-S64f7uEeCvPoRGOxRobQ")]
    [DisplayName("Reference Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefOwnr")]
    #endif
    [IsoXmlTag("RefOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification36Choice_? ReferenceOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification36Choice_? ReferenceOwner { get; init; } 
    #else
    public PartyIdentification36Choice_? ReferenceOwner { get; set; } 
    #endif
    
    
    #nullable disable
    
}
