﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingApplicationV01.  ISO2002 ID# _9fRMkHltEeG7BsjMvd1mEw_980511566.
//
namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// The UndertakingApplication message is sent by the party requesting issuance of the undertaking (applicant or obligor) to the party issuing the undertaking. It is used to request the issuance of an undertaking (demand guarantee or standby letter of credit or suretyship) or counter-undertaking (counter-guarantee or counter-standby or suretyship), and provides details on the applicable rules, terms, conditions and content of the undertaking to be issued.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingApplication message is sent by the party requesting issuance of the undertaking (applicant or obligor) to the party issuing the undertaking. It is used to request the issuance of an undertaking (demand guarantee or standby letter of credit or suretyship) or counter-undertaking (counter-guarantee or counter-standby or suretyship), and provides details on the applicable rules, terms, conditions and content of the undertaking to be issued.")]
public partial record UndertakingApplicationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAppl";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Details of the application for an independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.
    /// </summary>
    [IsoId("_9fRMkXltEeG7BsjMvd1mEw_-1409870883")]
    [Description(@"Details of the application for an independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.")]
    [DataMember(Name="UdrtkgApplDtls")]
    [XmlElement(ElementName="UdrtkgApplDtls")]
    [Required]
    public required SomeUndertakingApplicationDetailsRecord UndertakingApplicationDetails { get; init; }
    
    /// <summary>
    /// Instructions specific to the bank receiving the message.
    /// </summary>
    [IsoId("__KBlo3_5EeGOn4dfTT_QdQ")]
    [Description(@"Instructions specific to the bank receiving the message.")]
    [DataMember(Name="InstrsToBk")]
    [XmlElement(ElementName="InstrsToBk")]
    public required IReadonlyCollection<SomeInstructionsToBankRecord> InstructionsToBank { get; init; } // Min=0, Max=5
    
    /// <summary>
    /// Digital signature of the undertaking application.
    /// </summary>
    [IsoId("_9fRMknltEeG7BsjMvd1mEw_-448392239")]
    [Description(@"Digital signature of the undertaking application.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public SomeDigitalSignatureRecord? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingApplicationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingApplicationV01Document ToDocument()
    {
        return new UndertakingApplicationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingApplicationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingApplicationV01Document : IOuterDocument<UndertakingApplicationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.005.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingApplicationV01"/> is required.
    /// </summary>
    public required UndertakingApplicationV01 Message { get; init; }
}
