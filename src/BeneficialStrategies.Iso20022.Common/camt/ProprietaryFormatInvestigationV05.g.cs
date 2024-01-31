﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ProprietaryFormatInvestigationV05.  ISO2002 ID# _eYI_FW2PEei3KuUgpx7Xcw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// Scope
/// The ProprietaryFormatInvestigation message type is used by financial institutions, with their own offices, and/or with other financial institutions with which they have established bilateral agreements.
/// Usage
/// The user should ensure that an existing standard message cannot be used before using the proprietary message.
/// As defined in the scope, this ProprietaryFormatInvestigation message may only be used when bilaterally agreed.
/// It is used as an envelope for a non standard message and provides means to manage an exception or investigation which falls outside the scope or capability of any other formatted message.
/// The ProprietaryData element must contain a well formed XML document. This means XML special characters such as '<' must be used in a way that is consistent with XML well-formedness criteria.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ProprietaryFormatInvestigation message type is used by financial institutions, with their own offices, and/or with other financial institutions with which they have established bilateral agreements.|Usage|The user should ensure that an existing standard message cannot be used before using the proprietary message.|As defined in the scope, this ProprietaryFormatInvestigation message may only be used when bilaterally agreed.|It is used as an envelope for a non standard message and provides means to manage an exception or investigation which falls outside the scope or capability of any other formatted message.|The ProprietaryData element must contain a well formed XML document. This means XML special characters such as '<' must be used in a way that is consistent with XML well-formedness criteria.")]
public partial record ProprietaryFormatInvestigationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtryFrmtInvstgtn";
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eYI_F22PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment5 Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eYI_GW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public Case5? Case { get; init; }
    
    /// <summary>
    /// Proprietary information.
    /// </summary>
    [IsoId("_eYI_G22PEei3KuUgpx7Xcw")]
    [Description(@"Proprietary information.")]
    [DataMember(Name="PrtryData")]
    [XmlElement(ElementName="PrtryData")]
    [Required]
    public required ProprietaryData7 ProprietaryData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_HW2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ProprietaryFormatInvestigationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ProprietaryFormatInvestigationV05Document ToDocument()
    {
        return new ProprietaryFormatInvestigationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ProprietaryFormatInvestigationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ProprietaryFormatInvestigationV05Document : IOuterDocument<ProprietaryFormatInvestigationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.035.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ProprietaryFormatInvestigationV05"/> is required.
    /// </summary>
    public required ProprietaryFormatInvestigationV05 Message { get; init; }
}
