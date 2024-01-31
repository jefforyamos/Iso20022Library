﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateAcceptanceReportV02.  ISO2002 ID# _rwGZYFkyEeGeoaLUQk__nA_1820631680.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.pain;


/// <summary>
/// This record is an implementation of the pain.012.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).
/// A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.
/// Usage
/// The MandateAcceptanceReport message can contain only one confirmation of acceptance of rejection of one specific MandateRequest message.
/// The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.
/// The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).|A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.|Usage|The MandateAcceptanceReport message can contain only one confirmation of acceptance of rejection of one specific MandateRequest message.|The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.|The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.")]
public partial record MandateAcceptanceReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.012.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAccptncRpt";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.
    /// </summary>
    [IsoId("_rwZUUFkyEeGeoaLUQk__nA_136321228")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader47 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to provide information on the acception or rejection of the mandate request.
    /// </summary>
    [IsoId("_rwjFUFkyEeGeoaLUQk__nA_-746912059")]
    [Description(@"Set of elements used to provide information on the acception or rejection of the mandate request.")]
    [DataMember(Name="UndrlygAccptncDtls")]
    [XmlElement(ElementName="UndrlygAccptncDtls")]
    [Required]
    public required MandateAcceptance2 UnderlyingAcceptanceDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rwjFUVkyEeGeoaLUQk__nA_-467468330")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateAcceptanceReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateAcceptanceReportV02Document ToDocument()
    {
        return new MandateAcceptanceReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateAcceptanceReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MandateAcceptanceReportV02Document : IOuterDocument<MandateAcceptanceReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.012.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateAcceptanceReportV02"/> is required.
    /// </summary>
    public required MandateAcceptanceReportV02 Message { get; init; }
}
