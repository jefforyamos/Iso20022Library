﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPCSD1V02.  ISO2002 ID# _x6QSWwB6EeqouY-yI_q3qQ.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAPCSD1 message extends ISO corporate action Movement Preliminary Advice Cancellation Advice (CAPC) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAPCSD1 message extends ISO corporate action Movement Preliminary Advice Cancellation Advice (CAPC) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPCSD1V02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPCSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_x6QSXQB6EeqouY-yI_q3qQ")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public SomeCorporateActionGeneralInformationRecord? CorporateActionGeneralInformation { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPCSD1V02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPCSD1V02Document ToDocument()
    {
        return new DTCCCAPCSD1V02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAPCSD1V02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAPCSD1V02Document : IOuterDocument<DTCCCAPCSD1V02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.034.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPCSD1V02"/> is required.
    /// </summary>
    public required DTCCCAPCSD1V02 Message { get; init; }
}
