﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateAcceptanceReportV04.  ISO2002 ID# _Ie2IQRPeEeSVo-TFVwFHvA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.012.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).
/// A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.
/// Usage
/// The MandateAcceptanceReport message can contain one or more confirmation(s) of acceptance or rejection of a specific Mandate Request.
/// The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.
/// The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(@"Scope|The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).|A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.|Usage|The MandateAcceptanceReport message can contain one or more confirmation(s) of acceptance or rejection of a specific Mandate Request.|The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.|The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.")]
[IsoId("_Ie2IQRPeEeSVo-TFVwFHvA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Mandate Acceptance Report V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAcceptanceReportV04 : IOuterRecord<MandateAcceptanceReportV04,MandateAcceptanceReportV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.012.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAccptncRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MandateAcceptanceReportV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateAcceptanceReportV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateAcceptanceReportV04( GroupHeader47 reqGroupHeader,MandateAcceptance4 reqUnderlyingAcceptanceDetails )
    {
        GroupHeader = reqGroupHeader;
        UnderlyingAcceptanceDetails = reqUnderlyingAcceptanceDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.
    /// </summary>
    [IsoId("_Ie2IRRPeEeSVo-TFVwFHvA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader47 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GroupHeader47 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader47 GroupHeader { get; init; } 
    #else
    public GroupHeader47 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the acception or rejection of the mandate request.
    /// </summary>
    [IsoId("_Ie2IRxPeEeSVo-TFVwFHvA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying Acceptance Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MandateAcceptance4 UnderlyingAcceptanceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MandateAcceptance4 UnderlyingAcceptanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateAcceptance4 UnderlyingAcceptanceDetails { get; init; } 
    #else
    public MandateAcceptance4 UnderlyingAcceptanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ie2ISRPeEeSVo-TFVwFHvA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateAcceptanceReportV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateAcceptanceReportV04Document ToDocument()
    {
        return new MandateAcceptanceReportV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateAcceptanceReportV04"/>.
/// </summary>
[Serializable]
public partial record MandateAcceptanceReportV04Document : IOuterDocument<MandateAcceptanceReportV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.012.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateAcceptanceReportV04"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MandateAcceptanceReportV04 Message { get; init; }
    #else
    public MandateAcceptanceReportV04 Message { get; init; }
    #endif
}
