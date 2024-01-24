﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NettingCutOffReferenceDataUpdateRequestV01.  ISO2002 ID# _CYWUEJVFEeaYkf5FCqYMeA.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The Netting Cut Off Reference Data Update Request message is sent to a central system by a participant to request an update to a participant's netting cut off held at the central system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The Netting Cut Off Reference Data Update Request message is sent to a central system by a participant to request an update to a participant's netting cut off held at the central system.")]
public partial record NettingCutOffReferenceDataUpdateRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetgCutOffRefDataUpdReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Specifies the meta data for the netting cut off update request.
    /// </summary>
    [IsoId("_5WY5cJVGEeaYkf5FCqYMeA")]
    [Description(@"Specifies the meta data for the netting cut off update request.")]
    [DataMember(Name="ReqData")]
    [XmlElement(ElementName="ReqData")]
    [Required]
    public required SomeRequestDataRecord RequestData { get; init; }
    
    /// <summary>
    /// Specifies the information regarding the changes to the netting cut off.
    /// </summary>
    [IsoId("_-cihoJVLEeaYkf5FCqYMeA")]
    [Description(@"Specifies the information regarding the changes to the netting cut off.")]
    [DataMember(Name="NetgCutOffReq")]
    [XmlElement(ElementName="NetgCutOffReq")]
    [Required]
    public required SomeNettingCutOffRequestRecord NettingCutOffRequest { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Yna6IJVMEeaYkf5FCqYMeA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NettingCutOffReferenceDataUpdateRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NettingCutOffReferenceDataUpdateRequestV01Document ToDocument()
    {
        return new NettingCutOffReferenceDataUpdateRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NettingCutOffReferenceDataUpdateRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NettingCutOffReferenceDataUpdateRequestV01Document : IOuterDocument<NettingCutOffReferenceDataUpdateRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.060.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NettingCutOffReferenceDataUpdateRequestV01"/> is required.
    /// </summary>
    public required NettingCutOffReferenceDataUpdateRequestV01 Message { get; init; }
}
