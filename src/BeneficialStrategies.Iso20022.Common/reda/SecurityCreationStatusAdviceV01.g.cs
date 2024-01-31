﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecurityCreationStatusAdviceV01.  ISO2002 ID# _jTt_tx62Eeu31YsWNiv_cw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// An executing/servicing party sends a SecurityCreationStatusAdvice message to an instructing party to report the status of a SecurityCreationRequest message previously sent by the instructing party. 
/// 
/// The SecurityCreationStatusAdvice message may be sent as a response to the request of the instructing party or not.
/// 
/// The instructing party - executing/servicing party relationship may be:
/// - Central Securities Depositories (CSD) who would like to publish security static data, or 
/// - a Corporate, or
/// - a Bank, or
/// - a Market Infrastructure, or 
/// - a Market Data Provider.
/// 
/// USAGE
/// Initiator: executing/servicing party.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"SCOPE|An executing/servicing party sends a SecurityCreationStatusAdvice message to an instructing party to report the status of a SecurityCreationRequest message previously sent by the instructing party. ||The SecurityCreationStatusAdvice message may be sent as a response to the request of the instructing party or not.||The instructing party - executing/servicing party relationship may be:|- Central Securities Depositories (CSD) who would like to publish security static data, or |- a Corporate, or|- a Bank, or|- a Market Infrastructure, or |- a Market Data Provider.||USAGE|Initiator: executing/servicing party.")]
public partial record SecurityCreationStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.008.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyCreStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_Jyh98ZIxEeuAlLVx8pyt3w")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public MessageHeader12? MessageHeader { get; init; }
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_jTt_yR62Eeu31YsWNiv_cw")]
    [Description(@"Identification of the financial instrument.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Represents the processing status.
    /// </summary>
    [IsoId("_jTt_yx62Eeu31YsWNiv_cw")]
    [Description(@"Represents the processing status.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    [Required]
    public required IProcessingStatus72Choice ProcessingStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jTt_0R62Eeu31YsWNiv_cw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecurityCreationStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecurityCreationStatusAdviceV01Document ToDocument()
    {
        return new SecurityCreationStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecurityCreationStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecurityCreationStatusAdviceV01Document : IOuterDocument<SecurityCreationStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecurityCreationStatusAdviceV01"/> is required.
    /// </summary>
    public required SecurityCreationStatusAdviceV01 Message { get; init; }
}
