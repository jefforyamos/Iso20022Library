﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACOSD1V01.  ISO2002 ID# _1NQlAzL3EeKU9IrkkToqcw_389560889.
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
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACOSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";
    
    #nullable enable
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_1NQlBDL3EeKU9IrkkToqcw_-424160834")]
    [Description(@"Extension block for the information to be extended as corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD1? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [IsoId("_1NQlBTL3EeKU9IrkkToqcw_-1746121200")]
    [Description(@"Information to be extended as corporate action confirmation securities movement details.")]
    [DataMember(Name="CorpActnConfSctiesMvmntDtls")]
    [XmlElement(ElementName="CorpActnConfSctiesMvmntDtls")]
    public CorporateActionConfirmationSecuritiesMovementDetailsSD1? CorporateActionConfirmationSecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action confirmation cash movement details.
    /// </summary>
    [IsoId("_1NQlBjL3EeKU9IrkkToqcw_-419706544")]
    [Description(@"Extension block for the information to be extended as corporate action confirmation cash movement details.")]
    [DataMember(Name="CorpActnConfCshMvmntDtls")]
    [XmlElement(ElementName="CorpActnConfCshMvmntDtls")]
    public CorporateActionConfirmationCashMovementDetailsSD1? CorporateActionConfirmationCashMovementDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACOSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACOSD1V01Document ToDocument()
    {
        return new DTCCCACOSD1V01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACOSD1V01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCACOSD1V01Document : IOuterDocument<DTCCCACOSD1V01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACOSD1V01"/> is required.
    /// </summary>
    public required DTCCCACOSD1V01 Message { get; init; }
}
