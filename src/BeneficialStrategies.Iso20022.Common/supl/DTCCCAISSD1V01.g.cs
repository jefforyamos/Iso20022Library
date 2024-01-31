﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAISSD1V01.  ISO2002 ID# _O4RgAJCFEeaSk9d1hvTrHg.
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
/// The DTCCCAISSD1 message extends ISO Corporate Action Instruction Status Advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAISSD1 message extends ISO Corporate Action Instruction Status Advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAISSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAISSD1";
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to security quantity details. Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_fNpxwZYREeaME6y1kTGR7Q")]
    [Description(@"Information to be extended as supplementary data to security quantity details. Provides information about securities quantity linked to a corporate action option.")]
    [DataMember(Name="SctiesQtyDtls")]
    [XmlElement(ElementName="SctiesQtyDtls")]
    public SecuritiesQuantityDetailsSD1? SecuritiesQuantityDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAISSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAISSD1V01Document ToDocument()
    {
        return new DTCCCAISSD1V01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAISSD1V01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAISSD1V01Document : IOuterDocument<DTCCCAISSD1V01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.030.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAISSD1V01"/> is required.
    /// </summary>
    public required DTCCCAISSD1V01 Message { get; init; }
}
