﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPSSD1V09.  ISO2002 ID# _Vk6qkzDmEey2N-DB7H7A5A.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.010.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPSSD1V09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.010.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPSSD1";
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to corporate action general information.
    /// </summary>
    [IsoId("_Vk6qlTDmEey2N-DB7H7A5A")]
    [Description(@"Information to be extended as supplementary data to corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD51? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_Vk6qnTDmEey2N-DB7H7A5A")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD20? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_Vk6qnzDmEey2N-DB7H7A5A")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD19? CorporateActionDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPSSD1V09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPSSD1V09Document ToDocument()
    {
        return new DTCCCAPSSD1V09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAPSSD1V09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAPSSD1V09Document : IOuterDocument<DTCCCAPSSD1V09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.010.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPSSD1V09"/> is required.
    /// </summary>
    public required DTCCCAPSSD1V09 Message { get; init; }
}
