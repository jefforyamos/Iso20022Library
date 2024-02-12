﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ChequeCancellationOrStopRequestV01.  ISO2002 ID# _E2tqILSIEeq3lpO-mRtrig.
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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.108.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ChequeCancellationOrStopRequest message is sent by a drawer bank, or a bank acting on behalf of the drawer bank, to the agent on which a cheque has been drawn (the drawee bank) to request for the cancellation of the presentment and/or stop the payment of the cheque referred to in the message.
/// </summary>
[Description(@"The ChequeCancellationOrStopRequest message is sent by a drawer bank, or a bank acting on behalf of the drawer bank, to the agent on which a cheque has been drawn (the drawee bank) to request for the cancellation of the presentment and/or stop the payment of the cheque referred to in the message.")]
[IsoId("_E2tqILSIEeq3lpO-mRtrig")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cheque Cancellation Or Stop Request V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ChequeCancellationOrStopRequestV01 : IOuterRecord<ChequeCancellationOrStopRequestV01,ChequeCancellationOrStopRequestV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.108.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChqCxlOrStopReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ChequeCancellationOrStopRequestV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ChequeCancellationOrStopRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ChequeCancellationOrStopRequestV01( GroupHeader103 reqGroupHeader,Cheque15 reqCheque )
    {
        GroupHeader = reqGroupHeader;
        Cheque = reqCheque;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual cheques included in the message.
    /// </summary>
    [IsoId("_-sAwgSm5EeutWNGMV2XKIQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader103 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GroupHeader103 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader103 GroupHeader { get; init; } 
    #else
    public GroupHeader103 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details of the cheque.
    /// </summary>
    [IsoId("_euIoobtuEeq_cfXrH83Rcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cheque")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Cheque15 Cheque { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Cheque15 Cheque { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cheque15 Cheque { get; init; } 
    #else
    public Cheque15 Cheque { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U-kiI7tlEeq_cfXrH83Rcw")]
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
    /// Using the state of this record, returns a populated <seealso cref="ChequeCancellationOrStopRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ChequeCancellationOrStopRequestV01Document ToDocument()
    {
        return new ChequeCancellationOrStopRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ChequeCancellationOrStopRequestV01"/>.
/// </summary>
[Serializable]
public partial record ChequeCancellationOrStopRequestV01Document : IOuterDocument<ChequeCancellationOrStopRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.108.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ChequeCancellationOrStopRequestV01"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChequeCancellationOrStopRequestV01 Message { get; init; }
    #else
    public ChequeCancellationOrStopRequestV01 Message { get; init; }
    #endif
}
