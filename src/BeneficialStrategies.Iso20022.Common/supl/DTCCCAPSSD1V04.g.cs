﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPSSD1V04.  ISO2002 ID# _X0scRZ2EEeW-bsa36JFb9A.
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
/// The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAPSSD1 message extends ISO corporate action event processing status advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPSSD1V04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPSSD1";
    
    #nullable enable
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_X0scR52EEeW-bsa36JFb9A")]
    [Description(@"Extension block for the information to be extended as corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD20? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_X0scT52EEeW-bsa36JFb9A")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD9? CorporateActionDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPSSD1V04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPSSD1V04Document ToDocument()
    {
        return new DTCCCAPSSD1V04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAPSSD1V04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAPSSD1V04Document : IOuterDocument<DTCCCAPSSD1V04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.010.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPSSD1V04"/> is required.
    /// </summary>
    public required DTCCCAPSSD1V04 Message { get; init; }
}
