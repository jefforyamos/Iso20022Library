﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAICSD1V01.  ISO2002 ID# _b8UwkL5OEeexmbB7KsjCwA.
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
/// The DTCCCAICSD1 message extends ISO corporate action Instruction Cancellation Request (CAIC) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAICSD1 message extends ISO corporate action Instruction Cancellation Request (CAIC) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAICSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAICSD1";
    
    #nullable enable
    /// <summary>
    /// Supplementary data extending corporate action instruction cancellation request message with corporate action reorganisation elements not covered in the standard message.
    /// </summary>
    [IsoId("_fcQ_wMYxEeesocHIuVGr7g")]
    [Description(@"Supplementary data extending corporate action instruction cancellation request message with corporate action reorganisation elements not covered in the standard message.")]
    [DataMember(Name="ReorgInstrCxlDtls")]
    [XmlElement(ElementName="ReorgInstrCxlDtls")]
    public required IReadOnlyCollection<ReorganisationInstructionDetailsSD3> ReorganisationInstructionCancellationDetails { get; init; } = []; // Min=0, Max=12
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAICSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAICSD1V01Document ToDocument()
    {
        return new DTCCCAICSD1V01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAICSD1V01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAICSD1V01Document : IOuterDocument<DTCCCAICSD1V01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.032.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAICSD1V01"/> is required.
    /// </summary>
    public required DTCCCAICSD1V01 Message { get; init; }
}
