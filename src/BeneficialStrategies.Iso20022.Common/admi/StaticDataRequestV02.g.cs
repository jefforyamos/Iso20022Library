﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StaticDataRequestV02.  ISO2002 ID# _XX0eARnXEeKKXqHkeUjBbw.
//
namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// The StaticDataRequest message is sent by a participant of a central system to the central system to request a static data report.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The StaticDataRequest message is sent by a participant of a central system to the central system to request a static data report.|")]
public partial record StaticDataRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StatcDataReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StaticDataRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StaticDataRequestV02Document ToDocument()
    {
        return new StaticDataRequestV02Document { Message = this };
    }
}

/// <summary>
/// The StaticDataRequest message is sent by a participant of a central system to the central system to request a static data report.
/// This is the outer document that contains <seealso cref="StaticDataRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StaticDataRequestV02Document : IOuterDocument<StaticDataRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.009.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StaticDataRequestV02"/> is required.
    /// </summary>
    public required StaticDataRequestV02 Message { get; init; }
}
