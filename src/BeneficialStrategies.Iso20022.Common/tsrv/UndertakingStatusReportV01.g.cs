﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingStatusReportV01.  ISO2002 ID# _9h8tJXltEeG7BsjMvd1mEw_-329334493.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsrv;


/// <summary>
/// This record is an implementation of the tsrv.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingStatusReport message is exchanged between parties that have an interest in the referenced undertaking transaction. It notifies the recipient of the status of the transaction, such as acceptance or rejection, withdrawal, or non-conformation. The sender may add additional information, as appropriate.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingStatusReport message is exchanged between parties that have an interest in the referenced undertaking transaction. It notifies the recipient of the status of the transaction, such as acceptance or rejection, withdrawal, or non-conformation. The sender may add additional information, as appropriate.")]
public partial record UndertakingStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgStsRpt";
    
    #nullable enable
    /// <summary>
    /// Details of the undertaking status report.
    /// </summary>
    [IsoId("_9h8tJnltEeG7BsjMvd1mEw_-1217857261")]
    [Description(@"Details of the undertaking status report.")]
    [DataMember(Name="UdrtkgStsRptDtls")]
    [XmlElement(ElementName="UdrtkgStsRptDtls")]
    [Required]
    public required UndertakingStatusAdvice1 UndertakingStatusReportDetails { get; init; }
    
    /// <summary>
    /// Digital signature of the report.
    /// </summary>
    [IsoId("_9h8tJ3ltEeG7BsjMvd1mEw_1390197264")]
    [Description(@"Digital signature of the report.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingStatusReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingStatusReportV01Document ToDocument()
    {
        return new UndertakingStatusReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingStatusReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingStatusReportV01Document : IOuterDocument<UndertakingStatusReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.019.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingStatusReportV01"/> is required.
    /// </summary>
    public required UndertakingStatusReportV01 Message { get; init; }
}
