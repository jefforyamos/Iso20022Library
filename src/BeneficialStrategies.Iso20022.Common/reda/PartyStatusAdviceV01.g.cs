﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PartyStatusAdviceV01.  ISO2002 ID# _5jHEEZeSEeen_cyMrluY4w.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// Scope:
/// The PartyStatusAdvice message is sent by the executing party to the instructing party to provide details about the processing of a request on party reference data (create or update).
/// Usage:
/// When processing information is negative - a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed.
/// When processing is successfully performed, the message includes the related party identification.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope:|The PartyStatusAdvice message is sent by the executing party to the instructing party to provide details about the processing of a request on party reference data (create or update).||Usage:|When processing information is negative - a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed.|When processing is successfully performed, the message includes the related party identification.")]
public partial record PartyStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_eEidoVhGEeih3fUfzR38Ig")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Status of the party involved in the originating message.
    /// </summary>
    [IsoId("_5jHEG5eSEeen_cyMrluY4w")]
    [Description(@"Status of the party involved in the originating message.")]
    [DataMember(Name="PtySts")]
    [XmlElement(ElementName="PtySts")]
    [Required]
    public required SomePartyStatusRecord PartyStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5jHEHZeSEeen_cyMrluY4w")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PartyStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PartyStatusAdviceV01Document ToDocument()
    {
        return new PartyStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PartyStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PartyStatusAdviceV01Document : IOuterDocument<PartyStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.016.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PartyStatusAdviceV01"/> is required.
    /// </summary>
    public required PartyStatusAdviceV01 Message { get; init; }
}