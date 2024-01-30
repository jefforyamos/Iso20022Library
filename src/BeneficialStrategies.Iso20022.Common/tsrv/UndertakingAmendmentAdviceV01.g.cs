﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingAmendmentAdviceV01.  ISO2002 ID# _9gJ9ZnltEeG7BsjMvd1mEw_1371399250.
//
namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// The UndertakingAmendmentAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the content of a proposed amendment to an undertaking. Information about the message may also be sent to other interested parties. The proposed undertaking amendment could be to a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing the terms of the proposed amendment and relevant details on proposed changes to the undertaking, the message may provide information from the sender such as confirmation details. It may also be used to advise the proposed termination or cancellation of the undertaking.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingAmendmentAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the content of a proposed amendment to an undertaking. Information about the message may also be sent to other interested parties. The proposed undertaking amendment could be to a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing the terms of the proposed amendment and relevant details on proposed changes to the undertaking, the message may provide information from the sender such as confirmation details. It may also be used to advise the proposed termination or cancellation of the undertaking.")]
public partial record UndertakingAmendmentAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Party advising the undertaking to the beneficiary or to another party.
    /// </summary>
    [IsoId("_pUXylT1XEeKWjKfYlNE7jQ")]
    [Description(@"Party advising the undertaking to the beneficiary or to another party.")]
    [DataMember(Name="AdvsgPty")]
    [XmlElement(ElementName="AdvsgPty")]
    [Required]
    public required PartyIdentification43 AdvisingParty { get; init; }
    
    /// <summary>
    /// Additional party that advises the undertaking.
    /// </summary>
    [IsoId("_rsgupT1XEeKWjKfYlNE7jQ")]
    [Description(@"Additional party that advises the undertaking.")]
    [DataMember(Name="ScndAdvsgPty")]
    [XmlElement(ElementName="ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; }
    
    /// <summary>
    /// Date on which the undertaking is advised.
    /// </summary>
    [IsoId("_uNTQYz1XEeKWjKfYlNE7jQ")]
    [Description(@"Date on which the undertaking is advised.")]
    [DataMember(Name="DtOfAdvc")]
    [XmlElement(ElementName="DtOfAdvc")]
    [Required]
    public required IsoISODate DateOfAdvice { get; init; }
    
    /// <summary>
    /// Details related to the advice of the proposed amended undertaking.
    /// </summary>
    [IsoId("_9gJ9Z3ltEeG7BsjMvd1mEw_315692948")]
    [Description(@"Details related to the advice of the proposed amended undertaking.")]
    [DataMember(Name="UdrtkgAmdmntAdvcDtls")]
    [XmlElement(ElementName="UdrtkgAmdmntAdvcDtls")]
    [Required]
    public required Amendment2 UndertakingAmendmentAdviceDetails { get; init; }
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_EUVqJxWyEeKtPMeuz5Qhfw")]
    [Description(@"Additional information specific to the bank-to-bank communication.")]
    [DataMember(Name="BkToBkInf")]
    [XmlElement(ElementName="BkToBkInf")]
    public required IReadonlyCollection<IsoMax2000Text> BankToBankInformation { get; init; } // Min=0, Max=5
    
    /// <summary>
    /// Digital signature of the proposed amendment advice.
    /// </summary>
    [IsoId("_9gJ9aHltEeG7BsjMvd1mEw_1348230221")]
    [Description(@"Digital signature of the proposed amendment advice.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingAmendmentAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingAmendmentAdviceV01Document ToDocument()
    {
        return new UndertakingAmendmentAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingAmendmentAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingAmendmentAdviceV01Document : IOuterDocument<UndertakingAmendmentAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.006.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingAmendmentAdviceV01"/> is required.
    /// </summary>
    public required UndertakingAmendmentAdviceV01 Message { get; init; }
}
